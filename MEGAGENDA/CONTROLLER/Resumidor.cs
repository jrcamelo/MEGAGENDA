using MEGAGENDA.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEGAGENDA.CONTROLLER
{
    public static class Resumidor
    {

        public static string WhereEvento()
        {
            return " WHERE Situacao = 1 AND Data BETWEEN @datade AND @dataa ";
        }

        public static string ListarEventos(DateTime datade, DateTime dataa)
        {
            List<Tuple<Evento, Pessoa>> eventos = Evento.GetAgendadosData(datade, dataa);

            string result = "";

            foreach (Tuple<Evento, Pessoa> t in eventos)
            {
                result += ResumirEvento(t.Item1, t.Item2);
            }

            return result;
        }


        public static string ResumirEvento(Evento e, Pessoa p)
        {
            string line = "";

            line += $"{e.data.ToShortDateString()} às {e.horaCabine.ToShortTimeString()}\r\n";

            line += $"ID do evento: {e.ID} - {e.tipo} de ";
            if (e.protagonista != "")
                line += $"{e.protagonista}\r\n";
            else
                line += $"{e.cliente.nome}\r\n";

            line += $"{string.Join(",", e.equipe)} - ";
            if (e.guestbook)
                line += "(Guestbook) ";
            if (p.telefone != null && p.telefone != "")
                line += $"- Fone: {p.telefone} ";
            if (p.celular != null && p.celular != "")
                line += $"- Cel: {p.celular} ";
            if (p.email != null && p.email != "")
                line += $"- Email: {p.email} ";
            if (p.endereco != null && p.endereco.ToTexto() != "")
                line += $"\r\nLocal: {p.endereco.ToTexto()} ";

            return line + "\r\n";
        }



        public static string WherePagamento()
        {
            return " WHERE Vencimento = @vencimento AND Pago = 0 ";
        }



    }
}
