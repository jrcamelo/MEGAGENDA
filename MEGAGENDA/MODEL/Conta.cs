using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEGAGENDA.MODEL
{
    [Serializable]
    public class Conta
    {
    //Classe simples que trata as informações das contas bancárias dos contratados
    
        public string banco;
        public string agencia;
        public string conta;

        public Conta(string banco, string agencia, string conta)
        {
            this.banco = banco;
            this.agencia = agencia;
            this.conta = conta;
        }
    }
}
