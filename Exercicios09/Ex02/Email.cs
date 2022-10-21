using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista09_Ex02
{
    internal class Email
    {
        string email = "";
        List<string> dominios = new List<string>();
        List<string> emails = new List<string>();
        Arquivo arq = new Arquivo();

        public void populaLista()
        {
            arq.leArquivo(emails, dominios);
            //foreach (string email in emails)
            //{
            //    string[] pegaDominio = email.Split("@");
            //    dominios.Add(pegaDominio[1]);
            //}
        }
        public void pedeEmail()
        {
            Console.WriteLine("\nInsira um e-mail para ser cadastrado, ou 'SAIR' para encerrar a aplicação:");
            email = Console.ReadLine().ToLower();
            if (emails.Contains(email))
            {
                Console.WriteLine("E-mail já cadastrado!");
            }
            else
            {
                emails.Add(email);
                arq.escreveArquivo(email + "; ");
            }
        }

        public void pegaDominio()
        {
            string[] pegaDominio = email.Split("@");
            if (!dominios.Contains(pegaDominio[1]))
            {
                dominios.Add(pegaDominio[1]);
            }
        }

        public void exibeListas()
        {
            dominios = dominios.Distinct().ToList();
            if (emails.Count == 0)
            {
                Console.WriteLine("Lista vazia! Nenhum e-mail inserido.");
            }
            else
            {
                emails.Sort();
                dominios.Sort();
                Console.WriteLine("\n*LISTA ORDENADA*");
                foreach (var item in emails)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("\n*LISTA DE DOMÍNIOS*");
                foreach (var item in dominios)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
