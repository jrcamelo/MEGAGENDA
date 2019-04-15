using MEGAGENDA.CONTROLLER;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEGAGENDA.MODEL
{
    public class Funcionario
    {
        public int ID = 0;
        public int PID = 0;
        public string identificador;
        public Pessoa pessoa;

        public Funcionario(string identificador, Pessoa pessoa)
        {
            this.identificador = identificador;
            this.pessoa = pessoa;
        }

        public Funcionario(int pid, string identificador, int id = -1, Pessoa pessoa = null)
        {

            this.ID = id;
            this.PID = pid;
            this.identificador = identificador;
            this.pessoa = pessoa;
        }







        public static Funcionario Build(SQLiteDataReader reader)
        {
            Funcionario func = null;
            if (reader != null && reader.HasRows)
                func = new Funcionario(
                    Database.ObjToInt(reader["Pessoa_FK"]),
                    Database.ObjToString(reader["Identificador"]),
                    Database.ObjToInt(reader["Funcionario_ID"]),
                    Pessoa.Get(Database.ObjToInt(reader["Pessoa_FK"]), false));
            return func;
        }

        public static Funcionario Get(int id)
        {
            string sql = "SELECT * FROM Funcionario WHERE Funcionario_ID = @id";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@id", id);

            Funcionario func = null;
            SQLiteDataReader reader = Database.DoReader(sql, parameters);
            func = Build(reader);
            return func;
        }

        public static Funcionario Get(string identificador)
        {
            string sql = "SELECT * FROM Funcionario WHERE Identificador = @ident";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@ident", identificador);

            Funcionario func = null;
            SQLiteDataReader reader = Database.DoReader(sql, parameters);
            func = Build(reader);
            return func;
        }
        public static Funcionario GetbyPID(int pid)
        {
            string sql = "SELECT * FROM Funcionario WHERE Pessoa_FK = @pid";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@pid", pid);

            Funcionario func = null;
            SQLiteDataReader reader = Database.DoReader(sql, parameters);
            func = Build(reader);
            return func;
        }

        public static int GetID(string identificador)
        {
            string sql = "SELECT Funcionario_ID FROM Funcionario WHERE Identificador = @ident";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@ident", identificador);

            SQLiteDataReader reader = Database.DoReader(sql, parameters);
            if (reader != null && reader.HasRows)
                return Database.ObjToInt(reader["Funcionario_ID"]);
            return -1;
        }

        public static string GetIdent(int id)
        {
            string sql = "SELECT Identificador FROM Funcionario WHERE Funcionario_ID = @id";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@id", id);

            SQLiteDataReader reader = Database.DoReader(sql, parameters);
            if (reader != null && reader.HasRows)
                return Database.ObjToString(reader["Identificador"]);
            return "";
        }

        public static List<string> GetAllIdentificadores()
        {
            string sql = "SELECT Identificador FROM Funcionario";

            List<string> result = new List<string>();
            SQLiteDataReader reader = Database.DoReader(sql);

            if (reader != null && reader.HasRows)
                while (reader.Read())
                    result.Add(Database.ObjToString(reader["Identificador"]));
            return result;
        }

        public static int Add(Funcionario func)
        {
            Funcionario func_existente = Get(func.identificador);
            if (func_existente != null)
            {
                Debug.Log($"FUNCIONÁRIO JÁ EXISTENTE: {func_existente.ID}");
                return func_existente.ID;
            }

            func.pessoa.tipo = "FUNCIONARIO";
            int pid = Pessoa.Add(func.pessoa, false);
            if (pid <= 0)
                return pid;

            func.PID = pid;

            string sql = "INSERT INTO Funcionario (Identificador, Pessoa_FK)";
            sql += $"VALUES (@identificador, @pessoa)";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@identificador", func.identificador);
            parameters.Add("@pessoa", func.PID);

            int result = Database.DoScalar(sql, parameters);
            if (result < 1)
                Debug.Log($"FUNCIONÁRIO NÃO ADICIONADO <{result}>");
            else
                Debug.Log($"FUNCIONÁRIO ADICIONADO: {result}");
            return result;
        }

        public static int Edit(Funcionario func)
        {
            if (func.ID <= 0)
                return func.ID;

            string sql = "UPDATE Funcionario SET ";
            sql += $"Identificador = @ident ";
            sql += $"WHERE Funcionario_ID = @id";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@ident", func.identificador);
            parameters.Add("@id", func.ID);

            int result = Database.DoNonQuery(sql, parameters, -403);
            if (result == -803)
                Debug.Log("FUNCIONÁRIO NÃO FOI EDITADO");
            else
                Debug.Log("FUNCIONÁRIO FOI EDITADO");
            return result;
        }

        public static int Delete(int id)
        {
            Funcionario func = Get(id);
            if (func == null)
                return -1;

            int result = Pessoa.Delete(func.PID);

            //string sql = $"DELETE FROM Funcionario WHERE Funcionario_ID = @id";

            //Dictionary<string, object> parameters = new Dictionary<string, object>();
            //parameters.Add("@id", id);

            //int result = Database.DoNonQuery(sql, parameters, -206);
            if (result == -206)
                Debug.Log("FUNCIONARIO NÃO DELETADO");
            else
                Debug.Log("FUNCIONARIO DELETADO");
            return result;
        }
        public static int Delete(string identificador)
        {
            Funcionario func = Get(identificador);
            if (func == null)
                return -1;

            int result = Pessoa.Delete(func.PID);
            if (result == -206)
                Debug.Log("FUNCIONARIO NÃO DELETADO");
            else
                Debug.Log("FUNCIONARIO DELETADO");
            return result;
        }
    }
}