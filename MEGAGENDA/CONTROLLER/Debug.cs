using MEGAGENDA.CONTROLLER;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEGAGENDA.MODEL
{
    public static class Debug
    {
        public const bool ON = true;
        private const bool LOG = true;
        private const bool CRONO = true;

        private static Dictionary<string, Stopwatch> Timers = new Dictionary<string, Stopwatch>();

        public static void Log(string msg)
        {
            if (Debug.ON)
            {
                if (LOG)
                    WriteLog(msg);
                else
                    Console.WriteLine(msg);
            }
        }

        private static void WriteLog(string msg)
        {
            string path = Path.Combine(Configs.CONFIG_PATH, "Log.txt");
            using (StreamWriter outputFile = new StreamWriter(path, true))
                outputFile.WriteLine(msg);
        }

        public static void StartTimer(string name)
        {
            if (Debug.ON && Debug.CRONO)
            {

                Timers.Add(name, Stopwatch.StartNew());
            }
        }

        public static void StopTimer(string name)
        {
            if (Debug.ON && Debug.CRONO)
            {
                try
                {
                    Timers[name].Stop();
                    TimeSpan timespan = Timers[name].Elapsed;
                    Timers.Remove(name);

                    Log(name + ": " + String.Format("{0:00}:{1:00}:{2:00}", timespan.Minutes, timespan.Seconds, timespan.Milliseconds / 10));
                }
                catch
                {

                }
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
                Evento e = new Evento(pid, i.ToString(), pid.ToString(), 1200, new List<string> { "Nido" }, new Endereco("teste"), DateTime.Today, DateTime.Today, DateTime.Today, 4, true, true, 0, "Vai ser muito legal", new List<Pagamento>() { new Pagamento(1, 0, DateTime.Today, true, 1) });
                Evento.Add(e);
            }
            timer.Stop();
            TimeSpan timespan = timer.Elapsed;
            Console.WriteLine(String.Format("{0:00}:{1:00}:{2:00}", timespan.Minutes, timespan.Seconds, timespan.Milliseconds / 10));

        }
    }
}
