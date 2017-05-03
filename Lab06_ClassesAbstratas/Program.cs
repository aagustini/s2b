using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_ClassesAbstratas
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta1 = new ContaCorrente("Fulano");
            DateTime t = new DateTime(2009, 10, 21);
            ContaPoupanca conta2 = new ContaPoupanca(0.5M,  t, "Beltrano");

            Console.WriteLine("Conta criada: " + conta1);
            Console.WriteLine("Conta criada: " + conta2);

            conta1.Depositar(100);
            conta2.Depositar(200);

            Console.WriteLine(conta1.Id + " - R$ " + conta1.Saldo);
            Console.WriteLine(conta2.Id + " - R$ " + conta2.Saldo);


            Conta[] cad = new Conta[3];

            cad[0] = conta1;
            cad[1] = conta2;
            cad[2] = new ContaPoupanca(0.5M, t.AddDays(10), "Beltrano");

            Console.WriteLine("\nAniversario das contas poupança:");

            foreach (Conta c in cad)
            {
                ContaPoupanca cp = c as ContaPoupanca;
                if (cp != null)
                {

                    Console.WriteLine(cp.Titular + " aniversaro " + cp.DataAniversario);
                }
            }

            Console.ReadLine();
        }
    }
}
