using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11_LinqtoObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            var pessoas = new List<Pessoa>
            {
                new Pessoa{Nome="Ana", DataNascimento=new DateTime(1980,3,14), Casada=true},
                new Pessoa{Nome="Paulo", DataNascimento=new DateTime(1978,3,9), Casada=false},
                new Pessoa{Nome="Ana Maria", DataNascimento=new DateTime(1980,3,14), Casada=false},
                new Pessoa{Nome="Carlos", DataNascimento=new DateTime(1999,12,12), Casada=true},
                new Pessoa{Nome="Pedro", DataNascimento=new DateTime(1970,5,27), Casada=false},
                new Pessoa{Nome="Huginho", DataNascimento=new DateTime(1970,5,27), Casada=true},
                new Pessoa{Nome="Zezinho", DataNascimento=new DateTime(1980,3,17), Casada=false},
                new Pessoa{Nome="Luizinho", DataNascimento=new DateTime(1990,3,7), Casada=false}

            };
            
            #region #demo...
            //Consulta tradiconal
            List<Pessoa> resultado1 = new List<Pessoa>();
            foreach (Pessoa p in pessoas)
            {
                if (p.Casada)
                    resultado1.Add(p);
            }
            Console.WriteLine("Pessoas casadas, consulta tradiconal:");
            foreach (Pessoa p in resultado1)
            {
                Console.WriteLine(p.Nome);
            }

            //Consulta LINQ
            var resultado2 = from p in pessoas
                             where p.Casada
                             select p;
            Console.WriteLine("\nPessoas casadas, consulta linq:");
            foreach (Pessoa p in resultado2)
            {
                Console.WriteLine(p.Nome);
            }

            Console.WriteLine("\nPessoas casadas, consulta linq (method syntax):");
            var resultado3 = pessoas.Where(p => p.Casada);
            foreach (Pessoa p in resultado3)
            {
                Console.WriteLine(p.Nome);
            }

            // para obter uma "lista" a partir da consulta linq
            var resultado4 = (from p in pessoas
                              where p.Casada
                              select p).ToList();


            Console.WriteLine("\nPessoas casadas que nasceram após 01/01/1980");
            var resultado5 = (from p in pessoas
                              where p.Casada && p.DataNascimento >= new DateTime(1980, 1, 1)
                              select p).ToList();

            // ups! forçando um pouco a barra...
            resultado5.ForEach(p => Console.WriteLine(p.Nome + " " + p.DataNascimento));


            Console.WriteLine("\nProjeção sobre o nome das pessoas casadas");
            var resultado6 = from p in pessoas
                             where p.Casada
                             select p.Nome;

            foreach (String s in resultado6)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("\nSoteiros em uma lista de objetos anonimos..");
            var resultado7 = (from p in pessoas
                              where !p.Casada
                              select new { p.Nome, p.DataNascimento }).ToList();

            foreach (var elem in resultado7)
            {
                Console.WriteLine(elem.Nome + " " + elem.DataNascimento);
            }

            Console.WriteLine("\nPessoas agrupadas pelo estado civil");
            var resultado8 = from p in pessoas
                             group p by p.Casada;
            foreach (var g in resultado8)
            {
                Console.WriteLine($"casado:{g.Key}");
                foreach (var p in g)
                {
                    Console.WriteLine(p);
                }
            }

            Console.WriteLine("\nPessoa mais nova");
            var resultado9 = pessoas.Min(p => p.DataNascimento);
            //Console.WriteLine("Consulta 9:");
            //Console.WriteLine(resultado9);

            var resultado10 = (from p in pessoas
                               where p.DataNascimento == resultado9
                               select p.Nome).ToList();

            resultado10.ForEach(x => Console.WriteLine(x));

            Console.ReadLine();
            #endregion


            Console.WriteLine("\n>>> Nome e data de nascimento das pessoas casadas");
            int cont = 0;
            var r3 = from p in pessoas
                     where p.Casada
                     select new { Id = ++cont,
                                 p.Nome,
                                 p.DataNascimento };  // objeto anonimo

            Console.WriteLine("contador...: " + cont);          // query ainda não foi executada...

            foreach (var p in r3)
                Console.WriteLine(p.Id + ": " + p.Nome + " " + p.DataNascimento);
            Console.WriteLine();

            Console.WriteLine("contador...: " + cont);          // incrementado na consulta
            Console.ReadKey();

            Console.WriteLine(">>> Pessoas ordenadas pelo nome");
            var r4 = from p in pessoas
                     orderby p.Nome
                     select p;
            foreach (var p in r4)
                Console.WriteLine(p.Nome);
            Console.WriteLine();

            Console.WriteLine(">>> Pessoas ordenadas pelo nome - extension methods");
            //IEnumerable<string> r4e =  pessoas.Where( p => p.Casada ).OrderBy( p => p.Nome ).Select( p => p.Nome.ToUpper() );
            IEnumerable<string> r4e = pessoas.Where(p => p.Casada)
                                             .OrderBy(p => p.Nome)
                                             .Select(p => p.Nome.ToUpper());

            foreach (var nome in r4e)
                Console.WriteLine(nome);
            Console.WriteLine();
            Console.ReadKey();


            //Console.WriteLine(">>> Pessoas ordenadas inversamente pelo nome");
            //var r5 = from p in pessoas
            //         orderby p.Nome descending
            //         select p;
            //foreach (var p in r5)
            //    Console.WriteLine(p.Nome);
            //Console.WriteLine();

            #region Console.WriteLine(">>> Pessoas ordenadas pela data de nascimento e nome");
            var r6 = from p in pessoas
                     orderby p.DataNascimento, p.Nome
                     select p;
            foreach (var p in r6)
                Console.WriteLine(p.DataNascimento + " " + p.Nome);
            Console.WriteLine();
            #endregion

            #region  Console.WriteLine(">>> Pessoas agrupadas pelo estado civil, com quantidade e conversão do boolean");
            var r7 = from p in pessoas
                     group p by p.Casada;
            foreach (var g in r7)
            {

                Console.WriteLine("Categoria: " + (g.Key ? "CASADAS" : "SOLTEIRAS") + " quantidade: " + g.Count());
                foreach (var p in g)
                    Console.WriteLine("  " + p.Nome);
            }
            Console.WriteLine();
            #endregion

            #region  Console.WriteLine(">>> Projeção de pessoas agrupadas pelo estado civil");
            var r8 = from p in pessoas
                     group p by p.Casada
                         into grupoPessoas
                         select new { Categoria = grupoPessoas.Key, Pessoas = grupoPessoas, NroPessoas = grupoPessoas.Count() };

            foreach (var g in r8)
            {
                Console.WriteLine("Categoria: " + g.Categoria + " Quantidade: " + g.NroPessoas);

                foreach (var p in g.Pessoas)
                    Console.WriteLine("  " + p.Nome);
            }
            Console.WriteLine();
            #endregion

            #region Console.WriteLine("\n>>> Total de pessoas casadas");
            var r9 = (from p in pessoas
                      where p.Casada
                      select p).Count();
            Console.WriteLine(r9);
            Console.WriteLine();
            #endregion

            Console.WriteLine("\n>>> Pessoa mais velha");
            var r10 = (from p in pessoas
                       orderby p.DataNascimento ascending
                       select p).First();
            Console.WriteLine(r10);
            Console.WriteLine();

            Console.WriteLine("\n>>> Pessoa solteira mais nova");
            var r11 = (from p in pessoas
                       orderby p.DataNascimento descending
                       where !p.Casada
                       select p).First();
            Console.WriteLine(r11);
            var maiorIdadeA = pessoas.Min(q => q.DataNascimento);
            Console.WriteLine("\n>>> Pessoa + idosa");
            var r12 = (from p in pessoas          
                       where p.DataNascimento == maiorIdadeA
                       select p).First();
            Console.WriteLine(r12);

            Console.WriteLine("\n>>> Pessoa + idosa v2");
            var r13 = (from p in pessoas
                       let maiorIdade = pessoas.Min(q => q.DataNascimento)
                       where p.DataNascimento == maiorIdade
                       select p);
            foreach (var p in r13)
                Console.WriteLine(p);

            Console.WriteLine();


            Console.WriteLine("\n>>> Data de nascimento da + nova");
            var r14 = (from p in pessoas
                       where !p.Casada
                       select p).Max(p => p.DataNascimento);

            Console.WriteLine(r14);

            Console.WriteLine("\n>>> Solteira + nova");
            var r15 = (from p in pessoas
                       let maiorIdade = pessoas.Where(q => !q.Casada).Max(q => q.DataNascimento)
                       where p.DataNascimento == maiorIdade
                       select p).First();
            Console.WriteLine(r15);



            Console.WriteLine();

            Console.ReadKey();

            Console.WriteLine(">>> Projeção de pessoas agrupadas por mês de nascimento");
            var r16 = from p in pessoas
                     group p by p.DataNascimento.Month
                         into grupoPessoas
                   //  orderby grupoPessoas.Key
                    select new { Mes = grupoPessoas.Key,
                   //              Pessoas = grupoPessoas.OrderBy( o => o.DataNascimento.Day).ThenBy(n => n.Nome),
                                 Pessoas = grupoPessoas,

                        NroPessoas = grupoPessoas.Count() };

            //   foreach (var g in r16)
            foreach (var g in r16.OrderBy(m => m.Mes))
            {
                Console.WriteLine("Mês de aniversário: " + g.Mes +
                    " Quantidade: " + g.NroPessoas);

                //foreach (var p in g.Pessoas)
                foreach (var p in g.Pessoas.OrderBy(d => d.DataNascimento.Day))
                        Console.WriteLine("  " + p.Nome + " - " + p.DataNascimento.ToShortDateString());
            }
            Console.WriteLine();
            Console.ReadKey();

            var r17 = pessoas.Average(p => p.DataNascimento.Year);
            Console.WriteLine("\n>>> Idade média em anos : " + 
                                      (DateTime.Now.Year - r17));

            var r18 = pessoas.Average(p => DateTime.Now.Year - p.DataNascimento.Year);
            Console.WriteLine("\n>>> Idade média em anos : " + r18);


            Console.WriteLine();
           


            Console.ReadKey();

        }
    }
}
