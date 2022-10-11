using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista07Ex03
{
    internal class Aluguel
    {
        public DateTime inicio;
        public DateTime termino;
        public double valorDiaria;
        public bool seguro;
        public Carro carro;
        public Cliente cliente;

        public void exibeAluguel()
        {
            Console.WriteLine("\nDADOS DO ALUGUEL: ");
            Console.WriteLine("Momento de início: " + inicio);
            Console.WriteLine("Momento de término: " + termino);
            Console.WriteLine("Valor da diária: " + valorDiaria);
            Console.WriteLine("Possui seguro: " + seguro);
        }
    }
}
