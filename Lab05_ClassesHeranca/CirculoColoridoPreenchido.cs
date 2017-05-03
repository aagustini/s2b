using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05_ClassesHeranca
{
    class CirculoPreenchido : CirculoColorido
    {
        private string minhaCorf;

        public string CorFundo
        {
            get
            {
                return (minhaCorf);
            }
            set
            {
                minhaCorf = value;
            }
        }

        public CirculoPreenchido()
            : base(0, 0, 1, "preto")
        {
            Cor = "preto";
        }

        public CirculoPreenchido(double x, double y, double r, string c, string cp)
            : base(x, y, r, c)
        {
            Cor = cp;
        }

        public override string ToString()
        {
            return base.ToString() + ", preenchimento=" + Cor;
        }
    }
}
