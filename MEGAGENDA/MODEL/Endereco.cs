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
    public class Endereco
    {
        //Classe simples que trata os endereços dos clientes

        public int id = -1;
        public string rua = "";
        public string numero = "";
        public string complemento = "";
        public string bairro = "";
        public string cidade = "";
        public string estado = "";

        public string manual = "";

        public Endereco(string rua, string numero, string complemento, string bairro, string cidade, string estado, int id = -1)
        {
            this.id = id;
            this.rua = rua;
            this.numero = numero;
            this.complemento = complemento;
            this.bairro = bairro;
            this.cidade = cidade;
            this.estado = estado;

            this.Padronizar();
        }
        public Endereco(string rua, string numero, string complemento, string bairro, string cidade, string estado, string manual, int id = -1)
        {
            this.id = id;
            this.rua = rua;
            this.numero = numero;
            this.complemento = complemento;
            this.bairro = bairro;
            this.cidade = cidade;
            this.estado = estado;
            this.manual = manual;

            this.Padronizar();
        }

        public Endereco(string endereco)
        {
            rua = endereco;
            manual = endereco;
        }

        public Endereco(int id)
        {
            this.id = id;
        }

        public void Padronizar()
        {
            //Deixar Rua, Bairro, Cidade e Estado com primeira letra maiúscula
            

            if (estado.Length == 2)
            {
                estado = estado.ToUpper();
            }

        }

        public void EnderecoManual(string endereco)
        {
            manual = endereco;
        }

        public void DesfazerManual()
        {
            manual = "";
        }

        public string ToTexto()
        {
            if (manual.Length > 0)
                return manual;

            string resultado = rua;

            if (numero.Length > 0)
                resultado += ", " + numero;

            if (complemento.Length > 0)
                resultado += ", " + complemento;

            resultado += " - " + bairro + ", " + cidade + "/" + estado;

            return resultado;
        }



        public static Endereco Build(SQLiteDataReader reader)
        {
            if (reader != null && reader.HasRows)
                return new Endereco(
                    Database.ObjToString(reader["Rua"]),
                    Database.ObjToString(reader["Numero"]),
                    Database.ObjToString(reader["Comp"]),
                    Database.ObjToString(reader["Bairro"]),
                    Database.ObjToString(reader["Cidade"]),
                    Database.ObjToString(reader["Estado"]),
                    Database.ObjToString(reader["Manual"]),
                    Database.ObjToInt(reader["Endereco_ID"]));
            return null;
        }

        public static Endereco Get(int id)
        {
            string sql = "SELECT * FROM Endereco WHERE Endereco_ID = " + id;
            
            return Build(Database.DoReader(sql));
        }

        public static int GetID(Endereco end)
        {
            string sql = "SELECT Endereco_ID FROM Endereco WHERE ";
            sql += $"Estado = @estado AND Cidade = @cidade AND Bairro = @bairro AND Rua = @rua AND Comp = @comp AND Numero = @numero";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@estado", end.estado);
            parameters.Add("@cidade", end.cidade);
            parameters.Add("@bairro", end.bairro);
            parameters.Add("@rua", end.rua);
            parameters.Add("@comp", end.complemento);
            parameters.Add("@numero", end.numero);

            SQLiteDataReader reader = Database.DoReader(sql, parameters);
            if (reader != null && reader.HasRows)
                return Database.ObjToInt(reader["Endereco_ID"]);
            return -404;
        }

        // Checa se existe, retornando o ID
        // Caso não, adiciona e retorna o ID
        public static int Add(Endereco end)
        {
            int id_existente = GetID(end);
            if (id_existente > 0)
            {
                Debug.Log("ENDERECO JÁ EXISTENTE: " + id_existente.ToString());
                return id_existente;
            }

            string sql = "INSERT INTO Endereco (Estado, Cidade, Bairro, Rua, Comp, Numero, Manual) ";
            sql += $"VALUES (@estado, @cidade, @bairro, @rua, @comp, @numero, @manual)";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@estado", end.estado);
            parameters.Add("@cidade", end.cidade);
            parameters.Add("@bairro", end.bairro);
            parameters.Add("@rua", end.rua);
            parameters.Add("@comp", end.complemento);
            parameters.Add("@numero", end.numero);
            parameters.Add("@manual", end.manual);

            int id = Database.DoScalar(sql, parameters);
            Debug.Log("ENDERECO ADICIONADO: " + id.ToString());
            return id;
        }

        public static int Edit(Endereco end)
        {
            if (end.id <= 0)
                return Add(end);

            string sql = "UPDATE Endereco SET ";
            sql += $"Estado = @estado, Cidade = @cidade, Bairro = @bairro, Rua = @rua, Comp = @comp, Numero = @numero ";
            sql += $"WHERE Endereco_ID = @id";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@estado", end.estado);
            parameters.Add("@cidade", end.cidade);
            parameters.Add("@bairro", end.bairro);
            parameters.Add("@rua", end.rua);
            parameters.Add("@comp", end.complemento);
            parameters.Add("@numero", end.numero);
            parameters.Add("@manual", end.manual);
            parameters.Add("@id", end.id);

            int result = Database.DoNonQuery(sql, parameters, -403);
            if (result == -403)
                Debug.Log("ENDEREÇO NÃO FOI EDITADO");
            else
                Debug.Log("ENDEREÇO FOI EDITADO");
            return result;
        }
    }
}
