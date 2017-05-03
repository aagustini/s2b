using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_EventosDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            // inicializa o termometro e mostra seu valor
            TermometroLimite term = new TermometroLimite(5);
            Console.WriteLine(term.ToString());

            // adiciona um tratador ao evento LimiteSuperiorEvent
           // term.LimiteSuperiorEvent += new TermometroLimite.MeuDelegate(TrataLimiteSuperior);
            term.LimiteSuperiorEvent += new TermometroLimite.MeuDelegate(TrataLimiteSuperior);

            // aumentar a temperatura além do limite
            term.Aumentar(6);
            Console.WriteLine(term.ToString());

            Console.ReadLine();
        }

       //  private static void TrataLimiteSuperior(string msg)
        private static void TrataLimiteSuperior(string msg, double temp)
        {
            Console.WriteLine(msg+"  -  temperatura atual: " + temp);
        }


      
    }
}
