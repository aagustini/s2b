using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Array de inteiros");
            int[] array = new int[5] { 10, 20, 30, 40, 50 };
            int i, j;

            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("Indice = " + i + " & Valor = " + array[i]);
            }

            Console.WriteLine("\nArray de strings");
            string[] str = new string[3];
            int iStr;
            str[0] = "Um";
            str[1] = "Dois";
            str[2] = "Tres";
            for (iStr = 0; iStr < 3; iStr++)
            {
                Console.WriteLine("Indice = " + iStr + " & Valor = " + str[iStr]);
            }

            Console.WriteLine("\nArray de datas");
            DateTime[] dt = new DateTime[4];
            int iDate;
            dt[0] = new DateTime(2002, 5, 1);
            dt[1] = new DateTime(2002, 6, 1);
            dt[2] = dt[1].AddYears(10);
            dt[3] = dt[0].AddMonths(18);

            for (iDate = 0; iDate < 4; iDate++)
            {
                Console.WriteLine("Indice = " + iDate + " & Data = " + dt[iDate].ToShortDateString() );
            }

            Console.WriteLine("");
            foreach (DateTime d in dt)
            {
                Console.WriteLine("Data = " + d.ToShortDateString());
            }


            Console.ReadLine();

            //int i, j;
            Random r = new Random();

            #region Exercicio 2.1

            Console.WriteLine("Exercicio - Array");
            int[] v1 = new int[10];
            int[] v2 = new int[10];

            for (i = 0; i < 10; i++) v1[i] = r.Next(10);

            for (i = 0; i < 10; i++) v2[i] = v1[9 - i];


            for (i = 0; i < 10; i++) Console.Write(v1[i] + " ");
            Console.WriteLine("\n");

            for (i = 0; i < 10; i++) Console.Write(v2[i] + " ");
            Console.WriteLine("\n");

            #endregion

            #region Exercicio 2.2 - array multidimensional

            Console.WriteLine("Exercicio - Array multidimensional");
            int[,] m = new int[5, 5];
            int[] v = new int[5];

            for (i = 0; i < 5; i++)
                for (j = 0; j < 5; j++) m[i, j] = r.Next(10);


            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    Console.Write(m[i, j] + "  ");
                }
                Console.WriteLine("");
            }

            for (j = 0; j < 5; j++)
            {
                v[j] = 0;
                for (i = 0; i < 5; i++)
                {
                    v[j] += m[i, j];
                }
            }

            Console.WriteLine("");

            for (i = 0; i < 5; i++) Console.Write(v[i] + " ");

            Console.WriteLine("\n");
      

            #endregion

            #region Exercicio 2.2 - array jagged

            Console.WriteLine("Exercicio - Array jagged");
            int[][] mj = new int[5][];
            int[] vs = new int[5];

            for (i = 0; i < 5; i++)
            {
                mj[i] = new int[5];
                for (j = 0; j < 5; j++) mj[i][j] = r.Next(10);
            }

            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    Console.Write(mj[i][j] + "  ");
                }
                Console.WriteLine("");
            }

            for (j = 0; j < 5; j++)
            {
                vs[j] = 0;
                for (i = 0; i < 5; i++)
                {
                    vs[j] += mj[i][j];
                }
            }

            Console.WriteLine("<br />");

            for (i = 0; i < 5; i++) Console.Write(vs[i] + " ");

            Console.WriteLine("");

            #endregion


            #region Exercicio 2.2 - array jagged (variando tamanho de linhas) - descomentar

            Console.WriteLine("Exercicio - Array jagged (versao modificada)");
            int[][] mjj = new int[5][];
            int[] vss = new int[5];

            for (i = 0; i < 5; i++)
            {
                mjj[i] = new int[r.Next(7) + 1];
                for (j = 0; j < mjj[i].Count(); j++) mjj[i][j] = r.Next(10);
            }

            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < mjj[i].Count(); j++)
                {
                    Console.Write(mjj[i][j] + "  ");
                }
                Console.WriteLine("");
            }

            Console.ReadLine();

            #endregion


        }
    }
}
