using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista08_Ex01
{
    internal class Personagens
    {
        protected string nome;
        protected int poder;
        public Personagens(string nome, int poder)
        {
            this.nome = nome;
            this.poder = poder;
        }
        public int getPoder()
        {
            return poder;
        }
        public string getNome()
        {
            return nome;
        }
        public virtual void exibeDados()
        {
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Poder: " + poder);
            Console.WriteLine();
        }


    }
}
