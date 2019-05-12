using Spire.Doc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MEGAGENDA.MODEL;

namespace MEGAGENDA.CONTROLLER
{
    public class Editor
    {
        public static int MAXCLAUSULAS = Modelo.MAXCLAUSULAS;

        public static Dictionary<string, string> Keywords = new Dictionary<string, string>
        {

        };

        public static Dictionary<string, string> Preparar_Keywords(Pessoa cliente = null, Evento evento = null)
        {
            if (cliente == null || evento == null)
            {
                Endereco e = new Endereco("", "", "", "", "", "");
                cliente = new Pessoa(0, false, "", "", "", "", "M", "", "", "", "", e, "");
                evento = new Evento(0, "", "", 0, new List<string>(), e, DateTime.Today, DateTime.Today, DateTime.Today, 0, false, false, 0, "", new List<Pagamento>());
            }

            return new Dictionary<string, string>
            {
                {"[EMPRESA NOME]", Configs.Empresa.nome},
                {"[EMPRESA CNPJ]", Configs.Empresa.cpfcnpj()},
                {"[EMPRESA ENDERECO]", Configs.Empresa.endereco.manual},
                {"[EMPRESA CUSTO_HORA_EXTRA]", Configs.Empresa_Hora_Extra},
                {"[EMPRESA REPRESENTANTE_ENDERECO]", Configs.Empresa.endereco.manual},
                {"[EMPRESA REPRESENTANTE_CPF]", Configs.Empresa.anotacoes},
                {"[EMPRESA REPRESENTANTE_RG]", Configs.Empresa.rg},
                {"[EMPRESA TELEFONE]", Configs.Empresa.telefone},
                {"[EMPRESA CELULAR]", Configs.Empresa.celular},
                {"[EMPRESA EMAIL]", Configs.Empresa.email},
                {"[EMPRESA FACEBOOK]", Configs.Empresa.facebook},

                {"[CONTRATANTE NOME]", cliente.nome},
                {"[CONTRATANTE ENDERECO]", cliente.endereco.ToTexto()},
                {"[CONTRATANTE RG]", cliente.rg},
                {"[CONTRATANTE CPF]", cliente.cpf},
                {"[CONTRATANTE TELEFONE]", cliente.telefone},
                {"[CONTRATANTE EMAIL]", cliente.email},

                {"[EVENTO ID]", evento.ID.ToString()},
                {"[EVENTO TIPO]", evento.tipo},
                {"[EVENTO ENDERECO]", evento.local.ToTexto()},
                {"[EVENTO VALOR]", Conversor.EscreverExtenso((decimal) evento.valor)},
                {"[EVENTO VALOR_ENTRADA]", Conversor.EscreverExtenso((decimal) evento.getEntrada())},
                {"[EVENTO DATA_LIMITE_PAGAMENTO]", DateTime.Today.AddDays(3).ToShortDateString()},
                {"[EVENTO DATA]", evento.data.ToShortDateString()},
                {"[EVENTO HORA_INICIO]", evento.horaEvento.ToShortTimeString()},
                {"[EVENTO HORA_CABINE]", evento.horaCabine.ToShortTimeString()},
                {"[EVENTO DURACAO_HORAS]", evento.duracao.ToString() + " hora(s)"},

                {"[CONTRATO DATA]", DateTime.Today.ToShortDateString()}
            };
        }

        public static void Fazer_Contrato(string arquivo_nome, Modelo modelo, Pessoa cliente, Evento evento)
        {
            Document doc = new Document();
            
            doc.LoadFromFile(Configs.MODELO_PATH + arquivo_nome + ".docx", FileFormat.Docx);

            Editor.resetar_Count();

            foreach (string secao in modelo.Clausulas.Keys)
            {
                Debug.Log(secao);
                doc = Editor.substituir_Secao(secao, modelo.Clausulas[secao], doc);
            }

            foreach (KeyValuePair<string, string> words in Editor.Preparar_Keywords(cliente, evento))
            {
                doc.Replace(words.Key, words.Value, false, true);
            }

            doc.SaveToFile(Configs.CONTRATO_PATH + $"Contrato N{evento.ID} - {cliente.nome}.docx", FileFormat.Docx);
            System.Diagnostics.Process.Start(Configs.CONTRATO_PATH + $"Contrato N{evento.ID} - {cliente.nome}.docx");
        }

        public static int count = 1;
        public static void resetar_Count()
        {
            count = 1;
        }

        public static Document substituir_Secao(string secao, List<string> clausulas, Document doc)
        {
            for (int i = 0; i < MAXCLAUSULAS; i++)
            {
                string texto = clausulas[i];

                int cl = i + 1;
                if (texto != null && texto != "" && texto.Trim().Length > 1)
                {
                    doc.Replace("[CLAUSULA " + secao + cl.ToString() + "]", "\nCLÁUSULA " + count.ToString() + " -", false, true);
                    doc.Replace("[CLAUSULA " + secao + cl.ToString() + " TEXTO]", texto + "\n", false, true);
                    count++;
                }
                else
                {
                    doc.Replace("[CLAUSULA " + secao + cl.ToString() + "]", "", false, true);
                    doc.Replace("[CLAUSULA " + secao + cl.ToString() + " TEXTO]", "", false, true);
                }
            }
            return doc;
        }

        public static string Substituir_Clausula(string clausula, Pessoa cliente, Evento evento)
        {
            foreach (KeyValuePair<string, string> words in Editor.Preparar_Keywords(cliente, evento))
            {
                clausula = clausula.Replace(words.Key, words.Value);
            }
            return clausula;
        }
    }
}
