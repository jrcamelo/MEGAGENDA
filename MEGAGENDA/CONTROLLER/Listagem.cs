using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MEGAGENDA.VIEW;

namespace MEGAGENDA.CONTROLLER
{
    public static class Listagem
    {
        public static DataTable TableCliente(string where, Dictionary<string, object> parameters = null)
        {
            string subquery = "(SELECT Evento_ID FROM Evento WHERE Pessoa_FK = Pessoa.Pessoa_ID ORDER BY ROWID DESC LIMIT 1) 'Último Evento'";
            string query = $"SELECT Pessoa_ID as ID, Nome, CPFCNPJ as 'CPF/CNPJ', {subquery} FROM Pessoa";
            string order = " ORDER BY ROWID DESC";

            return Database.SelectQuery(query + where + order, parameters);
        }

        public static Dictionary<string, object> FazerParamsCliente(decimal idCliente, string clientePesquisa)
        {
            Dictionary<string, object> param = new Dictionary<string, object>();
            param.Add("@id", idCliente);
            param.Add("@nome", clientePesquisa);
            param.Add("@cpfcnpj", clientePesquisa);
            param.Add("@anotacoes", clientePesquisa);
            return param;
        }

        public static string FazerWhereCliente(string tipoPesquisa = "")
        {
            switch (tipoPesquisa)
            {
                case "ID":
                    return " WHERE Pessoa_ID = @id";
                case "Nome":
                    return " WHERE Nome = @nome OR Representante = @nome";
                case "CPF/CNPJ":
                    return " WHERE CPFCNPJ LIKE '%'||@cpfcnpj||'%'";
                case "Anotações":
                    return " WHERE Anotacoes LIKE '%'||@anotacoes||'%'";
                default:
                    break;
            }
            return "";
        }
        public static DataTable TableEvento(string where, Dictionary<string, object> parameters = null)
        {
            string subquery = "(SELECT Vencimento FROM Pagamento WHERE Evento_FK = Evento.Evento_ID AND Pago = 0 ORDER BY ROWID DESC LIMIT 1) 'Prox. Parcela'";
            string query = $"SELECT Evento_ID as ID, Pessoa_FK as Cliente, Tipo, Data, {subquery} FROM Evento";
            string order = " ORDER BY ROWID DESC";

            return Database.SelectQuery(query + where + order, parameters);
        }

        public static Dictionary<string, object> FazerParamsEvento(decimal idEvento, DateTime dataDe, DateTime dataA, string eventoPesquisa)
        {
            Dictionary<string, object> param = new Dictionary<string, object>();
            param.Add("@id", idEvento);
            param.Add("@pid", idEvento);
            param.Add("@datade", dataDe.ToString("yyyy-MM-dd"));
            param.Add("@dataa", dataA.ToString("yyyy-MM-dd"));
            param.Add("@tipo", eventoPesquisa);
            param.Add("@observ", eventoPesquisa);
            return param;
        }

        public static string FazerWhereEvento(string tipoPesquisa)
        {
            switch (tipoPesquisa)
            {
                case "ID":
                    return " WHERE Evento_ID = @id";
                case "Cliente":
                    return " WHERE Pessoa_FK = @pid";
                case "Data":
                    return " WHERE Data BETWEEN @datade AND @dataa";
                case "Tipo":
                    return " WHERE Tipo LIKE '%'||@tipo||'%'";
                case "Observações":
                    return " WHERE Observacoes LIKE '%'||@observ||'%'";
                default:
                    break;
            }
            return "";
        }
    }
}
