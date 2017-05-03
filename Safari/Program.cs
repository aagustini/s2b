using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safari
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente c1 = new Cliente() { Codigo = 120, Nome = "Joao Doe" };
            Cliente c2 = new Cliente() { Codigo = 129, Nome = "D. Maria" };

            Produto p1 = new Produto() { CodigoProduto = 34, Descricao = "Carvao 10kg       ", PrecoUnitario = 12.0M };
            Produto p2 = new Produto() { CodigoProduto = 35, Descricao = "Arroz agulinha    ", PrecoUnitario = 2.0M };
            Produto p3 = new Produto() { CodigoProduto = 36, Descricao = "Cerveja pack 12uni", PrecoUnitario = 32.0M };
            Produto p4 = new Produto() { CodigoProduto = 37, Descricao = "Sal de frutas ENO ", PrecoUnitario = 7.0M };

            Produto pe1 = new ProdutoEE()
            {
                CodigoProduto = 72,
                Descricao = "TV Sony 32 pol",
                PrecoUnitario = 1200,
                DiasGarantia = 480
            };
            NotaCompra nota1 = new NotaCompra(c1);
            nota1.add(1, p1);
            nota1.add(2, p2);
            nota1.add(3, p4);
            nota1.add(1, pe1);


            Console.WriteLine(nota1.geraNota());

            Console.ReadKey();
        }
    }
}
