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
    public class Pessoa
    {
        //Classe que possui os dados do cliente, como também uma lista com os IDs de todos Eventos relacionados a ele
        //É possível adicionar também informações de contas bancárias, servindo para o contratado

        public int ID = 0;
        public string nome;
        public bool isJuridica = false;

        public string tipo = "CLIENTE";

        public string rg;
        public string cpf;
        public string genero;

        public string cnpj;
        public string representante;

        public string telefone;
        public string celular;
        public string email;
        public string facebook;

        public string anotacoes;

        public Endereco endereco;

        public DateTime maisRecente = DateTime.MinValue;


        //Cliente Pessoa Física
        public Pessoa(string nome, string rg, string cpf, string genero, string telefone, string celular, string email, string facebook, Endereco endereco, string anotacoes, int id = -1)
        {
            isJuridica = false;

            this.ID = id;
            this.nome = nome;
            this.rg = rg;
            this.cpf = cpf;
            this.genero = genero;
            this.telefone = telefone;
            this.email = email;
            this.celular = celular;
            this.email = email;
            this.facebook = facebook;
            this.endereco = endereco;
            this.anotacoes = anotacoes;
        }

        //Cliente Pessoa Jurídica
        public Pessoa(bool juridica, string nome, string cnpj, string representante, string genero, string telefone, string celular, string email, string facebook, Endereco endereco, string anotacoes, int id = -1)
        {
            isJuridica = true;

            this.ID = id;
            this.nome = nome;
            this.cnpj = cnpj;
            this.representante = representante;
            this.genero = genero;
            this.telefone = telefone;
            this.celular = celular;
            this.email = email;
            this.facebook = facebook;
            this.endereco = endereco;
            this.anotacoes = anotacoes;
        }

        //Cliente completo
        public Pessoa(int id, Boolean juridica, string nome, string rg, string cpfcnpj, string representante, string genero, string telefone, string celular, string email, string facebook, Endereco endereco, string anotacoes)
        {
            this.ID = id;
            this.isJuridica = juridica;
            this.nome = nome;
            this.rg = rg;
            this.representante = representante;
            this.genero = genero;
            this.telefone = telefone;
            this.celular = celular;
            this.email = email;
            this.facebook = facebook;
            this.endereco = endereco;
            this.anotacoes = anotacoes;

            if (juridica)
                this.cnpj = cpfcnpj;
            else
                this.cpf = cpfcnpj;
        }

        public string cpfcnpj()
        {
            if (isJuridica)
                return cnpj;
            return cpf;
        }


        public static Pessoa Build(SQLiteDataReader reader)
        {
            Pessoa cliente = null;
            if (reader != null && reader.HasRows)
            {
                cliente = new Pessoa(
                       Database.ObjToInt(reader["Pessoa_ID"]),
                       bool.Parse(reader["isJuridica"].ToString()),
                       Database.ObjToString(reader["Nome"]),
                       Database.ObjToString(reader["RG"]),
                       Database.ObjToString(reader["CPFCNPJ"]),
                       Database.ObjToString(reader["Representante"]),
                       Database.ObjToString(reader["Genero"]),
                       Database.ObjToString(reader["Telefone"]),
                       Database.ObjToString(reader["Celular"]),
                       Database.ObjToString(reader["Email"]),
                       Database.ObjToString(reader["Facebook"]),
                       Endereco.Get(Database.ObjToInt(reader["Endereco_FK"])),
                       Database.ObjToString(reader["Anotacoes"]));
                if (Database.ObjToString(reader["Tipo"]) != "CLIENTE")
                    cliente.tipo = Database.ObjToString(reader["Tipo"]);
            }
            return cliente;
        }
        public static Pessoa BuildwEndereco(SQLiteDataReader reader)
        {
            Pessoa cliente = null;
            if (reader != null && reader.HasRows)
            {
                cliente = new Pessoa(
                    Database.ObjToInt(reader["Pessoa_ID"]),
                    bool.Parse(reader["isJuridica"].ToString()),
                    Database.ObjToString(reader["Nome"]),
                    Database.ObjToString(reader["RG"]),
                    Database.ObjToString(reader["CPFCNPJ"]),
                    Database.ObjToString(reader["Representante"]),
                    Database.ObjToString(reader["Genero"]),
                    Database.ObjToString(reader["Telefone"]),
                    Database.ObjToString(reader["Celular"]),
                    Database.ObjToString(reader["Email"]),
                    Database.ObjToString(reader["Facebook"]),
                    Endereco.Build(reader),
                    Database.ObjToString(reader["Anotacoes"]));
                if (Database.ObjToString(reader["Tipo"]) != "CLIENTE")
                    cliente.tipo = Database.ObjToString(reader["Tipo"]);
            }
            return cliente;
        }

        public static Pessoa Get(int id, bool notcliente = true)
        {
            string sql = "SELECT * FROM Pessoa WHERE Pessoa_ID = @id ";
            if (notcliente)
                sql += " AND Tipo = 'CLIENTE'";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@id", id);

            Pessoa cliente = null;
            SQLiteDataReader reader = Database.DoReader(sql, parameters);
            cliente = Build(reader);
            return cliente;
        }
        public static Pessoa GetwEndereco(int id, bool notcliente = true)
        {
            string sql = "SELECT * FROM Pessoa JOIN Endereco ON Endereco_FK = Endereco_ID WHERE Pessoa_ID = @id ";
            if (notcliente)
                sql += " AND Tipo = 'CLIENTE'";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@id", id);

            Pessoa cliente = null;
            SQLiteDataReader reader = Database.DoReader(sql, parameters);
            cliente = BuildwEndereco(reader);
            return cliente;
        }

        public static Pessoa Get(string CPFCNPJ, bool notcliente = true)
        {
            string sql = $"SELECT * FROM Pessoa WHERE CPFCNPJ = @cpfcnpj ";
            if (notcliente)
                sql += " AND Tipo = 'CLIENTE'";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@cpfcnpj", CPFCNPJ);

            Pessoa cliente = null;
            SQLiteDataReader reader = Database.DoReader(sql, parameters);
            cliente = Build(reader);
            return cliente;
        }

        public static int Add(Pessoa clt, bool notcliente = true)
        {
            // Faz insert no Endereço caso não exista
            // Retorna erro do Endereço se precisar
            if (clt.endereco == null)
                return Erro.DADOS_INVALIDOS;
            if (clt.endereco.id < 1)
                clt.endereco.id = Endereco.Add(clt.endereco);
            if (clt.endereco.id < 1)
                return clt.endereco.id;

            Pessoa cliente_existente = Get(clt.cpfcnpj(), notcliente);
            if (cliente_existente != null)
            {
                Debug.Log($"CLIENTE JÁ EXISTENTE: {cliente_existente.ID}");
                return cliente_existente.ID;
            }

            string sql = "INSERT INTO Pessoa (Endereco_FK, Nome, isJuridica, Tipo, RG, CPFCNPJ, Representante, Genero, Telefone, Celular, Email, Facebook, Anotacoes)";
            sql += $"VALUES (@endereco, @nome, @juridica, @tipo, @rg, @cpfcnpj, @repr, @genero, @telefone, @celular, @email, @facebook, @anotacoes)";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@endereco", clt.endereco.id);
            parameters.Add("@nome", clt.nome);
            parameters.Add("@juridica", clt.isJuridica);
            parameters.Add("@tipo", clt.tipo);
            parameters.Add("@rg", clt.rg);
            parameters.Add("@cpfcnpj", clt.cpfcnpj());
            parameters.Add("@repr", clt.representante);
            parameters.Add("@genero", clt.genero);
            parameters.Add("@telefone", clt.telefone);
            parameters.Add("@celular", clt.celular);
            parameters.Add("@email", clt.email);
            parameters.Add("@facebook", clt.facebook);
            parameters.Add("@anotacoes", clt.anotacoes);

            int result = Database.DoScalar(sql, parameters);
            if (result < 1)
                Debug.Log($"CLIENTE NÃO ADICIONADO <{result}>");
            else
                Debug.Log($"CLIENTE ADICIONADO: {result}");
            return result;
        }

        public static int Edit(Pessoa clt)
        {
            string sql = "UPDATE Pessoa SET ";
            sql += $"Endereco_FK = @endereco, Nome = @nome, isJuridica = @juridica, RG = @rg, CPFCNPJ = @cpfcnpj, Representante = @repr, Genero = @genero, Telefone = @telefone, Celular = @celular, Email = @email, Facebook = @facebook, Anotacoes = @anotacoes ";
            sql += $"WHERE Pessoa_ID = @id";

            int result = Endereco.Edit(clt.endereco);
            if (result > 0)
                clt.endereco.id = result;

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@endereco", clt.endereco.id);
            parameters.Add("@nome", clt.nome);
            parameters.Add("@juridica", clt.isJuridica);
            parameters.Add("@rg", clt.rg);
            parameters.Add("@cpfcnpj", clt.cpfcnpj());
            parameters.Add("@repr", clt.representante);
            parameters.Add("@genero", clt.genero);
            parameters.Add("@telefone", clt.telefone);
            parameters.Add("@celular", clt.celular);
            parameters.Add("@email", clt.email);
            parameters.Add("@facebook", clt.facebook);
            parameters.Add("@anotacoes", clt.anotacoes);
            parameters.Add("@id", clt.ID);

            result = Database.DoNonQuery(sql, parameters, Erro.PESSOA_NAO_EDITADA);
            if (result == Erro.PESSOA_NAO_EDITADA)
                Debug.Log("CLIENTE NÃO EDITADO");
            else
                Debug.Log("CLIENTE EDITADO");
            return result;
        }

        public static int Delete(int id)
        {
            //Evento.DeleteCliente(id);
            string sql = $"DELETE FROM Pessoa WHERE Pessoa_ID = @id";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@id", id);

            int result = Database.DoNonQuery(sql, parameters, Erro.PESSOA_NAO_DELETADA);
            if (result == Erro.PESSOA_NAO_DELETADA)
                Debug.Log("CLIENTE NÃO DELETADO");
            else
                Debug.Log("CLIENTE DELETADO");
            return result;
        }




        public static DataTable TableCliente(string conditions, Dictionary<string, object> parameters = null)
        {
            string subquery = " (SELECT Evento_ID FROM Evento WHERE Pessoa_FK = Pessoa.Pessoa_ID ORDER BY ROWID DESC LIMIT 1) 'Último Evento' ";
            string query = $" SELECT Pessoa_ID as ID, Nome, CPFCNPJ as 'CPF/CNPJ', {subquery} FROM Pessoa ";
            string where = $" WHERE Tipo = 'CLIENTE' {conditions}";
            string order = " ORDER BY ROWID DESC";

            return Database.SelectQuery(query + where + order, parameters);
        }
    }
}
