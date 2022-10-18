using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista08_Ex02
{
    internal class Animal
    {
        private string nome;
        private string tipo;
        //private int gato = 0;
        //private int cao = 0;
        //private int peixe = 0;

        public Animal(string nome, string tipo)
        {
            this.nome = nome;
            this.tipo = tipo;
        }

        //public void aumentaPeixe()
        //{
        //    peixe++;
        //}
        //public void aumentaGato()
        //{
        //    gato++;
        //}
        //public void aumentaCao()
        //{
        //    cao++;
        //}

        //public int getPeixe()
        //{
        //    return peixe;
        //}
        //public int getCao()
        //{
        //    return cao;
        //}
        //public int getGato()
        //{
        //    return gato;
        //}
        public void exibeDados()
        {
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Tipo: " + tipo);
        }

    }
}
