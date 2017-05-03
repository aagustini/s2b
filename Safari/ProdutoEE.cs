using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safari
{
    public class ProdutoEE : Produto
    {
        public int DiasGarantia { get; set; }

        public String getGarantia()
        {
            return "Produto: " + Descricao +
                   "\nGaratia de " + DiasGarantia +
                   " dias\nVencimento da garantia: " + 
                   DateTime.Now.AddDays(DiasGarantia).ToShortDateString();
        }
    }
}
