using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_ColecoesGenericas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listaStrings = new List<string>();
            listaStrings.Add("Um");
            listaStrings.Add("Hello");
            listaStrings.Add("World");
            //  listaStrings.Add(10);

            Console.WriteLine("\nLista de strings:");
            Console.WriteLine(listaStrings[0]);
            Console.WriteLine(listaStrings[1]);
            Console.WriteLine(listaStrings[2]);

            Console.WriteLine(String.Format("ls.contais(Hello): {0}, na posicão {1}",
                listaStrings.Contains("Hello"),
                listaStrings.IndexOf("Hello")));

            Console.WriteLine(String.Format("ls.contais(Hi): {0}, na posicão {1}",
                listaStrings.Contains("Hi"),
                listaStrings.IndexOf("Hi")));

            Queue q = new Queue();
            q.Enqueue(".Net Framework");
            q.Enqueue(new Decimal(123.456));
            q.Enqueue(654.321);
            Console.WriteLine("\nFila de Object:");
            while (q.Count > 0)
            {
                Object temp = q.Dequeue();

                Console.WriteLine(temp + " - " + 
                                  temp.GetType());
            }

            Queue<int> minhaFila = new Queue<int>();
            minhaFila.Enqueue(10);
            minhaFila.Enqueue(200);
            minhaFila.Enqueue(1000);


            Console.WriteLine("\nFila de Int32:");
            while (minhaFila.Count > 0)
            {
                Object temp = minhaFila.Dequeue();

                Console.WriteLine(temp + " - " + temp.GetType());
            }
     
            Dictionary<int, string> paises = new Dictionary<int, string>();
            paises[44] = "Reino Unido";
            paises[33] = "França";
            paises[55] = "Brasil";

            Console.WriteLine("\nO código 55 é: {0}", paises[55]);
            
            foreach (KeyValuePair<int, string> item in paises)
            {
                int codigo = item.Key;
                string pais = item.Value;
                Console.WriteLine("Código {0} = {1}", codigo, pais);
            }

            Dictionary<int, Pais> paises2 = 
                new Dictionary<int, Pais>();
            paises2[44] = new Pais() {
                                      DDI = 44,
                                      Nome = "Reino Unido",
                                       Populacao = 60000
                                      };
            paises2[33] = new Pais() { DDI = 33, Nome = "França", Populacao = 120000 };
            paises2[55] = new Pais() { DDI = 55, Nome = "Brazil", Populacao = 220000 };
            paises2.Add(1, new Pais() { DDI = 1, Nome = "EUA" });


            Console.WriteLine("\nO código 55 é: {0}", paises2[55]);

            foreach (KeyValuePair<int, Pais> item in paises2)
            {
                int codigo = item.Key;
                Pais pais = item.Value;
                Console.WriteLine("Código {0} = {1}", codigo, pais);
            }

            

            List<double> lista = new List<double>() { 1,2,3,4,5,6,7,8,9,10};
            

            Console.WriteLine("\nMédia: {0:F2}", lista.Average());
            Console.WriteLine("Maior: {0}", lista.Max());
            Console.WriteLine("Menor: {0}", lista.Min());
            var result = lista.FindAll(v => v > lista.Average());

            var result2 = lista.Where(v => v > lista.Average());



            Console.Write("\nAcima da média: ");
            
            foreach (int val in result2)
            {
                Console.Write(val+" ");
            }

            Console.WriteLine();

         


            Console.ReadLine();




        }
    }
}
