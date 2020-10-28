using MEGAGENDA.CONTROLLER;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEGAGENDA.MODEL
{
    class Equipe
    {





        public static List<Funcionario> Get(string funcs)
        {
            List<Funcionario> result = new List<Funcionario>();

            string[] identificadores = funcs.Split('/');
            foreach (string i in identificadores)
                result.Add(Funcionario.Get(i));
            return result;
        }

        public static List<int> GetIDs(List<string> identificadores)
        {
            List<int> result = new List<int>();
            
            foreach (string i in identificadores)
                result.Add(Funcionario.GetID(i));
            return result;
        }

        public static List<string> GetIdents(int eid)
        {
            string sql = "SELECT Identificador FROM Funcionario JOIN Equipe ON Funcionario_ID = Funcionario_FK WHERE Evento_FK = @eid";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@eid", eid);

            SQLiteDataReader reader = Database.DoReader(sql, parameters);

            List<string> result = new List<string>();
            if (reader != null && reader.HasRows)
                while (reader.Read())
                    result.Add(Database.ObjToString(reader["Identificador"]));
            return result;
        }

        public static int Add(List<string> identificadores, int eid)
        {
            // Servindo como um UPDATE
            DeleteEvento(eid);

            if (identificadores.Count < 1)
                return -1;

            int contagem = 0;
            List<int> funcs_id = GetIDs(identificadores);
            foreach (int f in funcs_id)
            {
                if (f < 1) continue;

                string sql = "INSERT INTO Equipe (Evento_FK, Funcionario_FK) ";
                sql += $"VALUES (@eid, @func)";

                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@eid", eid);
                parameters.Add("@func", f);

                contagem += Database.DoNonQuery(sql, parameters, 0);
            }

            Debug.Log($"{contagem} MEMBROS DA EQUIPE ADICIONADOS NO EVENTO {eid}");
            return contagem - funcs_id.Count;
        }

        public static int DeleteEvento(int EID)
        {
            string sql = $"DELETE FROM Equipe WHERE Evento_FK = @eid";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@eid", EID);

            int result = Database.DoScalar(sql, parameters);
            if (result == Erro.ERRO_SCALAR)
                result = 0;
            Debug.Log($"{result} MEMBROS DA EQUIPE DELETADOS NO EVENTO {EID}");
            return result;
        }
    }
}
