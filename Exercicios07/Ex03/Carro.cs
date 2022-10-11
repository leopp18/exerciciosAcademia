using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Lista07Ex03
{
    internal class Carro
    {
        private string modelo;
        private string marca;
        private int ano;

        public Carro()
        {
        }

        public void pedirCarro()
        {
            Console.WriteLine("\nInsira o modelo do carro a ser alugado:");
            modelo = Console.ReadLine();
            Console.WriteLine("Insira a marca do carro a ser alugado:");
            marca = Console.ReadLine();
            Console.WriteLine("Insira o ano de fabricação do carro:");
            ano = int.Parse(Console.ReadLine());
        }
        public void exibeCarro()
        {
            Console.WriteLine("\nDADOS DO CARRO:");
            Console.WriteLine("Modelo: " + modelo);
            Console.WriteLine("Marca: " + marca);
            Console.WriteLine("Ano de fabricaçao: " + ano);
        }
    }
}
