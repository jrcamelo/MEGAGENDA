using MEGAGENDA.CONTROLLER;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEGAGENDA.MODEL
{
    [Serializable]
    public class Pagamento
    {
        public int EID;

        public double valor;
        public DateTime data;
        public bool pago;
        public int parcela;

        public Pagamento(int eid, double valor, DateTime data, bool pago, int parcela)
        {
            this.EID = eid;
            this.valor = valor;
            this.data = data;
            this.pago = pago;
            this.parcela = parcela;
        }



        public static List<Pagamento> Build(SQLiteDataReader reader)
        {
            List<Pagamento> pagamentos = new List<Pagamento>();
            if (reader != null && reader.HasRows)
                while (reader.Read())
                    pagamentos.Add(new Pagamento(
                        Database.ObjToInt(reader["Evento_FK"]),
                        Database.ObjToDouble(reader["Valor"]),
                        Database.ObjToDate(reader["Vencimento"]),
                        bool.Parse(reader["Pago"].ToString()),
                        Database.ObjToInt(reader["Parcela"])));
            return pagamentos;
        }

        public static List<Pagamento> Get(int eid)
        {
            string sql = $"SELECT * FROM Pagamento WHERE Evento_FK = @eid";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@eid", eid);

            SQLiteDataReader reader = Database.DoReader(sql, parameters);

            List<Pagamento> result = Build(reader);
            return result;
        }

        public static List<Pagamento> GetAll(string where = "")
        {
            string sql = $"SELECT * FROM Pagamento ";

            SQLiteDataReader reader = Database.DoReader(sql + where);

            List<Pagamento> result = Build(reader);
            return result;
        }
        public static List<Pagamento> GetAllDatas(string where = "")
        {
            string sql = $"SELECT Evento_FK, Pagamento.Valor as Valor, Pago, Vencimento, Parcela FROM Pagamento JOIN Evento ON Evento_FK = Evento_ID ";

            SQLiteDataReader reader = Database.DoReader(sql + where);

            List<Pagamento> result = Build(reader);
            return result;
        }

        public static int Add(List<Pagamento> pagamentos, int eid)
        {
            // Servindo como um UPDATE
            DeleteEvento(eid);

            int contagem = 0;
            foreach (Pagamento p in pagamentos)
            {
                string sql = "INSERT INTO Pagamento (Evento_FK, Parcela, Valor, Vencimento, Pago) ";
                sql += $"VALUES (@eid, @parcela, @valor, @data, @pago)";

                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@eid", eid);
                parameters.Add("@parcela", p.parcela);
                parameters.Add("@valor", p.valor);
                parameters.Add("@data", p.data.ToString("yyyy-MM-dd"));
                parameters.Add("@pago", p.pago);

                contagem += Database.DoNonQuery(sql, parameters, Erro.SEM_ALTERACOES);
            }

            Debug.Log($"{contagem} PAGAMENTOS ADICIONADOS DO EVENTO {eid}");
            return contagem - pagamentos.Count;
        }

        public static int DeleteEvento(int EID)
        {
            string sql = $"DELETE FROM Pagamento WHERE Evento_FK = @eid";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@eid", EID);

            int result = Database.DoScalar(sql, parameters);
            if (result == Erro.ERRO_SCALAR)
                result = 0;
            Debug.Log($"{result} PAGAMENTOS DELETADOS DO EVENTO {EID}");
            return result;
        }
    }
}
