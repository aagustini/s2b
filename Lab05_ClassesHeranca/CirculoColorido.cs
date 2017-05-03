using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05_ClassesHeranca
{
    class CirculoColorido : Circulo
    {
        private string minhaCor;

        public string Cor
        {
            get
            {
                return (minhaCor);
            }
            set
            {
                minhaCor = value;
            }
        }

        public CirculoColorido()
            : base(0, 0, 1)
        {
            Cor = "preto";
        }

        public CirculoColorido(double x, double y, double r, string c)
            : base(x, y, r)
        {
            Cor = c;
        }

        public override string ToString()
        {
            return base.ToString() + ", cor=" + Cor;
        }
    }
}
