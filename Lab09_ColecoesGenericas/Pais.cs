using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_ColecoesGenericas
{
    public class Pais
    {
        public int DDI { get; set; }
        public string Nome { get; set; }
        public int Populacao { get; set; }

        public override string ToString()
        {
            return string.Format("({0}) - {1}, popul: {2}",
                DDI, Nome, Populacao);
        }
    }
}
