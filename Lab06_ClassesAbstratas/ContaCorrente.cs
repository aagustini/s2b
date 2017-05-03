using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_ClassesAbstratas
{
    public class ContaCorrente : Conta
    {
        public const decimal Taxa = 0.10M;

        public ContaCorrente(string t)
            : base(t)
        {
        }

        public override string Id
        {
            get { return Titular + " (CC)"; }
        }

        public override void Depositar(decimal valor)
        {
            decimal desconto = valor * Taxa;
            base.Depositar(valor - desconto);
        }

        public override void Sacar(decimal valor)
        {
            decimal desconto = valor * Taxa;
            base.Sacar(valor + desconto);
        }
    } 
}
