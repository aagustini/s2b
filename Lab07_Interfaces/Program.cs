using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
           IEstadoBinario[] lista = new IEstadoBinario[2];
            lista[0] = new Lampada(110, 60);
            lista[0].Ligar();
            lista[1] = new TermometroEletrico();
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("{0}/{1}",lista[i] , lista[i].Estado);
            }
            Console.ReadLine();
        }
    }
}
