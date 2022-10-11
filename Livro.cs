using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista07_Ex01
{
    internal class Livro
    {
        private string nome;
        private string autor;
        private int ano;

        public Livro(string nome, string autor, int ano)
        {
            this.nome = nome;
            this.autor = autor;
            this.ano = ano;
        }

        public void exibirDados()
        {
            Console.WriteLine("Título: " + nome);
            Console.WriteLine("Autor: " + autor);
            Console.WriteLine("Ano: " + ano);
        }
    }
}
