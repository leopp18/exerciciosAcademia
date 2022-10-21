using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista09_Ex01
{
    internal class Pessoa
    {
        private string nome;
        private string nomeArquivo = @"C:\Users\leopp\OneDrive\Área de Trabalho\Atos\Lista09-Ex01\Lista09-Ex01\nomes.csv";
        List<string> nomes = new List<string>();

        public Pessoa()
        {
        }

        public string Nome { get => nome; set => nome = value; }

        public void leArquivo()
        {
            string linha = "";
            StreamReader sr = new StreamReader(nomeArquivo);
            while ((linha = sr.ReadLine()) != null)
            {
                string[] separaNome = linha.Split("; ");
                for (int i = 0; i < separaNome.Length; i++)
                {
                    nomes.Add(separaNome[i]);
                }
            }
            sr.Close();
        }

        public void escreveArquivo(string texto)
        {
            StreamWriter sw = new StreamWriter(nomeArquivo, append: true);
            sw.Write(texto);
            sw.Flush();
            sw.Close();
        }


        public void menu()
        {
            while (true)
            {
                Console.WriteLine("Insira um nome completo para ser cadastrado, ou 'SAIR' para encerrar a aplicação:");
                nome = Console.ReadLine().ToUpper();
                string[] verificaNome = nome.Split(" ");
                if (nome == "SAIR")
                {
                    break;
                }
                if (nomes.Contains(nome))
                {
                    Console.WriteLine("Nome já cadastrado!");
                }
                else if (verificaNome.Length < 2)
                {
                    Console.WriteLine("Insira pelo menos dois nomes!");
                }
                else
                {
                    nomes.Add(nome);
                    escreveArquivo(nome + "; ");
                }
                nomes.Sort();
                Console.WriteLine("\n*LISTA ORDENADA*");
                foreach (var item in nomes)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
