using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEGAGENDA.MODEL
{
    public static class Erro
    {
        public static readonly int SEM_ALTERACOES =              0;
        public static readonly int SEM_RESULTADO =               -1;
        public static readonly int VAZIO =                       -404;
        public static readonly int ERRO_INT =                    -2;
        public static readonly int ERRO_DOUBLE =                 -3;
        public static readonly int ERRO_SCALAR =                 -21;
        public static readonly int ERRO_NONQUERY =               -101;
        public static readonly int DADOS_INVALIDOS =             -111;
        public static readonly int PESSOA_NAO_EDITADA =         -203;
        public static readonly int PESSOA_NAO_DELETADA =        -206;
        public static readonly int EVENTO_NAO_EDITADO =          -304;
        public static readonly int EVENTO_NAO_DELETADO =         -306;
        public static readonly int ENDERECO_NAO_EDITADO =        -403;
        public static readonly int MODELO_NAO_EDITADO =          -604;
        public static readonly int MODELO_NAO_DELETADO =         -606;
        public static readonly int CABINE_NAO_DELETADA =         -706;
        public static readonly int FUNCIONARIO_NAO_EDITADO =     -803;
        public static readonly int FUNCIONARIO_NAO_DELETADO =    -806;

        public static Dictionary<int, string> MENSAGENS = new Dictionary<int, string>() {
                { SEM_ALTERACOES,             "Nenhuma alteração realizada" },
                { SEM_RESULTADO,              "Nenhum resultado" },
                { VAZIO,                      "Vazio" },
                { ERRO_INT,                   "Problema na conversão int" },
                { ERRO_DOUBLE,                "Problema na conversão double" },
                { ERRO_SCALAR,                "Problema na operação Scalar no Database" },
                { ERRO_NONQUERY,              "Problema na operação NonQuery no Database" },
                { DADOS_INVALIDOS,            "Dados inválidos" },
                { PESSOA_NAO_EDITADA,         "Cliente não foi editado" },
                { PESSOA_NAO_DELETADA,        "Cliente não foi deletado" },
                { EVENTO_NAO_EDITADO,         "Evento não foi editado" },
                { EVENTO_NAO_DELETADO,        "Evento não foi deletado" },
                { ENDERECO_NAO_EDITADO,       "Endereço não foi editado" },
                { MODELO_NAO_EDITADO,         "Modelo não foi editado" },
                { MODELO_NAO_DELETADO,        "Modelo não foi deletado" },
                { CABINE_NAO_DELETADA,        "Cabine não foi deletada" },
                { FUNCIONARIO_NAO_EDITADO,    "Funcionário não foi editado" },
                { FUNCIONARIO_NAO_DELETADO,   "Funcionário não foi deletado" }
            };

        public static void Mensagem (int code, bool sucesso = true, string msg = "ID: ")
        {
            if (code > 0)
            {
                if (sucesso)
                {
                    if (msg == "")
                        MessageBox.Show("Sucesso!");
                    else
                        MessageBox.Show("Sucesso! " + msg + code.ToString());
                }                    
            }
            else
            {
                string result = code.ToString();
                MENSAGENS.TryGetValue(code, out result);
                MessageBox.Show("Erro: " + result);
            }
        }
    }
}
