using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista09_Ex02
{
    internal class Arquivo
    {
        private string email;
        private string nomeArquivo = @"C:\Users\leopp\OneDrive\Área de Trabalho\Atos\Lista09-Ex02\Lista09-Ex02\emails.csv";

        public Arquivo()
        {
        }
        public void leArquivo(List<string> emails, List<string> dominios)
        {
            string[] pegaDominio = null;
            string linha = "";
            try
            {
                StreamReader sr = new StreamReader(nomeArquivo);
                while ((linha = sr.ReadLine()) != null)
                {
                    string[] separaEmail = linha.Split(";");
                    for (int i = 0; i < separaEmail.Length -1; i++)
                    {
                        emails.Add(separaEmail[i]);
                        pegaDominio = separaEmail[i].Split("@");
                        dominios.Add(pegaDominio[1]);
                    }
                }
                sr.Close();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Arquivo não encontrado.");
            }
        }

        public void escreveArquivo(string texto)
        {
            StreamWriter sw = new StreamWriter(nomeArquivo, append: true);
            sw.Write(texto);
            sw.Flush();
            sw.Close();
        }
    }
}
