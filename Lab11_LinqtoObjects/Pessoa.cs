using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11_LinqtoObjects
{
    public class Pessoa
    {

        public bool Casada { get; set; }

        public String Nome { get; set; }

        public DateTime DataNascimento { get; set; }

        public override string ToString()
        {
            return "[Nome=" + Nome +
                   ", Casada=" + Casada +
                   ", DataNascimento=" + DataNascimento.ToShortDateString() + "]";
        }

    }
}
