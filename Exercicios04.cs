using System.Drawing;
using System.Globalization;
using System.Runtime.Intrinsics.X86;
using System.Linq;

namespace Exercicios04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*EXERCICIO 1
            int[] vet = new int[10];
            int pares = 0, impares = 0;
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Insira um valor na posição " + i + ":");
                vet[i] = int.Parse(Console.ReadLine());
                if (vet[i] % 2 == 0)
                {
                    pares++;
                }
                else
                {
                    impares++;
                }
            }
            Console.WriteLine("Quantidade de pares: " + pares);
            Console.WriteLine("Quantidade de ímpares: " + impares);

            EXERCICIO 2
            int[] vet1 = new int[20];
            int[] vet2 = new int[20];
            int[] vet3 = new int[20];
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Insira um valor no vetor 1 na posição " + i + ":");
                vet1[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Insira um valor no vetor 2 na posição " + i + ":");
                vet2[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 20; i++)
            {
                vet3[i] = vet1[i] + vet2[i];
                Console.WriteLine("Vetor 3 [" + i + "]: " + vet3[i]);
            }

            EXERCICIO 3
            int[] vet = new int[20];
            int divisores;
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Insira um valor na posição " + i + ":");
                vet[i] = int.Parse(Console.ReadLine());
            }
            for(int i = 0; i < 20; i++)
            {
                divisores = 0;
                for (int j = 1; j <= vet[i]; j++)
                {
                    if (vet[i] % j == 0)
                    {
                        divisores++;
                    }
                }
                if (divisores == 2)
                {
                    Console.WriteLine("O valor " + vet[i] + " na posição " + i + " é primo.");
                }
            }

            EXERCICIO 4
            int[] vet1 = new int[10];
            int[] vet2 = new int[10];
            int[] vet3 = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Insira um valor no vetor 1 na posição " + i + ":");
                vet1[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Insira um valor no vetor 2 na posição " + i + ":");
                vet2[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 10; i++)
            {
                vet3[i] = vet1[i] * vet2[i];
                Console.WriteLine("Vetor 3 [" + i + "]: " + vet3[i]);
            }

            EXERCICIO 5
            int[] vet1 = new int[80];
            int menor = 99999;
            for (int i = 0; i < 80; i++)
            {
                Console.WriteLine("Insira um valor no vetor 1 na posição " + i + ":");
                vet1[i] = int.Parse(Console.ReadLine());
                if(menor > vet1[i])
                {
                    menor = vet1[i];
                }
            }
            Console.WriteLine("\nO menor valor do vetor é: " + menor); 

            EXERCICIO 6
            int[] vet = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Insira um valor no vetor 1 na posição " + i + ":");
                vet[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Ordem inversa:");
            for (int i = 9; i >= 0; i--)
            {
                Console.WriteLine(vet[i]);
            }

            EXERCICIO 7
            int[] vet = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Insira um valor no vetor 1 na posição " + i + ":");
                vet[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\n");
            for(int i = 0; i < 10; i++)
            {
                if (vet[i] % 2 == 0) Console.WriteLine(vet[i]);
            }
            for (int i = 0; i < 10; i++)
            {
                if (vet[i] % 2 != 0) Console.WriteLine(vet[i]);
            } 

            EXERCICIO 8
            double[] vet = new double[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Insira um valor no vetor 1 na posição " + i + ":");
                vet[i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("\n");
            for (int i = 0; i < 10; i++)
            {
                if (vet[i] < 0)
                {
                    Console.WriteLine(i + 1);
                }
            }

            EXERCICIO 9
            int[] vet = new int[10];
            int aux;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Insira um valor no vetor 1 na posição " + i + ":");
                vet[i] = int.Parse(Console.ReadLine());
            }
            for (int j = 0; j < 10; j++)
            {
                for (int i = j + 1; i < 10; i++)
                {
                    if (vet[j] > vet[i])
                    {
                        aux = vet[j];
                        vet[j] = vet[i];
                        vet[i] = aux;
                    }
                }
            }
            Console.WriteLine("\n");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(vet[i]);
            }
            
            EXERCICIO 10
            int[] vet = new int[10];
            int[] vet2 = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Insira um valor no vetor 1 na posição " + i + ":");
                vet[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 10; i++)
            {
                vet2[i] = vet[i];
                if (vet2[i] == 0)
                {
                    vet2[i] = 2;
                }
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Vetor 1[" + i + "]= " + vet[i]);
            }
            Console.WriteLine("\n");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Vetor 2[" + i + "]= " + vet2[i]);
            }

            EXERCICIO 11
            int[] vet = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Insira um valor no vetor 1 na posição " + i + ":");
                vet[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Ordem normal:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Vetor[" + i + "]= " + vet[i]);
            }
            Console.WriteLine("Ordem inversa:");
            for (int i = 4; i >= 0; i--)
            {
                Console.WriteLine("Vetor[" + i + "]= " + vet[i]);
            }

            EXERCICIO 12
            int[] vet = new int[10];
            int num;
            bool existe = false;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Insira um valor no vetor 1 na posição " + i + ":");
                vet[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Insira um valor a ser pesquisado:");
            num = int.Parse(Console.ReadLine());
            for(int i = 0; i < 10; i++)
            {
                if(num == vet[i])
                {
                    Console.WriteLine("Vetor[" + i + "] = " + vet[i]);
                    existe = true;
                }
            }
            if(existe == false)
            {
                Console.WriteLine("O número fornecido não existe no vetor!");
            }

            EXERCICIO 13
            int[] vet = new int[100];
            int dois = 0, quatro = 0, oito = 0;
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Insira um valor no vetor 1 na posição " + i + ":");
                vet[i] = int.Parse(Console.ReadLine());
                if (vet[i] == -1)
                {
                    break;
                }
            }
            for(int i = 0; i < vet.Length; i++)
            {
                if (vet[i] == 2)
                {
                    dois++;
                }else if (vet[i] == 4)
                {
                    quatro++;
                }else if (vet[i] == 8)
                {
                    oito++;
                }
                else { }
            }
            Console.WriteLine("Quantidade de 2: " + dois);
            Console.WriteLine("Quantidade de 4: " + quatro);
            Console.WriteLine("Quantidade de 8: " + oito);

            EXERCICIO 14
            int[] vet = new int[50];
            int codigo;
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine("Insira um valor no vetor 1 na posição " + i + ":");
                vet[i] = int.Parse(Console.ReadLine());
                }
            }
            do
            {
                Console.WriteLine("Insira o codigo:");
                Console.WriteLine("[0] Encerrar");
                Console.WriteLine("[1] Ler na ordem normal");
                Console.WriteLine("[2] Ler na ordem inversa");
                codigo = int.Parse(Console.ReadLine());
                if (codigo == 1)
                {
                    for (int i = 0; i < 50; i++)
                    {
                        Console.WriteLine("Vetor[" + i + "]= " + vet[i]);
                    }
                }
                else if (codigo == 2) { 
                    Console.WriteLine("Ordem inversa:");
                    for (int i = 49; i >= 0; i--)
                    {
                        Console.WriteLine("Vetor[" + i + "]= " + vet[i]);
                    }

                } else if(codigo == 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Insira um código válido");
                }
            } while (codigo != 0);

            EXERCICIO 15
            int[] vet = new int[20];
            int[] vet2 = new int[20];
            int j = 19;
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Insira um valor no vetor 1 na posição " + i + ":");
                vet[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 20; i++)
            {
                vet2[i] = vet[j];
                j--;
            }
            Console.WriteLine(String.Join("|", vet));
            Console.WriteLine(String.Join("|", vet2)); 

            EXERCICIO 16
            int[] vetX = new int[10];
            int[] vetY = new int[10];
            int[] uniao = new int[20];
            int[] intersec = new int[10];
            int[] dif = new int[10];
            int ind = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Insira um valor no vetor X na posição " + i + ":");
                vetX[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Insira um valor no vetor Y na posição " + i + ":");
                vetY[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 10; i++)
            {
                uniao[i] = vetX[i];
                uniao[i+10] = vetY[i];
            }
            for (int i = 0; i < 10; i++)
            {
                for(int j = 0; j < 10; j++)
                {
                    if (vetX[i] == vetY[j])
                    {
                        intersec[ind] = vetX[i];
                        ind++;
                    }
                }
            }
            ind = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (vetX[i] == vetY[j])
                    {
                        break;
                    }
                    if(j == (vetY.Length - 1))
                    {
                        dif[ind] = vetX[i];
                        ind++;
                    }
                }
            }
            uniao = uniao.Distinct().ToArray();//exclui repetidos
            intersec = intersec.Distinct().ToArray();
            dif = dif.Distinct().ToArray();
            Console.WriteLine("\n");
            Console.WriteLine("Vetor X: " +  String.Join("|", vetX));
            Console.WriteLine("Vetor Y: " + String.Join("|", vetY));
            Console.WriteLine("União: " + String.Join("|", uniao));
            Console.WriteLine("Intersecção: " + String.Join("|", intersec));
            Console.WriteLine("Diferença: " + String.Join("|", dif));*/
        }
    }
    
}