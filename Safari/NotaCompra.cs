using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safari
{
    public class NotaCompra
    {
        public Cliente Cliente { get; set; }
        public DateTime DataCompra { get; set; }

        private List<ItemCompra> listaItens;

        public NotaCompra(Cliente c)
        {
            Cliente = c;
            listaItens = new List<ItemCompra>();
            DataCompra = DateTime.Now;
        }

        public void add(int qtde, Produto p)
        {
            listaItens.Add(new ItemCompra(qtde, p));
        }

        public String geraNota()
        {
            StringBuilder nota = new StringBuilder("Compre bem, compre Safari!");
            nota.AppendLine("\nData da compra :" + DataCompra.ToLongDateString());
            nota.AppendLine("Cliente: " + Cliente.Nome);
            nota.AppendLine("\nCod Desc        Qtde   Valor");

            decimal total = 0;
            listaItens.Sort();
            foreach (ItemCompra ic in listaItens)
            {
                nota.AppendLine(ic.ToString());
                total += ic.PrecoItem;
            }
            nota.AppendLine("\nValor total da compra: "+total
                );
            nota.AppendLine("\n--- Obrigado por comprar Safari!");
            foreach (ItemCompra ic in listaItens)
            {
                if (ic.Produto is ProdutoEE)
                {
                    ProdutoEE pe = (ProdutoEE)ic.Produto;
                    nota.AppendLine("\n"+pe.getGarantia());

                }
            }

            return nota.ToString();

        }
    }
}



