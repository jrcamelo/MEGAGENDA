using MEGAGENDA.MODEL;
using Pabo.Calendar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEGAGENDA.CONTROLLER
{
    public static class Calendario
    {
        private static MonthCalendar Owner;

        public static void SetCalendario(MonthCalendar calendario)
        {
            Owner = calendario;
        }

        public static DateItemCollection CarregarDatabase(bool finalizados, bool possiveis, bool pagamentos, string primeiro_dia, string ultimo_dia)
        {
            DateItemCollection Datas = new DateItemCollection(Owner);

            List<Dia> listaEventos = Dia.GetEventos(finalizados, possiveis, primeiro_dia, ultimo_dia);
            foreach (Dia d in listaEventos)
                Datas.Add(d);

            if (!pagamentos)
                return Datas;

            List<Dia> listaPagamentos = Dia.GetPagamentos(finalizados, possiveis, primeiro_dia, ultimo_dia);
            foreach (Dia d in listaPagamentos)
                Datas.Add(d);

            return Datas;
        }
    }
}
