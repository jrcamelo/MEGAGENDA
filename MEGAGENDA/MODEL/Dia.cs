using Pabo.Calendar;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEGAGENDA.MODEL
{
    public class Dia : DateItem
    {
        public Dia(Evento evento) : base(evento.data, evento.ID, evento.tipo, Color.Empty)
        {
            Color cor;
            if (evento.data < DateTime.Today || evento.situacao != "AGENDADO")
                cor = Color.Empty;
            else if (evento.data == DateTime.Today || evento.data == DateTime.Today.AddDays(1))
                cor = Color.Red;
            else if (evento.data < DateTime.Today.AddDays(7))
                cor = Color.Plum;
            else
                cor = Color.LightBlue;

            if (cor != Color.Empty)
                this.BackColor1 = cor;
        }

        public Dia(Pagamento pagamento) : base(pagamento.data, pagamento.EID, pagamento.parcela, Color.Empty)
        {
            Color cor;
            if (pagamento.data <= DateTime.Today)
                cor = Color.Gray;
            else
                cor = Color.Empty;

            if (cor != Color.Empty)
                this.BackColor1 = cor;
        }


        private static string FazerWhere(bool finalizados, bool possiveis, string primeiro, string ultimo)
        {
            string where = "WHERE (Situacao = 'AGENDADO'";

            if (finalizados)
                where += " OR Situacao = 'FINALIZADO'";
            if (possiveis)
                where += " OR Situacao = 'POSSÍVEL'";

            return where + ") ";
        }

        public static List<Dia> GetEventos(bool finalizados, bool possiveis, string primeiro, string ultimo)
        {
            string mes_ativo = $"AND (Data BETWEEN '{primeiro}' AND '{ultimo}') ";

            List<Dia> dias = new List<Dia>();
            List<Evento> eventos = Evento.GetAllDatas(FazerWhere(finalizados, possiveis, primeiro, ultimo) + mes_ativo);
            foreach (Evento ev in eventos)
                dias.Add(new Dia(ev));
            return dias;
        }

        public static List<Dia> GetPagamentos(bool finalizados, bool possiveis, string primeiro, string ultimo)
        {
            string mes_ativo = $"AND (Vencimento BETWEEN '{primeiro}' AND '{ultimo}') ";

            List<Dia> dias = new List<Dia>();
            List<Pagamento> pagamentos = Pagamento.GetAllDatas(FazerWhere(finalizados, possiveis, primeiro, ultimo) + mes_ativo + " AND Pago = 0");
            foreach (Pagamento pag in pagamentos)
                dias.Add(new Dia(pag));
            return dias;
        }
    }
}
