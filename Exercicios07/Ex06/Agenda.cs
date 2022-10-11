using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista07_Ex06
{
    internal class Agenda
    {
        List<string> nomes = new List<string>();
        List<int> idades = new List<int>();
        List<float> alturas = new List<float>();

        public void armazenaPessoa(String nome, int idade, float altura)
        {
            nomes.Add(nome);
            idades.Add(idade);
            alturas.Add(altura);
        }
        public void removePessoa(String nome)
        {
            int ind = -1;
            for(int i = 0; i < nomes.Count; i++)
            {
                if(nomes[i] == nome)
                {
                    ind = i;
                }
            }
            nomes.Remove(nome);
            idades.RemoveAt(ind);
            alturas.RemoveAt(ind);
        }
        public void buscaPessoa(String nome)
        {
            for (int i = 0; i < nomes.Count; i++)
            {
                if (nomes[i] == nome)
                {
                    Console.WriteLine("Nome: " + nomes[i]);
                    Console.WriteLine("Idade: " + idades[i]);
                    Console.WriteLine("Altura: " + alturas[i]);
                }
            }
        }
        public void imprimeAgenda()
        {
            for (int i = 0; i < nomes.Count; i++)
            {
                Console.WriteLine("Nome: " + nomes[i]);
                Console.WriteLine("Idade: " + idades[i]);
                Console.WriteLine("Altura: " + alturas[i]);
            }
        }
    }
}
