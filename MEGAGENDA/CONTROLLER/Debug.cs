using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEGAGENDA.MODEL
{
    public static class Debug
    {
        public const bool ON = true;
        private const bool LOG = false;
        
        public static void Log(string msg)
        {
            if (Debug.ON)
            {
                //if (LOG)
                //WriteLog(msg)
                //else
                Console.WriteLine(msg);
            }
        }
        
        public static void SpamAdd()
        {
            int length = 1000;
            Stopwatch timer = Stopwatch.StartNew();

            for (int i = 0; i < length; i++)
            {
                Pessoa p = new Pessoa(i.ToString(), i.ToString(), i.ToString(), "M", "tel", "cel", "email", "facebook", new Endereco("aa", i.ToString(), "aaa", "aa", "aaa", "aa"), "aa");
                int pid = Pessoa.Add(p);
                Evento e = new Evento(pid, i.ToString(), pid.ToString(), 1200, 400, true, "Nido", "Primeira", new Endereco("teste"), DateTime.Today, DateTime.Today, DateTime.Today, 4, true, true, "AGENDADO", "Fornecedores", "Vai ser muito legal", new List<Pagamento>() { new Pagamento(1, 0, DateTime.Today, true, 1)});
                Evento.Add(e);
            }
            timer.Stop();
            TimeSpan timespan = timer.Elapsed;
            Console.WriteLine(String.Format("{0:00}:{1:00}:{2:00}", timespan.Minutes, timespan.Seconds, timespan.Milliseconds / 10));

        }
    }
}
