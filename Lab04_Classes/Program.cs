using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente minhaConta = new ContaCorrente("Jorge");
            Console.WriteLine("Data de criação: " + minhaConta.DataCriacao );
            Console.WriteLine("Movimentações conta: " + minhaConta.Nome);
            Console.WriteLine(minhaConta.Saldo);
            System.Threading.Thread.Sleep(2000);

            minhaConta.Depositar(100);
            Console.WriteLine("Atualizada em: " + minhaConta.DataAtualizacao);
            Console.WriteLine(minhaConta.Saldo);
            System.Threading.Thread.Sleep(2000);

            minhaConta.Sacar(50);
            Console.WriteLine("Atualizada em: " + minhaConta.DataAtualizacao );
            Console.WriteLine(minhaConta.Saldo);

            Console.WriteLine("Saldo médio: "+minhaConta.SaldoMedio);

            Console.ReadLine();
        }
    }
}
