using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05_ClassesHeranca
{
    class Program
    {
        static void Main(string[] args)
        {
              /*
            Circulo circ1 = new Circulo();
            Console.WriteLine(circ1);
            Circulo circ2 = new Circulo(2.4, 5, 3);
            Console.WriteLine(circ2);
            */
            Circulo circ1 = new Circulo();
            Console.WriteLine(circ1);
            Circulo circ2 = new Circulo(2.4, 5, 3);
            Console.WriteLine(circ2);
            CirculoColorido circ3 = new CirculoColorido();
            Console.WriteLine(circ3);
            CirculoColorido circ4 = new CirculoColorido(1.5, 3.1, 1, "vermelho");
            Console.WriteLine(circ4);
/*
            Circulo x = circ4;
            x.ToString();
            x.Cor;
*/
            CirculoPreenchido circ5 = new CirculoPreenchido(2, 2, 10, "Vermelho escuro", "Vermelho claro");
            Console.WriteLine(circ5);

            List<Circulo> lst = new List<Circulo>();
            lst.Add(new CirculoPreenchido(3,3,15,"Verde","Rosa"));
            lst.Add(new Circulo(1, 1, 5));
            lst.Add(new CirculoColorido(2,2,10,"Roxo"));
            foreach(Circulo c in lst){
                Console.WriteLine(c);
            }

            Console.WriteLine("x={0}, y={1}", circ5.CentroX, circ5.CentroY);

            Console.ReadLine();
        }
    }
}
