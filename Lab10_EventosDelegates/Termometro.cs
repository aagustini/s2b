using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_EventosDelegates
{
    public class Termometro
    {
        private double valor;

        public Termometro()
        {
            valor = 0.0;
        }

        public double Temperatura
        {
            get { return valor; }
            set { valor = value; }
        }

        virtual public void Aumentar()
        {
            valor += 0.1;
        }

        virtual public void Aumentar(double quantia)
        {
            valor += quantia;
        }

        virtual public void Diminuir()
        {
            valor -= 0.1;
        }

        virtual public void Diminuir(double quantia)
        {
            valor -= quantia;
        }

        override public string ToString()
        {
            return valor.ToString();
        }
    }

}
