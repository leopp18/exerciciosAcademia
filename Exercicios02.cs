using System.Globalization;
using System.IO.IsolatedStorage;

namespace Exercicios02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*EXERCICIO 1
            int bas, altura;
            Console.WriteLine("Insira a base do triângulo:");
            bas = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira a altura do triângulo:");
            altura = int.Parse(Console.ReadLine());
            if (bas != 0 && altura != 0)
            {
                Console.WriteLine("Área do triangulo = " + (bas * altura) / 2);
            } else
            {
                Console.WriteLine("Nenhum dos valores pode ser zero.");
            }

            EXERCICIO 2
            int num;
            Console.WriteLine("Insira um número");
            num = int.Parse(Console.ReadLine());
            if(num % 2 == 0)
            {
                Console.WriteLine("É par");
            }else
            {
                Console.WriteLine("É ímpar");
            }

            EXERCICIO 3
            float a, b, c, d, media;
            Console.WriteLine("Insira o valor de A:");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor de B:");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor de C:");
            c = float.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor de D:");
            d = float.Parse(Console.ReadLine());
            media = (a + b + c + d) / 4;
            Console.WriteLine("Os valores maiores que a média são:");
            if(a > media)
            {
                Console.WriteLine("A: " + a);
            }
            if (b > media)
            {
                Console.WriteLine("B: " + b);
            }
            if (c > media)
            {
                Console.WriteLine("C: " + c);
            }
            if (d > media)
            {
                Console.WriteLine("D: " + d);
            }

            EXERCICIO 4
            float valor1, horas1, valor2, horas2, prof1, prof2;
            Console.WriteLine("Insira a quantidade de horas de aula do primeiro professor:");
            horas1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor pago por hora do primeiro professor:");
            valor1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Insira a quantidade de horas de aula do segundo professor:");
            horas2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor pago por hora do segundo professor:");
            valor2 = float.Parse(Console.ReadLine());
            prof1 = valor1 * horas1;
            prof2 = valor2 * horas2;
            if (prof1 == prof2)
            {
                Console.WriteLine("Salarios iguais.");
            } else if(prof1 > prof2)
            {
                Console.WriteLine("O professor 1 tem salário maior");
            } else
            {
                Console.WriteLine("O professor 2 tem salário maior");
            }

            EXERCICIO 5
            float n1, n2, media, n3;
            Console.WriteLine("Insira a nota 1:");
            n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Insira a nota 2:");
            n2 = float.Parse(Console.ReadLine());
            media = (n1 + n2) / 2;
            if (media >= 7)
            {
                Console.WriteLine("Aprovado.");
            }
            else 
            {
                Console.WriteLine("Insira a nota do exame:");
                n3 = float.Parse(Console.ReadLine());
                if((n3 + media) / 2 >= 5)
                {
                    Console.WriteLine("Aprovado.");
                }
                else
                {
                    Console.WriteLine("Reprovado.");
                }
            }

            EXERCICIO 6
            string nome;
            float altura, peso, imc;
            Console.WriteLine("Insira seu nome:");
            nome = Console.ReadLine();
            nome = nome.ToUpper();
            Console.WriteLine("Insira sua altura:");
            altura = float.Parse(Console.ReadLine());
            Console.WriteLine("Insira seu peso:");
            peso = float.Parse(Console.ReadLine());

            imc = peso / (altura * altura);
            if(imc < 18)
            {
                Console.WriteLine("Baixo peso");
            } else if(imc >= 18 && imc < 25)
            {
                Console.WriteLine("Peso normal");
            } else if (imc >= 25 && imc < 30)
            {
                Console.WriteLine("Sobrepeso");
            }
            else if (imc >= 30 && imc < 35)
            {
                Console.WriteLine("Sobrepeso");
            }
            else
            {
                Console.WriteLine("Obesidade grau sério");
            }

            EXERCICIO 7
            string frase = "";
            string palavra = "";
            Console.WriteLine("Digite uma frase:");
            frase = Console.ReadLine();
            Console.WriteLine("Digite uma palavra:");
            palavra = Console.ReadLine();

            if (frase.Contains(palavra))
            {
                Console.WriteLine("A palavra encontra-se na frase!");
            }
            else
            {
                Console.WriteLine("A palavra não se encontra na frase!");
            }

            EXERCICIO 8
            int num;
            string nome = "";
            double salario, totalVendas;
            Console.WriteLine("Insira o código do vendedor:");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o nome do vendedor:");
            nome = Console.ReadLine();
            Console.WriteLine("Insira o salário base deste vendedor:");
            salario = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira o total de vendas:");
            totalVendas = double.Parse(Console.ReadLine());

            if (totalVendas > 5000)
            {
                salario += totalVendas * 0.1;
                Console.WriteLine("Salario total: " + salario);
            } else if(totalVendas > 1000)
            {
                salario += totalVendas * 0.07;
                Console.WriteLine("Salario total: " + salario);
            }
            else if (totalVendas > 500)
            {
                salario += totalVendas * 0.05;
                Console.WriteLine("Salario total: " + salario);
            }
            else
            {
                Console.WriteLine("Sem comissão");
            }

            EXERCICIO 9
            float v1, v2, v3, media;
            Console.WriteLine("Digite o primeiro valor de glicemia aferido:");
            v1 = float.Parse(Console.ReadLine());
            if(v1 < 65)
            {
                Console.WriteLine("Risco de hipoglicemia!");
            } else if (v1 > 250)
            {
                Console.WriteLine("Risco de hiperglicemia!");
            }
            else{}
            Console.WriteLine("Digite o segundo valor de glicemia aferido:");
            v2 = float.Parse(Console.ReadLine());
            if (v2 < 65)
            {
                Console.WriteLine("Risco de hipoglicemia!");
            }
            else if (v2 > 250)
            {
                Console.WriteLine("Risco de hiperglicemia!");
            }
            else { }
            Console.WriteLine("Digite o terceiro valor de glicemia aferido:");
            v3 = float.Parse(Console.ReadLine());
            if (v3 < 65)
            {
                Console.WriteLine("Risco de hipoglicemia!");
            }
            else if (v3 > 250)
            {
                Console.WriteLine("Risco de hiperglicemia!");
            }
            else { }
            media = (v1 + v2 + v3) / 3;
            if (media < 80)
            {
                Console.WriteLine("Diminua 2 unidades de insulina!");
            }
            else if (media > 150)
            {
                Console.WriteLine("Adicione 2 unidades de insulina!");
            }
            else { }

            EXERCICIO 10
            string nome1, nome2;
            int idade1, idade2;
            float altura1, altura2;

            Console.WriteLine("Insira o nome do primeiro atleta:");
            nome1 = Console.ReadLine();
            Console.WriteLine("Insira a idade do primeiro atleta:");
            idade1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira a altura do primeiro atleta:");
            altura1 = float.Parse(Console.ReadLine());
            Console.WriteLine("\nInsira o nome do segundo atleta:");
            nome2 = Console.ReadLine();
            Console.WriteLine("Insira a idade do segundo atleta:");
            idade2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira a altura do segundo atleta:");
            altura2 = float.Parse(Console.ReadLine());

            if(idade1 < idade2)
            {
                Console.WriteLine("\nO atleta 1 é o mais novo.");
                Console.WriteLine("Nome: " + nome1);
                Console.WriteLine("Idade: " + idade1);
                Console.WriteLine("Altura: " + altura1);
                if(altura1 > altura2)
                {
                    Console.WriteLine("O atleta 1 também é o mais alto.");
                }
                else
                {
                    Console.WriteLine("\nO atleta 2 é o mais alto");
                    Console.WriteLine("Nome: " + nome2);
                    Console.WriteLine("Idade: " + idade2);
                    Console.WriteLine("Altura: " + altura2);
                }
            }else if (idade1 == idade2)
            {
                Console.WriteLine("\nOs atletas têm a mesma idade.");
                if (altura2 > altura1)
                {
                    Console.WriteLine("O atleta 2 é o mais alto.");
                    Console.WriteLine("Nome: " + nome2);
                    Console.WriteLine("Idade: " + idade2);
                    Console.WriteLine("Altura: " + altura2);
                }
                else
                {
                    Console.WriteLine("O atleta 1 é o mais alto");
                    Console.WriteLine("Nome: " + nome1);
                    Console.WriteLine("Idade: " + idade1);
                    Console.WriteLine("Altura: " + altura1);
                }
            }
            else
            {
                Console.WriteLine("\nO atleta 2 é o mais novo");
                Console.WriteLine("Nome: " + nome2);
                Console.WriteLine("Idade: " + idade2);
                Console.WriteLine("Altura: " + altura2);
                if (altura2 > altura1)
                {
                    Console.WriteLine("O atleta 2 também é o mais alto.");
                }
                else
                {
                    Console.WriteLine("\nO atleta 1 é o mais alto");
                    Console.WriteLine("Nome: " + nome1);
                    Console.WriteLine("Idade: " + idade1);
                    Console.WriteLine("Altura: " + altura1);
                }
            }
            
            EXERCICIO 11
            int hora, min;
            Console.WriteLine("Insira o número de horas:");
            hora = int.Parse(Console.ReadLine());
            if(hora >= 0 && hora < 24)
            {
                Console.WriteLine("Insira o número de minutos:");
                min = int.Parse(Console.ReadLine());
                if(min >= 0 && min <= 59)
                {
                    Console.WriteLine("Horário inserido com sucesso.");
                }
                else
                {
                    Console.WriteLine("Quantidade de minutos inválida.");
                }
            }
            else
            {
                Console.WriteLine("Quantidade de horas inválida.");
            }

            EXERCICIO 12
            int codigo;
            float salario, extra = 0, horas, horasNormais;
            Console.WriteLine("Digite o código do operário:");
            codigo = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o numero de horas trabalhadas:");
            horas = float.Parse(Console.ReadLine());
            if(horas > 50)
            {
                horasNormais = 50;
                salario = horasNormais * 10;
                extra = horas - 50;
                extra = extra * 20;
                salario += extra;
            }
            else
            {
                salario = horas * 10;
            }
            Console.WriteLine("Salário total: " + salario);
            Console.WriteLine("Salário excedente: " + extra);

            EXERCICIO 13
            char gen;
            double altura, pesoH, pesoM;
            Console.WriteLine("Digite H se for homem ou M se for mulher:");
            gen = char.Parse(Console.ReadLine());
            Console.WriteLine("Insira sua altura:");
            altura = double.Parse(Console.ReadLine());

            pesoH = ((72.7 * altura) - 58);
            pesoM = ((62.1 * altura) - 44.7);
            pesoH = (double)Math.Round(pesoH, 2);
            pesoM = (double)Math.Round(pesoM, 2);

            gen = char.ToUpper(gen);
            if(gen == 'H')
            {
                Console.WriteLine("Peso ideal:" + pesoH);
            } else if(gen == 'M')
            {
                Console.WriteLine("Peso ideal:" + pesoM);
            }
            else
            {
                Console.WriteLine("Gênero não identificado."); 
            }

            EXERCICIO 14
            double mb, mbps, velocidade;
            Console.WriteLine("Insira a quantidade de Mb para download:");
            mb = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a velocidade de download:");
            mbps = double.Parse(Console.ReadLine());
            velocidade = (mb / mbps) / 60;
            velocidade = (double)Math.Round(velocidade, 2);
            Console.WriteLine("Tempo de dowload em minutos:" + velocidade ); 

            EXERCICIO 15
            double tamanho, quantidade;
            Console.WriteLine("Insira a área a ser pintada: ");
            tamanho = double.Parse(Console.ReadLine());
            quantidade = tamanho / 3;
            if(quantidade % 18 > 0)
            {
                quantidade -= quantidade % 18;
                quantidade = quantidade / 18;
                quantidade++;
            }
            else
            {
                quantidade = quantidade / 18;
            }
            quantidade = (double)Math.Round(quantidade, 2);
            Console.WriteLine("Quantidade de latas: " + quantidade);
            Console.WriteLine("Preço total: R$" + quantidade * 80);

            EXERCICIO 16
            int casa, fora, dif;
            Console.WriteLine("JOGO 1 - Informe a quantidade de gols do time 1:");
            casa = int.Parse(Console.ReadLine());
            Console.WriteLine("JOGO 1 - Informe a quantidade de gols do time 2:");
            fora = int.Parse(Console.ReadLine());
            dif = fora - casa;
            if (dif >= 2)
            {
                Console.WriteLine("Time 2 já classificado!");
            }
            else
            {
                Console.WriteLine("JOGO 2 - Informe a quantidade de gols do time 1:");
                casa = int.Parse(Console.ReadLine());
                Console.WriteLine("JOGO 2 - Informe a quantidade de gols do time 2:");
                fora = int.Parse(Console.ReadLine());
                dif = dif + (fora - casa);
                if (dif > 0)
                {
                    Console.WriteLine("Time 2 classificado!");
                }else if (dif == 0)
                {
                    Console.WriteLine("Penalidades máximas!!");
                }
                else{
                    Console.WriteLine("Time 1 classificado");
                }
            }

            EXERCICIO 17
            int a, b, c;
            Console.WriteLine("Digite o tamanho de a:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o tamanho de b:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o tamanho de c:");
            c = int.Parse(Console.ReadLine());
            if(((a + b) > c) && ((b + c) > a) && ((a+c) > b)){
                Console.WriteLine("É um triângulo.");
                if(a == b && b == c)
                {
                    Console.WriteLine("Ele é equilátero.");
                } else if(a == b || b == c || a == c)
                {
                    Console.WriteLine("Ele é isósceles.");
                }
                else
                {
                    Console.WriteLine("Ele é escaleno.");
                }
            }
            else
            {
                Console.WriteLine("Não é triângulo.");
            }

            EXERCICIO 18 E 19
            int a, b, c ;
            Console.WriteLine("Insira 3 valores diferentes.");
            Console.WriteLine("Digite o valor de a:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de b:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de c:");
            c = int.Parse(Console.ReadLine());
            if(a > b && a > c)
            {
                Console.WriteLine("O A é o maior");
                if(b > c)
                {
                    Console.WriteLine("Ordem crescente: " + c + ", " + b + ", " + a);
                }
                else
                {
                    Console.WriteLine("Ordem crescente: " + b + ", " + c + ", " + a);
                }
            } else if(b > a && b > c)
            {
                Console.WriteLine("O B é o maior");
                if (a > c)
                {
                    Console.WriteLine("Ordem crescente: " + c + ", " + a + ", " + b);
                }
                else
                {
                    Console.WriteLine("Ordem crescente: " + a + ", " + c + ", " + b);
                }
            }else if(c > a && c > b)
            {
                Console.WriteLine("O C é o maior");
                if (a > b)
                {
                    Console.WriteLine("Ordem crescente: " + b + ", " + a + ", " + c);
                }
                else
                {
                    Console.WriteLine("Ordem crescente: " + a + ", " + b + ", " + c);
                }
            }
            else
            {
                Console.WriteLine("Você inseriu valores iguais.");
            }

            EXERCÍCIO 20
            Random numAleatorio = new Random();
            int sorteado = numAleatorio.Next(1,21);
            int valor = 0;
            int vidas = 3;
            while (sorteado != valor && vidas > 0)
            {
                Console.WriteLine("Tente acertar um valor inteiro entre 1 e 20:");
                valor = int.Parse(Console.ReadLine());
                if (sorteado > valor)
                {
                    Console.WriteLine("É maior.");
                    vidas--;
                }
                else if (sorteado < valor)
                {
                    Console.WriteLine("É menor.");
                    vidas--;
                }
                else
                {
                    Console.WriteLine("Você acertou!");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
            }
            if (vidas == 0)
            {
                Console.WriteLine("Você perdeu.");
            }*/
            
        }
    }
}