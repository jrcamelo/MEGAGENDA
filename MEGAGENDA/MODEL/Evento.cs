using MEGAGENDA.CONTROLLER;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEGAGENDA.MODEL
{
    [Serializable]
    public class Evento
    {
        public int ID = -1;
        public int PID = -1;
        
        public string tipo;
        public string protagonista;

        public double valor;

        public List<string> equipe;

        public Endereco local;

        public DateTime data;
        public DateTime horaCabine;
        public DateTime horaEvento;
        public double duracao;

        public bool guestbook;
        public bool material = false;

        public int situacao = 2;
        
        public string observacoes;

        public List<Pagamento> pagamentos = new List<Pagamento>();
        public Pessoa cliente;

        public Evento(int pid, string tipo, string protagonista, double valor, List<string> equipe,
            Endereco local, DateTime data, DateTime horacabine, DateTime horaevento, double duracao, bool guestbook, bool material,
            int situacao, string observacoes, List<Pagamento> pagamentos, int id = -1, Pessoa cliente = null)
        {
            this.ID = id;
            this.PID = pid;
            this.tipo = tipo;
            this.protagonista = protagonista;
            this.valor = valor;
            this.equipe = equipe;
            this.local = local;
            this.data = data;
            this.horaCabine = horacabine;
            this.horaEvento = horaevento;
            this.guestbook = guestbook;
            this.material = material;
            this.situacao = situacao;
            this.observacoes = observacoes;
            this.pagamentos = pagamentos;
            this.cliente = cliente;
        }        

        public Evento(int id, string tipo, int situacao, DateTime data)
        {
            this.ID = id;
            this.tipo = tipo;
            this.data = data;
            this.situacao = situacao;
        }

        public double getEntrada()
        {
            if (pagamentos.Count > 0)
                return pagamentos[0].valor;
            return 0;
        }







        public static Evento Build(SQLiteDataReader reader)
        {
            Evento evento = null;
            if (reader != null && reader.HasRows)
                evento = new Evento(
                    Database.ObjToInt(reader["Pessoa_FK"]),
                    Database.ObjToString(reader["Tipo"]),
                    Database.ObjToString(reader["Protagonista"]),
                    Database.ObjToDouble(reader["Valor"]),
                    Equipe.GetIdents(Database.ObjToInt(reader["Evento_ID"])),
                    Endereco.Get(Database.ObjToInt(reader["Endereco_FK"])),
                    Database.ObjToDate(reader["Data"]),
                    Database.ObjToTime(reader["horaCabine"]),
                    Database.ObjToTime(reader["horaEvento"]),
                    Database.ObjToInt(reader["Duracao"]),
                    bool.Parse(reader["Guestbook"].ToString()),
                    bool.Parse(reader["MaterialPronto"].ToString()),
                    Database.ObjToInt(reader["Situacao"]),
                    Database.ObjToString(reader["Observacoes"]),
                    Pagamento.Get(Database.ObjToInt(reader["Evento_ID"])),
                    Database.ObjToInt(reader["Evento_ID"]));
            return evento;
        }
        public static Tuple<Evento, Pessoa> BuildwCliente(SQLiteDataReader reader)
        {
            Evento evento = null;
            Pessoa pessoa = null;
            if (reader != null && reader.HasRows)
            {
                evento = new Evento(
                    Database.ObjToInt(reader["Pessoa_FK"]),
                    Database.ObjToString(reader["Tipo"]),
                    Database.ObjToString(reader["Protagonista"]),
                    Database.ObjToDouble(reader["Valor"]),
                    Equipe.GetIdents(Database.ObjToInt(reader["Evento_ID"])),
                    Endereco.Get(Database.ObjToInt(reader["Endereco_FK"])),
                    Database.ObjToDate(reader["Data"]),
                    Database.ObjToTime(reader["horaCabine"]),
                    Database.ObjToTime(reader["horaEvento"]),
                    Database.ObjToInt(reader["Duracao"]),
                    bool.Parse(reader["Guestbook"].ToString()),
                    bool.Parse(reader["MaterialPronto"].ToString()),
                    Database.ObjToInt(reader["Situacao"]),
                    Database.ObjToString(reader["Observacoes"]),
                    null,
                    Database.ObjToInt(reader["Evento_ID"]));
                pessoa = Pessoa.Build(reader);
            }
            return new Tuple<Evento, Pessoa>(evento, pessoa);
        }

        public static Evento Get(int id)
        {
            string sql = $"SELECT * FROM Evento WHERE Evento_ID = @id";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@id", id);

            SQLiteDataReader reader = Database.DoReader(sql, parameters);
            Evento evento = Build(reader);
            return evento;
        }

        public static Evento Get(int pid, string tipo, DateTime data, string observ)
        {
            string sql = $"SELECT * FROM Evento WHERE ";
            sql += $"Pessoa_FK = @pid AND Tipo = @tipo AND Data = @data AND Observacoes = @observacoes";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@pid", pid);
            parameters.Add("@tipo", tipo);
            parameters.Add("@data", data.ToString("yyyy-MM-dd"));
            parameters.Add("@observacoes", observ);

            SQLiteDataReader reader = Database.DoReader(sql, parameters);
            Evento evento = Build(reader);
            return evento;
        }
        
        public static List<Evento> GetAllDatas(string where = "")
        {
            string sql = $"SELECT Evento_ID, Tipo, Situacao, Data FROM Evento ";

            List<Evento> eventos = new List<Evento>();
            SQLiteDataReader reader = Database.DoReader(sql + where);

            if (reader != null && reader.HasRows)
                while (reader.Read())
                    eventos.Add(new Evento(
                        Database.ObjToInt(reader["Evento_ID"]),
                        Database.ObjToString(reader["Tipo"]),
                        Database.ObjToInt(reader["Situacao"]),
                        Database.ObjToDate(reader["Data"])));
            return eventos;
        }

        public static List<string> GetAllTipos()
        {
            string sql = $"SELECT Tipo FROM Evento GROUP BY Tipo ORDER BY Tipo DESC";

            List<string> tipos = new List<string>();
            SQLiteDataReader reader = Database.DoReader(sql);

            if (reader != null && reader.HasRows)
                while (reader.Read())
                    tipos.Add(Database.ObjToString(reader["Tipo"]));
            return tipos;
        }

        public static int Add(Evento ev)
        {
            // Dois tipos de busca, pra evitar duplicatas
            Evento evento_existente = Get(ev.ID);
            if (evento_existente == null)
                evento_existente = Get(ev.PID, ev.tipo, ev.data, ev.observacoes);
            if (evento_existente != null)
            {
                Debug.Log($"EVENTO JÁ EXISTENTE: {evento_existente.ID}");
                return evento_existente.ID;
            }

            if (ev.local == null)
                return -404;
            if (ev.local.id < 1)
                ev.local.id = Endereco.Add(ev.local);
            if (ev.local.id < 1)
                return ev.local.id;

            string sql = "INSERT INTO Evento (Pessoa_FK, Endereco_FK, Tipo, Situacao, Protagonista, Valor, Data, Duracao, horaCabine, horaEvento, Guestbook, MaterialPronto, Observacoes) ";
            sql += $"VALUES (@pid, @local, @tipo, @situacao, @protagonista, @valor, @data, @duracao, @horacabine, @horaevento, @guestbook, @material, @observacoes)";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@pid", ev.PID);
            parameters.Add("@local", ev.local.id);
            parameters.Add("@tipo", ev.tipo);
            parameters.Add("@situacao", ev.situacao);
            parameters.Add("@protagonista", ev.protagonista);
            parameters.Add("@valor", ev.valor);
            parameters.Add("@data", ev.data.ToString("yyyy-MM-dd"));
            parameters.Add("@duracao", ev.duracao);
            parameters.Add("@horacabine", ev.horaCabine);
            parameters.Add("@horaevento", ev.horaEvento);
            parameters.Add("@guestbook", ev.guestbook);
            parameters.Add("@material", ev.material);
            parameters.Add("@observacoes", ev.observacoes);

            int result = Database.DoScalar(sql, parameters);
            if (result > 0)
            {
                if (ev.pagamentos.Count > 0)
                {
                    ev.pagamentos[0].EID = result;
                    Pagamento.Add(ev.pagamentos, result);
                }

                if (ev.equipe.Count > 0)
                {
                    Equipe.Add(ev.equipe, result);
                }
                Debug.Log($"EVENTO ADICIONADO: {result}");
            }
            else
                Debug.Log("EVENTO NÃO ADICIONADO");
            //
            return result;
        }

        public static int Edit(Evento ev)
        {
            string sql = "UPDATE Evento SET ";
            sql += $"Pessoa_FK = @pid, Endereco_FK = @local, Tipo = @tipo, Situacao = @situacao, Protagonista = @protagonista, Valor = @valor, Data = @data, Duracao = @duracao, horaCabine = @horacabine, horaEvento = @horaevento, Guestbook = @guestbook, MaterialPronto = @material, Observacoes = @observacoes ";
            sql += $"WHERE Evento_ID = @id";

            int result = Endereco.Edit(ev.local);
            if (result > 0)
            {
                ev.local.id = result;
                Debug.Log("ENDEREÇO ALTERADO");
            }

            // Pagamento.DeleteEvento(ev.ID);

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@id", ev.ID);
            parameters.Add("@pid", ev.PID);
            parameters.Add("@local", ev.local.id);
            parameters.Add("@tipo", ev.tipo);
            parameters.Add("@situacao", ev.situacao);
            parameters.Add("@protagonista", ev.protagonista);
            parameters.Add("@valor", ev.valor);
            parameters.Add("@data", ev.data.ToString("yyyy-MM-dd"));
            parameters.Add("@duracao", ev.duracao);
            parameters.Add("@horacabine", ev.horaCabine);
            parameters.Add("@horaevento", ev.horaEvento);
            parameters.Add("@guestbook", ev.guestbook);
            parameters.Add("@material", ev.material);
            parameters.Add("@observacoes", ev.observacoes);
                                    
            result = Database.DoNonQuery(sql, parameters, Erro.EVENTO_NAO_EDITADO);
            if (result == Erro.EVENTO_NAO_EDITADO)
                Debug.Log("EVENTO NÃO FOI EDITADO");
            else
                Debug.Log("EVENTO FOI EDITADO");

            Console.WriteLine(ev.equipe.Count);
            Console.WriteLine(ev.equipe.Count);
            Console.WriteLine(ev.equipe.Count);
            Console.WriteLine(ev.equipe.Count);

            if (result > 0)
            {
                Pagamento.Add(ev.pagamentos, ev.ID);
                Equipe.Add(ev.equipe, ev.ID);
            }

            return result;
        }

        public static int Delete(int id)
        {
            //Pagamento.DeleteEvento(id);
            string sql = $"DELETE FROM Evento WHERE Evento_ID = @id";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@id", id);

            int result = Database.DoNonQuery(sql, parameters, Erro.EVENTO_NAO_DELETADO);
            if (result == Erro.EVENTO_NAO_DELETADO)
                Debug.Log($"EVENTO {id} NÃO DELETADO");
            else
                Debug.Log($"EVENTO {id} DELETADO");
            return result;
        }




        public static DataTable TableEvento(string where, Dictionary<string, object> parameters = null)
        {
            string subquery = "(SELECT Vencimento FROM Pagamento WHERE Evento_FK = Evento.Evento_ID AND Pago = 0 ORDER BY ROWID DESC LIMIT 1) 'Prox. Parcela'";
            string query = $"SELECT Evento_ID as ID, Pessoa_FK as Cliente, Tipo, Data, {subquery} FROM Evento";
            string order = " ORDER BY ROWID DESC";

            return Database.SelectQuery(query + where + order, parameters);
        }


        public static List<Tuple<Evento, Pessoa>> GetAgendadosData(DateTime datade, DateTime dataa, int situacao = 1)
        {
            string sql = $"SELECT * FROM Evento JOIN Pessoa ON Pessoa_FK = Pessoa_ID ";
            string where = " WHERE Situacao = @situacao AND Data BETWEEN @datade AND @dataa ";

            Dictionary<string, object> param = new Dictionary<string, object>();
            param.Add("@situacao", situacao);
            param.Add("@datade", datade);
            param.Add("@dataa", dataa);

            List<Tuple<Evento, Pessoa>> eventos = new List<Tuple<Evento, Pessoa>>();
            SQLiteDataReader reader = Database.DoReader(sql + where, param);

            if (reader != null && reader.HasRows)
                while (reader.Read())
                    eventos.Add(BuildwCliente(reader));
            return eventos;
        }
    }
}
