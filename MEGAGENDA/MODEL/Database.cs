using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

using MEGAGENDA.MODEL;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace MEGAGENDA.CONTROLLER
{
    public static class Database
    {
        //Classe principal que lê e mantém as informações dos clientes, eventos e pagamentos
        
        public static Dictionary<string, Modelo> Modelos = new Dictionary<string, Modelo>();
        
        public static Dictionary<string, Funcionario> Funcionarios = new Dictionary<string, Funcionario>() { { "Dono", new Funcionario("Dono", "Nido") } };

        public static Dictionary<string, Cabine> Cabines = new Dictionary<string, Cabine>() { { "Cabine 1", new Cabine("Cabine 1") } };

        private static SQLiteConnection Lite;

        private static string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), @"MEGAGENDA\");
        private static string dbname = "Database.db";

        public static void Start()
        {
            Directory.CreateDirectory(path);
            Directory.CreateDirectory(path + @"\Modelos");
            Directory.CreateDirectory(path + @"\Eventos");
            Directory.CreateDirectory(path + @"\Contratos");
            
            Lite = Connect();
            Debug.Log("DATABASE CARREGADO EM " + path + dbname);

            try
            {
                CreateDatabase();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static SQLiteConnection Connect()
        {
            if (Lite != null && Lite.State == ConnectionState.Open)
                Lite.Close();

            SQLiteConnectionStringBuilder connectString = new SQLiteConnectionStringBuilder();
            connectString.DataSource = path + dbname;
            connectString.ForeignKeys = true;
            connectString.JournalMode = SQLiteJournalModeEnum.Wal;

            Debug.Log(connectString.ToString());
            SQLiteConnection newLite = new SQLiteConnection(connectString.ToString());
            newLite.Open();
            Debug.Log("Reconnect");
            return newLite;
        }

        public static void CreateDatabase()
        {
            List<string> queries = new List<string>()
            {
                @"CREATE TABLE IF NOT EXISTS Endereco (Endereco_ID     INTEGER      PRIMARY KEY AUTOINCREMENT, Estado STRING (2), Cidade VARCHAR (24), Bairro VARCHAR (24), Rua VARCHAR (36), Comp VARCHAR (24), Numero VARCHAR (8), Manual TEXT);",

                @"CREATE TABLE IF NOT EXISTS Pessoa(Pessoa_ID INTEGER  PRIMARY KEY AUTOINCREMENT, Endereco_FK INTEGER  REFERENCES Endereco (Endereco_ID), Nome VARCHAR(64) NOT NULL, isJuridica BOOLEAN DEFAULT(0), RG VARCHAR(24), CPFCNPJ VARCHAR(24), Representante VARCHAR(64), Genero CHAR NOT NULL, Telefone  VARCHAR(36), Celular VARCHAR(36), Email VARCHAR(36), Facebook VARCHAR(36), Anotacoes TEXT);",

                @"CREATE TABLE IF NOT EXISTS Cabine(Cabine_Nome VARCHAR (24) PRIMARY KEY);",

                @"CREATE TABLE IF NOT EXISTS Evento(Evento_ID INTEGER  PRIMARY KEY AUTOINCREMENT, Pessoa_FK INTEGER  NOT NULL REFERENCES Pessoa (Pessoa_ID) ON DELETE CASCADE, Endereco_FK INTEGER  REFERENCES Endereco(Endereco_ID) NOT NULL, Cabine_FK  VARCHAR(24) REFERENCES Cabine(Cabine_Nome), Tipo VARCHAR(32) NOT NULL, Situacao   VARCHAR(16) DEFAULT AGENDADO, Protagonista   VARCHAR(64), Valor DOUBLE   NOT NULL, Entrada DOUBLE, EntradaQuitada BOOLEAN  DEFAULT(0), Data DATE NOT NULL, Duracao INTEGER NOT NULL, horaCabine TIME NOT NULL, horaEvento TIME NOT NULL, Guestbook BOOLEAN  DEFAULT(0), MaterialPronto BOOLEAN  DEFAULT(0), Fornecedores VARCHAR(64), Observacoes TEXT);",

                @"CREATE TABLE IF NOT EXISTS Pagamento(Evento_FK INTEGER REFERENCES Evento (Evento_ID) ON DELETE CASCADE, Parcela INTEGER NOT NULL, Valor DOUBLE  NOT NULL, Vencimento DATE, Pago BOOLEAN DEFAULT (0), PRIMARY KEY(Evento_FK, Parcela));",

                @"CREATE TABLE IF NOT EXISTS Funcionario(Funcionario_Nome VARCHAR (24) PRIMARY KEY);",

                @"CREATE TABLE IF NOT EXISTS Equipe(Evento_FK INTEGER REFERENCES Evento (Evento_ID) ON DELETE CASCADE, Funcionario_FK INTEGER REFERENCES Funcionario(Funcionario_Nome), Data DATE NOT NULL, PRIMARY KEY(Evento_FK, Funcionario_FK));",

                @"CREATE TABLE IF NOT EXISTS Modelo(Modelo_Nome VARCHAR (24) PRIMARY KEY);",

                @"CREATE TABLE IF NOT EXISTS Clausula(Modelo_Nome VARCHAR (24) REFERENCES Modelo(Modelo_Nome) ON DELETE CASCADE, Secao VARCHAR(24) NOT NULL, Numero  INTEGER, Texto TEXT, PRIMARY KEY(Modelo_Nome ASC, Secao, Numero));"
            };

            try
            {
                for (int i = 0; i < queries.Count; i++)
                {
                    SQLiteCommand command = new SQLiteCommand(queries[i], Lite);
                    command.ExecuteNonQuery();
                }
            }
            catch (SQLiteException e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public static DataTable SelectQuery(string sql, Dictionary<string, object> parameters = null)
        {
            if (parameters == null)
                parameters = new Dictionary<string, object>();

            SQLiteDataAdapter adapter;
            DataTable datatable = new DataTable();

            try
            {
                Lite = Connect();

                SQLiteCommand command = new SQLiteCommand(sql, Lite);
                foreach (KeyValuePair<string, object> p in parameters)
                    command.Parameters.AddWithValue(p.Key, p.Value);
                
                if (Debug.ON)
                {
                    string msg = "Getting Table for: " + command.CommandText;
                    msg += "\nWith parameters:";
                    foreach (SQLiteParameter p in command.Parameters)
                        msg += " " + p.Value;
                    Debug.Log(msg);
                }

                adapter = new SQLiteDataAdapter(command);
                adapter.Fill(datatable); //fill the datasource
            }
            catch (SQLiteException ex)
            {
                //Add your exception code here.
                MessageBox.Show(ex.Message);
            }
            return datatable;
        }

        public static int DoScalar(string sql, Dictionary<string, object> parameters = null)
        {
            if (DoNonQuery(sql, parameters) == -101)
                return -101;
            
            try
            {
                Lite = Connect();

                Debug.Log("Getting last row");
                sql = "SELECT last_insert_rowid()";
                SQLiteCommand command = new SQLiteCommand(sql, Lite);

                object result = command.ExecuteScalar();
                if (result != null)
                    return ObjToInt(result);
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message);
            }

            return -21;
        }

        public static SQLiteDataReader DoReader(string sql, Dictionary<string, object> parameters = null)
        {
            if (parameters == null)
                parameters = new Dictionary<string, object>();

            
            try
            {
                SQLiteCommand command = new SQLiteCommand(sql, Lite);
                foreach (KeyValuePair<string, object> p in parameters)
                    command.Parameters.AddWithValue(p.Key, p.Value);

                Debug.Log("Getting reader for: " + command.CommandText);
                SQLiteDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                    return reader;
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public static int DoNonQuery(string sql, Dictionary<string, object> parameters = null, int code = -101)
        {
            if (parameters == null)
                parameters = new Dictionary<string, object>();

            if (code > 0)
                code = code * -1;

            try
            {
                Lite = Connect();

                SQLiteCommand command = new SQLiteCommand(sql, Lite);
                foreach (KeyValuePair<string, object> p in parameters)
                    command.Parameters.AddWithValue(p.Key, p.Value);

                if (Debug.ON)
                {
                    string msg = "Getting changed entries for: " + command.CommandText;
                    msg += "\nWith parameters:";
                    foreach (SQLiteParameter p in command.Parameters)
                        msg += " " + p.Value;
                    Debug.Log(msg);
                }

                int result = command.ExecuteNonQuery();
                if (result == 0)
                    return code;
                return result;
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Lite.Close();
            }
            return code;
        }
                
        
        #region Equipe
        public static List<Funcionario> GetEquipe(int evento)
        {
            List<Funcionario> funcs = new List<Funcionario>();

            return funcs;
        }
        public static string GetEquipeString(int evento)
        {




            return "";
        }

        public static int AddEquipe(string equipe)
        {

            return 0;
        }

        public static int DeleteEquipeEvento(int EID)
        {

            return 0;
        }

        public static Funcionario GetFuncionario(string nome)
        {
            Funcionario func = null;

            return func;
        }

        public static int AddFuncionario(Funcionario func)
        {

            return 0;
        }

        public static List<Funcionario> GetAllFuncionarios()
        {
            List<Funcionario> funcs = new List<Funcionario>();

            return funcs;
        }

        #endregion

        public static Modelo GetModelo(string nome)
        {
            Modelo modelo = new Modelo();
            Database.Modelos.TryGetValue(nome, out modelo);
            if (modelo != null)
            {
                return ObjectExtension.CopyObject<Modelo>(modelo);
            }
            return null;
        }

        public static string AddModelo(Modelo modelo)
        {
            if (GetModelo(modelo.Nome) == null)
            {
                Database.Modelos[modelo.Nome] = ObjectExtension.CopyObject<Modelo>(modelo);
                return "";
            }
            else
            {
                return "Nome de modelo já existente";
            }
        }

        public static string EditModelo(Modelo modelo)
        {
            string erroNaoFatal = "";
            if (!Database.Modelos.ContainsKey(modelo.Nome))
            {
                return AddModelo(modelo);
            }

            Database.Modelos[modelo.Nome] = ObjectExtension.CopyObject<Modelo>(modelo);
            return erroNaoFatal;
        }

        public static List<string> GetListaModelos()
        {
            return Database.Modelos.Keys.ToList<string>();
        }



        public static int ObjToInt(object obj)
        {
            int result = -2;
            int.TryParse(obj.ToString(), out result);
            return result;
        }
        public static double ObjToDouble(object obj)
        {
            double result = -3;
            double.TryParse(obj.ToString(), out result);
            return result;
        }
        public static DateTime ObjToDate(object obj)
        {
            DateTime result;
            DateTime.TryParse(obj.ToString(), out result);
            if (result != null)
                return result.Date;
            return result;
        }
        public static DateTime ObjToTime(object obj)
        {
            DateTime result;
            DateTime.TryParse(obj.ToString(), out result);
            if (result != null)
                return result;
            return DateTime.MinValue;
        }
        public static string ObjToString(object obj)
        {
            string result = null;
            if (obj != null)
                result = obj.ToString();
            return result;
        }

        public static string BoolBin(bool b)
        {
            if (b)
                return "1";
            return "0";
        }
        public static bool BinBool(string b)
        {
            if (b == "1")
                return true;
            return false;
        }

    }
}
