using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEGAGENDA.MODEL
{
    public class Funcionario
    {
        public string identificador;
        public string nome;

        public Funcionario(string identificador, string nome)
        {
            this.identificador = identificador;
            this.nome = nome;
        }
    }
}
