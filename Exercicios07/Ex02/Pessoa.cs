using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista07_Ex02
{
    internal class Pessoa
    {
        private string nome;
        private int idade;
        private int altura;

        public Pessoa(string nome, int idade, int altura)
        {
            this.nome = nome;
            this.idade = idade;
            this.altura = altura;
        }
        public void exibirDados()
        {
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Idade: " + idade);
            Console.WriteLine("Altura: " + altura);
        }
    }
}
