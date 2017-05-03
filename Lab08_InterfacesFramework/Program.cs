using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_InterfacesFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lista = { "Julio", "Lucia", "Daniel", "Joao" };
            Console.WriteLine("Array antes da ordenacao");
            for (int i = 0; i < lista.Length; i++)
            {
                Console.Write(lista[i] + " ");
            }
            Console.WriteLine();
            Array.Sort(lista);
            Console.WriteLine("Array depois da ordenacao");
            for (int i = 0; i < lista.Length; i++)
            {
                Console.Write(lista[i] + " ");
            }


            Console.WriteLine();
            Pessoa[] lista2 = {
	            new Pessoa("Jose", 25),
	            new Pessoa("Ana", 28),
	            new Pessoa("Paulo", 20),
                 new Pessoa("Caio", 19),
	            new Pessoa("Julia", 18)
            };

            Array.Sort(lista2);

            Console.WriteLine("\nArray de pessoas após ordenar");
            for (int i = 0; i < lista2.Length; i++)
            {
               // Console.Write(lista2[i].Nome + " ");
                Console.Write(lista2[i] + " ");

            }


            Console.ReadLine();


        }
    }
}
