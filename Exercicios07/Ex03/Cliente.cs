using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lista07Ex03
{
    internal class Cliente
    {
        private string nome;
        private string dataNasc;
        private string cpf;

        public Cliente(string nome, string dataNasc, string cpf)
        {
            this.nome = nome;
            this.dataNasc = dataNasc;
            this.cpf = cpf;
        }
        public Cliente()
        {
        }
        public void pedirDados()
        {
            Console.WriteLine("\nInsira o nome do cliente:");
            nome = Console.ReadLine();
            Console.WriteLine("Insira a data de nascimento do cliente:");
            dataNasc = Console.ReadLine();
            Console.WriteLine("Insira o CPF do cliente:");
            cpf = Console.ReadLine();
        }
        public void exibeCliente()
        {
            Console.WriteLine("\nDADOS DO CLIENTE:");
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Data de nascimento: " + dataNasc);
            Console.WriteLine("CPF: " + cpf);
        }
    }
}
