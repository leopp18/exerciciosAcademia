using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;

namespace Exercicios06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*EXERCICIO 1
            List<string> nomes = new List<string>();
            string nome;
            do
            {
                Console.WriteLine("Digite um nome a ser inserido ou 'sair':");
                nome = Console.ReadLine().ToUpper();
                string[] verificaNome = nome.Split(" ");

                if (nome == "SAIR")
                {
                    break;
                }

                if (nomes.Contains(nome))
                {
                    Console.WriteLine("Nome já cadastrado!");
                }else if(verificaNome.Length < 2)
                {
                    Console.WriteLine("Insira pelo menos dois nomes!");
                }
                else
                {
                    nomes.Add(nome);
                }
            } while(true);
            nomes.Sort();
            Console.WriteLine("\n*LISTA ORDENADA*");
            foreach(var item in nomes)
            {
                Console.WriteLine(item);
            }

            EXERCICIO 2
            Random rd = new Random();
            List<int> numeros= new List<int>();
            int quantidade;
            Console.WriteLine("Quantos números deseja sortear?");
            quantidade = int.Parse(Console.ReadLine());
            for(int i = 0; i < quantidade; i++)
            {
                numeros.Add(rd.Next(0,1000));
            }
            Console.WriteLine("NÚMEROS SORTEADOS:");
            foreach(var item in numeros)
            {
                Console.WriteLine(item);
            }

            EXERCICIO 3
            int op;
            List<string> emails = new List<string>();
            List<string> dominios = new List<string>();
            String email;
            String[] dominio;

            while (true)
            {
                Console.WriteLine("\n\nMENU DE OPÇÕES:");
                Console.WriteLine("[1] Cadastrar e-mail");
                Console.WriteLine("[2] Listar e-mail");
                Console.WriteLine("[3] Sair");
                Console.WriteLine("\nInsira a opção:");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Console.WriteLine("Insira o e-mail:");
                        email = Console.ReadLine().ToLower();
                        if (emails.Contains(email))
                        {
                            Console.WriteLine("E-mail já cadastrado.");
                        }
                        else
                        {   
                            emails.Add(email);
                            dominio = email.Split("@");
                            dominios.Add(dominio[1]);
                            Array.Clear(dominio, 0, dominio.Length);//limpa array
                            dominios = dominios.Distinct().ToList();//exclui repetidos
                        }
                        break;
                    case 2:
                        Console.WriteLine("LISTA DE E-MAILS:");
                        foreach(var item in emails)
                        {
                            Console.WriteLine(item);
                        }
                        Console.WriteLine("\nLISTA DE DOMINIOS");
                        foreach (var item in dominios)
                        {
                            Console.WriteLine(item);
                        }
                        break;
                    case 3:
                        Console.WriteLine("Encerrando aplicação!");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }

            int op;
            List<string> criptos = new List<string>();
            String cripto;

            while (true)
            {
                Console.WriteLine("\n\nMENU DE OPÇÕES:");
                Console.WriteLine("[1] Cadastrar criptomoeda");
                Console.WriteLine("[2] Listar criptomoedas");
                Console.WriteLine("[3] Remover criptomoeda");
                Console.WriteLine("[4] Sair");
                Console.WriteLine("\nInsira a opção:");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Console.WriteLine("Insira a criptomoeda:");
                        cripto = Console.ReadLine().ToUpper();
                        if (criptos.Contains(cripto))
                        {
                            Console.WriteLine("Criptomoeda já cadastrada.");
                        }
                        else
                        {
                            criptos.Add(cripto);
                        }
                        break;
                    case 2:
                        Console.WriteLine("LISTA DE CRIPTOMOEDAS:");
                        criptos.Sort();
                        foreach (var item in criptos)
                        {
                            Console.WriteLine(item);
                        }
                        break;
                    case 3:
                        Console.WriteLine("Digite a criptomoeda a ser removida:");
                        cripto = Console.ReadLine().ToUpper();
                        if (criptos.Contains(cripto))
                        {
                            criptos.Remove(cripto);
                            Console.WriteLine("Criptomoeda removida com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("Criptomoeda não encontrada.");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Encerrando aplicação!");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }

            EXERCICIO 5
            Random rd = new Random();
            List<int> numeros = new List<int>();
            List<int> numeros2 = new List<int>();
            List<int> comuns = new List<int>();
            int quantidade;
            Console.WriteLine("Quantos números deseja sortear?");
            quantidade = int.Parse(Console.ReadLine());
            for (int i = 0; i < quantidade; i++)
            {
                numeros.Add(rd.Next(100, 200));
            }
            for (int i = 0; i < quantidade; i++)
            {
                numeros2.Add(rd.Next(100, 200));
            }
            Console.WriteLine("NÚMEROS SORTEADOS PARA A LISTA 1:");
            foreach (var item in numeros)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\nNÚMEROS SORTEADOS PARA A LISTA 2:");
            foreach (var item in numeros2)
            {
                Console.WriteLine(item);
            }
            for(int i = 0; i < quantidade; i++)
            {
                if (numeros.Contains(numeros2[i]))
                {
                    comuns.Add(numeros2[i]);
                }
            }
            comuns = comuns.Distinct().ToList();
            Console.WriteLine("\nNÚMEROS COMUNS A AMBAS AS LISTAS:");
            foreach (var item in comuns)
            {
                Console.WriteLine(item);
            }*/

            List<string> nomes = new List<string>();
            List<string> sobrenomes = new List<string>();
            List<string> familia = new List<string>();
            List<string> nomesSeparados = new List<string>();
            string nome;
            string[] verificaNome;
            do
            {
                Console.WriteLine("Digite um nome a ser inserido ou 'sair':");
                nome = Console.ReadLine().ToUpper();
                verificaNome = nome.Split(" ");
                for(int i = 0; i < verificaNome.Length; i++)
                {
                    nomesSeparados.Add(verificaNome[i]);
                }

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
                }
            } while (true);
            for (int i = 1; i < nomesSeparados.Count; i++)
            {
                sobrenomes.Add(nomesSeparados[i]);
                i++;
            }
            for (int i = 0; i < sobrenomes.Count; i++)
            {
                for (int j = 0; j < sobrenomes.Count; j++)
                {
                    if (sobrenomes[i] == sobrenomes[j])
                    {
                        familia.Add(nomes[i]);
                    }
                }
            }
            sobrenomes.Sort();
            Console.WriteLine("\n*LISTA ORDENADA*");
            foreach (var item in sobrenomes)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n*PESSOAS DA MESMA FAMÍLIA*");
            foreach (var item in familia)
            {
                Console.WriteLine(item);
            }
            foreach (var item in nomes)
            {
                Console.WriteLine(item);
            }
        }

    }
}