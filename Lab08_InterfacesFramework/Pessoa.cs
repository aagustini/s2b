using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_InterfacesFramework
{
    public class Pessoa : IComparable<Pessoa>
    {
        private string meuNome;
        private int minhaIdade;

        public Pessoa(string n, int i)
        {
            meuNome = n;
            minhaIdade = i;
        }

        public string Nome
        {
            get { return meuNome; }
        }

        public int Idade
        {
            get { return minhaIdade; }
            set { minhaIdade = value; }
        }

        public int CompareTo(Pessoa outro)
        {
            return meuNome.CompareTo(outro.meuNome);
            //return this.Idade - outro.Idade;
        }



        public override string ToString()
        {
            return Nome + "/" + Idade;
        }

        #region comparadores
        public static IComparer<Pessoa> getComparadorNome()
        {
            return new ComparadorNomePessoa();
        }

        public static IComparer<Pessoa> getComparadorIdade()
        {
            return new ComparadorIdadePessoa();
        }


        private class ComparadorNomePessoa : IComparer<Pessoa>
        {
            public int Compare(Pessoa p1, Pessoa p2)
            {
                return p1.Nome.CompareTo(p2.Nome);
            }
        }

        private class ComparadorIdadePessoa : IComparer<Pessoa>
        {
            public int Compare(Pessoa p1, Pessoa p2)
            {
                return p1.Idade - p2.Idade;
            }
        }
        #endregion
    }
}
