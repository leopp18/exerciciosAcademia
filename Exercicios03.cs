using System.Xml;

namespace Exercicios03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* EXERCICIO 1 e 2
            int valor = -1;
            char informe = 's';
            while (informe == 's')
            {
                Console.WriteLine("Digite um valor positivo:");
                valor = int.Parse(Console.ReadLine());
                while (valor < 0)
                {
                    Console.WriteLine("Digite um valor positivo:");
                    valor = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("Números pares entre 1 e o valor digitado: ");
                for (int i = 1; i < valor; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
                Console.WriteLine("Deseja informar outro número? (s/n)");
                informe = char.Parse(Console.ReadLine());
            }

            EXERCICIO 3
            int valor = 1;
            int divisores = 0;
            while(valor != 0)
            {
                Console.WriteLine("Digite um valor inteiro:");
                valor = int.Parse(Console.ReadLine());
                divisores = 0;
                if(valor %2 == 0)
                {
                    Console.WriteLine("O número é par.");
                }
                else
                {
                    Console.WriteLine("O número é ímpar.");
                }
                for(int i = 1; i <= valor; i++)
                {
                    if(valor % i == 0)
                    {
                        divisores++;
                    }
                }
                if(divisores == 2)
                {
                    Console.WriteLine("O número é primo");
                }
            }

            EXERCICIO 4 e 5
            int joao = 0, zeca = 0, branco = 0, nulos = 0;
            string palavra = "";
            while(palavra != "FIM")
            {
                Console.WriteLine("Insira seu voto:");
                palavra = Console.ReadLine();
                palavra = palavra.ToUpper();
                if (palavra == "JOAO")
                {
                    joao++;
                    Console.WriteLine("Voto computado.\n");
                }else if(palavra == "ZECA")
                {
                    zeca++;
                    Console.WriteLine("Voto computado.\n");
                }
                else if(palavra == "BRANCO")
                {
                    branco++;
                    Console.WriteLine("Voto computado.\n");
                }else if(palavra == "FIM")
                {
                    Console.WriteLine("Encerrando...\n");
                }
                else
                {
                    nulos++;
                    Console.WriteLine("Voto nulo.\n");
                }
            }
            Console.WriteLine("Votos no Zeca: " + zeca);
            Console.WriteLine("Votos no João: " + joao);
            Console.WriteLine("Votos em branco: " + branco);
            Console.WriteLine("Votos nulos: " + nulos);
            Console.WriteLine("Total de votos: " + (zeca + joao + branco + nulos));
            if(zeca > joao)
            {
                Console.WriteLine("PREFEITO ELEITO: ZECA");
            } else if(zeca < joao)
            {
                Console.WriteLine("PREFEITO ELEITO: JOÃO");
            }
            else
            {
                Console.WriteLine("Votação anulada.");
            }

            EXERCICIO 6
            int idade = 0;
            while(idade < 1)
            {
                Console.WriteLine("Informe a idade: ");
                idade = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Idade informada: " + idade);

            EXERCICIO 7
            string nome = "";
            int idade = 0;
            double salario = 0;
            Console.WriteLine("Digite o nome:");
            nome = Console.ReadLine();
            if(string.IsNullOrWhiteSpace(nome) == true || nome.Any(char.IsDigit) == true)
            {
                Console.WriteLine("Nome incorreto.");
                Environment.Exit(1);
            }
            Console.WriteLine("Informe a idade: ");
            idade = int.Parse(Console.ReadLine());
            if(idade < 1)
            {
                Console.WriteLine("Idade incorreta.");
                Environment.Exit(1);
            }
            Console.WriteLine("Informe o salário: ");
            salario = double.Parse(Console.ReadLine());
            if(salario < 1)
            {
                Console.WriteLine("Salário incorreto.");
                Environment.Exit(1);
            }
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Idade: " + idade);
            Console.WriteLine("Salário: " + salario); 


            EXERCICIO 8 
            double numero = 1.5;
            char repete;
            while (numero % 2 != 0 || numero % 2 != 1)
            {
                Console.WriteLine("Insira um número inteiro:");
                numero = double.Parse(Console.ReadLine());
                if(numero % 2 == 0 || numero % 2 == 1)
                {
                    if(numero % 2 == 0)
                    {
                        Console.WriteLine("É par.");
                    }
                    else
                    {
                        Console.WriteLine("É ímpar.");
                    }
                    Console.WriteLine("Deseja repetir o programa? (s/n)");
                    repete = char.Parse(Console.ReadLine());
                    if(repete == 's' || repete == 'S')
                    {
                        numero = 1.5;
                    }
                    else
                    {
                        Environment.Exit(1);
                    }
                }
            }

            EXERCICIO 9
            int filhos, filhos1a3 = 0, filhos4a7 = 0, filhos8 = 0, filhos0 = 0;
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite quantos filhos você tem:");
                filhos = int.Parse(Console.ReadLine());
                if (filhos == 0)
                {
                    filhos0++;
                }else if (filhos >=1 && filhos <= 3)
                {
                    filhos1a3++;
                }
                else if (filhos >= 4 && filhos <= 7)
                {
                    filhos4a7++;
                }
                else if (filhos >= 8)
                {
                    filhos8++;
                }
            }
            Console.WriteLine("Pessoas com 1 a 3 filhos: " + filhos1a3);
            Console.WriteLine("Pessoas com 4 a 7 filhos: " + filhos4a7);
            Console.WriteLine("Pessoas com 8 filhos ou mais: " + filhos8);
            Console.WriteLine("Pessoas sem filhos: " + filhos0);

            EXERCICIO 10
            int idade;
            string nome, genero;
            int masc = 0, fem = 0, idade30 = 0, idade60 = 0, totalfem = 0;
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite seu nome:");
                nome = Console.ReadLine();
                Console.WriteLine("Digite sua idade:");
                idade = int.Parse(Console.ReadLine());
                if(idade > 60)
                {
                    idade60++;
                }else if (idade < 30)
                {
                    idade30++;
                }
                Console.WriteLine("Digite seu genero: (m/f)");
                genero = Console.ReadLine();
                genero = genero.ToUpper();
                if (genero == "M")
                {
                    masc++;
                } else if (genero == "F")
                {
                    fem++;
                    totalfem += idade;
                }
            }
            Console.WriteLine("Número de homens: " + masc);
            Console.WriteLine("Número de mulheres: " + fem);
            Console.WriteLine("Número de pessoas com idade inferior a 30: " + idade30);
            Console.WriteLine("Número de pessoas com idade superior a 60: " + idade60);
            Console.WriteLine("Média de idade das mulheres: " + (totalfem / fem)); 

            EXERCICIO 11
            int alunos = 0;
            float maior = 0, menor = 999, nota = 0, notasTotal = 0, aux;
            while(nota >= 0)
            {
                aux = nota;
                Console.WriteLine("Insira uma nota:");
                nota = float.Parse(Console.ReadLine());
                if(nota == -1)
                {
                    break;
                }
                if(maior < nota)
                {
                    maior = nota;
                }
                if (menor > nota)
                {
                    menor = nota;
                }
                notasTotal += nota;
                alunos++;
            }
            Console.WriteLine("Maior nota: " + maior);
            Console.WriteLine("Menor nota: " + menor);
            Console.WriteLine("Média da turma: " + (notasTotal / alunos));
            Console.WriteLine("Quantidade de alunos: " + alunos);

            EXERCICIO 12
            int soma = 0;
            for (int i = 1; i <= 100; i++) //sem considerar o 0
            {
                soma += i;
            }
            Console.WriteLine("Soma: " + soma); 

            EXERCICIO 13
            int soma = 0;
            for (int i = 1; i < 500; i++)
            {   
                if(i % 2 == 0)
                {
                    soma += i;
                }
            }
            Console.WriteLine("Soma: " + soma); 

            EXERCICIO 14
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Potência de 2 elevado na " + i + ": " + Math.Pow(2,i));
            }

            EXERCICIO 15
            float nota1, nota2, nota3, nota4, media;
            Console.WriteLine("Insira a nota 1: ");
            nota1 = float.Parse(Console.ReadLine()) * 2;
            Console.WriteLine("Insira a nota 2: ");
            nota2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Insira a nota 3: ");
            nota3 = float.Parse(Console.ReadLine()) * 2;
            Console.WriteLine("Insira a nota 4: ");
            nota4 = float.Parse(Console.ReadLine()) * 4;
            media = (nota1 + nota2 + nota3 + nota4) / 9;
            if (media >= 7)
            {
                Console.WriteLine("Aprovado.");
            }
            else
            {
                Console.WriteLine("Reprovado.");
            }

            EXERCICIO 16
            double n, produto = 0;
            Console.WriteLine("Insira o valor de n:");
            n = double.Parse(Console.ReadLine());
            for (int i = 1; produto < 250; i++)
            {
                produto = n * Math.Pow(3, i);
                Console.WriteLine("Multiplicação sucessiva de N * 3 (caso " + i + "): " + produto);
                produto = n * Math.Pow(3, i + 1);
            }

            EXERCICIO 17
            for (int i = 15; i <= 20; i++)
            {
                Console.WriteLine("Quadrado de " + i + ": " + Math.Pow(i, 2));
            }

            EXERCICIO 18
            int n, m;
            Console.WriteLine("Insira o valor de n:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor de m:");
            m = int.Parse(Console.ReadLine());
            Console.WriteLine("Potência de " + n + " elevado na " + m + ": " + Math.Pow(n, m));

            EXERCICIO 19
            double salario = 0, salarioTotal = 0, maior = 0, salario100 = 00;
            int filhos = 0, habitantes = 0;
            while(salario >= 0)
            {
                Console.WriteLine("Digite seu salário:");
                salario = double.Parse(Console.ReadLine());
                if (salario < 0)
                {
                    break;
                }
                if (maior < salario)
                {
                    maior = salario;
                }
                if(salario <= 100)
                {
                    salario100++;
                }
                salarioTotal += salario;
                Console.WriteLine("Digite quantos filhos possui:");
                filhos += int.Parse(Console.ReadLine());
                habitantes++;
            }
            Console.WriteLine("Média de salário: R$" + (salarioTotal / habitantes));
            Console.WriteLine("Média de filhos: " + (filhos / habitantes));
            Console.WriteLine("Maior salário: " + maior);
            Console.WriteLine("Percentual de pessoas com salário até R$100,00: " + ((salario100 * 100) / habitantes) + "%");

            EXERCICIO 20
            int idade, maior = 0, mulheres = 0;
            char genero, cabelo, olhos;
            do
            {
                Console.WriteLine("Digite sua idade:");
                idade = int.Parse(Console.ReadLine());
                if (idade < 0)
                {
                    break;
                }
                if (maior < idade)
                {
                    maior = idade;
                }
                Console.WriteLine("Digite seu gênero: (m/f)");
                genero = char.Parse(Console.ReadLine());
                Console.WriteLine("Digite a cor dos olhos: (v/a/c)");
                olhos = char.Parse(Console.ReadLine());
                Console.WriteLine("Digite a cor dos cabelos: (l/c/p)");
                cabelo = char.Parse(Console.ReadLine());
                if (genero == 'f' && idade >= 18 && idade <= 35 && olhos == 'v' && cabelo == 'l')
                {
                    mulheres++;
                }
            } while (idade >= 0);
            Console.WriteLine("A maior idade entre os habitantes: " + maior);
            Console.WriteLine("Mulheres com idade entre 18 e 35, olhos verdes e cabelos louros: " + mulheres); */
        }
    }
}