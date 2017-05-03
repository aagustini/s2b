using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_TiposDados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exer 1");
            byte b;
            b = byte.MaxValue;
            Console.WriteLine("Valor máximo de b:" + b);
            b++;
            Console.WriteLine("Valor máximo de b+1:" + b);
            int ii = int.MaxValue;
            Console.WriteLine("Valor máximo de i:" + ii);
            long l = long.MaxValue;
            Console.WriteLine("Valor máximo de l:" + l);

            Console.WriteLine("");

            string strPrimeira = "Alo ";
            string strSegunda = "mundo";
            string strTerceira = strPrimeira + strSegunda;
            Console.WriteLine(strTerceira);
            int cchTamanho = strTerceira.Length;
            string strQuarta = "Tamanho: " + cchTamanho.ToString();
            Console.WriteLine(strQuarta);
            Console.WriteLine(strTerceira.Substring(0, 5));

            Console.WriteLine("");

            DateTime dt = new DateTime(2010, 1, 6);
            string strQuinta = dt.ToString();
            Console.WriteLine(strQuinta);
            Console.ReadLine();


            // Exercício 2: Brincando com strings
            Console.WriteLine("\nExer 2");
            String s = "Um dia depois do outro";
            Console.WriteLine(s);
            s = s.Remove(3, 4);
            Console.WriteLine(s);
            s = s.Replace('d', 'D');
            Console.WriteLine(s);
            s = s.ToUpper();
            Console.WriteLine(s);
            Console.ReadLine();


            //Exercício 3: Brincando com datas
            Console.WriteLine("\nExer 3");
            DateTime d = DateTime.Now;
            Console.WriteLine(d.ToShortDateString());
            Console.WriteLine(d.ToShortTimeString());
            Console.WriteLine(d.ToLocalTime());
            Console.ReadLine();


            // Exercício 4: conversão implícita e explícita
            Console.WriteLine("\nExer 4");
            int i = 10;
            float f = 0;
            f = i; //conversão implícita, sem perda de dados.
            System.Console.WriteLine(f);
            f = 0.5F;
            i = (int)f; //conversão explícita, com perda de dados.
            System.Console.WriteLine(i);
            Console.ReadLine();


            // Exercício 5: System.Convert
            Console.WriteLine("\nExer 5");
            string stringInteiro = "123456789";
            int valorStringInteiro = Convert.ToInt32(stringInteiro);
            Console.WriteLine(valorStringInteiro);
            Int64 valorInt64 = 123456789;
            int valorInt = Convert.ToInt32(valorInt64);
            Console.WriteLine(valorInt);

            //string stringInteiroGrande = "999999999999999999999999999999999999999999999";
            //int valorStringInteiroGrande = Convert.ToInt32(stringInteiroGrande);
            Console.ReadLine();


            // Exercício 6: TryParse
            Console.WriteLine("\nExer 6");
            string stringInt = "123456789";
            int valorStringInt;
            bool conversao1 = Int32.TryParse(stringInt, out valorStringInt);
            Console.WriteLine("Conversão efetuada: " + conversao1 + " Valor: " + valorStringInteiro);


            string stringInteiroGrande2 = "999999999999999999999999999999999999999999999";
            int valorStringInteiroGrande2;
            bool conversao2 = Int32.TryParse(stringInteiroGrande2, out valorStringInteiroGrande2);
            Console.WriteLine("Conversão efetuada: " + conversao2 + " Valor: " + valorStringInteiroGrande2);

            string stringLetras = "abc";
            double valorStringLetras;
            bool conversao3 = Double.TryParse(stringLetras, out valorStringLetras);
            Console.WriteLine("Conversão efetuada: " + conversao3 + " Valor: " + valorStringLetras);
            Console.ReadLine();


            // Exercício 7: diferentes algoritmos de conversão
            Console.WriteLine("\nExer 7");
            double valorFracionado = 4.7;
            int valorInteiro1 = (int)valorFracionado;
            int valorInteiro2 = Convert.ToInt32(valorFracionado);
            Console.WriteLine("Conversao explicita = " + valorInteiro1);
            Console.WriteLine("Conversao metodo Convert = " + valorInteiro2);
            Console.ReadLine();


            // Exercício 8: sintaxe do WriteLine
            Console.WriteLine("\nExer 8");
            int x = 10;
            double y = 3.4;
            Console.WriteLine("X=" + x + " Y=" + y);
            Console.WriteLine("X={0} Y={1}", x, y);

        }
    }
}
