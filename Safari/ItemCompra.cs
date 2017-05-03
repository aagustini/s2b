using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safari
{
    public class ItemCompra  : IComparable<ItemCompra>
    {
        public int Quantidade { get; set; }
        public Produto Produto { get; set;  }

        public ItemCompra(int q, Produto p)
        {
            Quantidade = q;
            Produto = p;
        }

        public Decimal PrecoItem
        {
            get { return Quantidade * Produto.PrecoUnitario; }
        }

        public override string ToString()
        {
            return String.Format("{0} {1} \t {2} {3}",
                                 Produto.CodigoProduto,
                                 Produto.Descricao,
                                 Quantidade,
                                 PrecoItem);
        }

        public int CompareTo(ItemCompra other)
        {
            return other.PrecoItem.CompareTo(this.PrecoItem);
        }
    }
}
