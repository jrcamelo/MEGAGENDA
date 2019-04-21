using MEGAGENDA.CONTROLLER;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEGAGENDA.MODEL
{   
    public class Cabine
    {
        public string nome { get; set; }

        public Cabine(string nome)
        {
            this.nome = nome;
        }





        public static Cabine Build(SQLiteDataReader reader)
        {
            if (reader != null && reader.HasRows)
                return new Cabine(
                    Database.ObjToString(reader["Cabine_Nome"]));
            return null;
        }

        public static Cabine GetCabine(string nome)
        {
            string sql = $"SELECT * FROM Cabine WHERE Cabine_Nome = @nome";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@nome", nome);

            SQLiteDataReader reader = Database.DoReader(sql, parameters);
            return Build(reader);
        }

        public static List<string> GetAll()
        {
            List<string> cabines = new List<string>();
            string sql = $"SELECT Cabine_Nome FROM Cabine";

            SQLiteDataReader reader = Database.DoReader(sql);
            if (reader != null && reader.HasRows)
                while (reader.Read())
                    cabines.Add(Database.ObjToString(reader["Cabine_Nome"]));
            return cabines;
        }

        public static int Add(Cabine cabine)
        {
            Cabine existente = GetCabine(cabine.nome);
            if (existente != null)
            {
                Debug.Log("CABINE EXISTENTE: " + cabine.nome);
                return Erro.SEM_ALTERACOES;
            }

            string sql = "INSERT INTO Cabine (Cabine_Nome) ";
            sql += $"VALUES (@nome)";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@nome", cabine.nome);

            int result = Database.DoScalar(sql, parameters);
            if (result > 0)
                Debug.Log("CABINE ADICIONADA: " + cabine.nome);
            else
                Debug.Log("CABINE NÃO ADICIONADA: " + cabine.nome);
            return result;
        }

        public static int Delete(string nome)
        {
            string sql = $"DELETE FROM Cabine WHERE Cabine_Nome = @nome";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@nome", nome);

            return Database.DoNonQuery(sql, parameters, Erro.CABINE_NAO_DELETADA);
        }
    }
}
