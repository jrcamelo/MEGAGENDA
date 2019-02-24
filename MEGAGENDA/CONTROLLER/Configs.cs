using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MEGAGENDA.MODEL;

namespace MEGAGENDA.CONTROLLER
{
    [Serializable]
    public static class Configs
    {
        //Classe com todas as configurações do programa, ou seja, os dados da empresa em questão
        //E também as pessoas físicas que serão usadas nos contratos, cada uma possuindo uma conta bancária



        public static string Empresa_Nome = "Mega Selfie Cabine Fotográfica";
        public static string Empresa_CNPJ = "25.425.706/0001-26";
        public static string Empresa_Endereco = "Rua São Mateus, 1060, Condomínio Jardim Renascença, Bl. D, Apto. 302, Iputinga, Recife/PE";
        public static string Empresa_Representante_RG = "4985734, SSP/PE";
        public static string Empresa_Representante_CPF = "030.099.874-04";
        public static string Empresa_Representante_Endereco = "Rua São Mateus, 1060, Condomínio Jardim Renascença, Bl. D, Apto. 302, Iputinga, Recife/PE";
        public static string Empresa_Hora_Extra = "R$ 450,00 (quatrocentos e cinquenta reais)";

        public static string MODELO_PATH = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), @"MEGAGENDA\Modelos\");
        public static string CONTRATO_PATH = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), @"MEGAGENDA\Contratos\");


        //Por exemplo, Kessie e Nido
        public static List<Pessoa> pessoas = new List<MODEL.Pessoa>();


        public static List<string> tiposEventos = new List<string>() {"Casamento"};

        
        public static void ReadConfigs()
        {

        }

        public static void SaveConfigs()
        {

        }
    }

}
