namespace Exercicios05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*EXERCICIO 1
            int[,] matriz = new int[5, 3];
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Insira um valor na matriz [" + i + ",0]: ");
                matriz[i, 0] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 5; i++)
            {
                matriz[i, 1] = matriz[i, 0] + 10;
                matriz[i, 2] = matriz[i, 0] * 2;
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("[" + i + "," + j + "] = " + matriz[i, j] + "  ");
                }
                Console.WriteLine();
            }

            EXERCICIO 2
            int[,] matriz = new int[3, 3];
            int somaLinha, somaColuna;
            for (int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Insira um valor na matriz [" + i + "," + j + "]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for(int i = 0; i < 3; i++)
            {
                int j = 0;
                somaLinha = 0;
                somaColuna = 0;
                for (j = 0; j < 3; j++)
                {
                    somaLinha += matriz[i, j];
                    somaColuna += matriz[j, i];
                }
                Console.WriteLine("Linha " + i + ": " + somaLinha);
                Console.WriteLine("Coluna " + (i) + ": " + somaColuna); 
            }

            EXERCICIO 3
            int[,] matriz = new int[4, 4] { {3,6,1,9}, {5,7,15,2}, {12,13,8,9}, {6,4,10,18} };
            int soma = 0;
            for(int i = 0; i < 4; i++)
            {
                soma += matriz[i, i];
            }
            Console.WriteLine("Soma da diagonal principal: " + soma);


            EXERICICIO 4
            int[,] matriz = new int[5, 5] { {3,-6,1,9,0}, {5,7,-15,2,15}, {-12,13,8,0,-7}, {6,4,-10,18,1}, {11,7,14,6,19} };
            int pares = 0, impares = 0, positivos = 0, negativos = 0, zero = 0;
            for(int i = 0; i < matriz.GetLength(0); i++)
            {
                for(int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (matriz[i,j] % 2 == 0)
                    {
                        pares++;
                    }
                    else
                    {
                        impares++;
                    }
                    if(matriz[i,j] > 0)
                    {
                        positivos++;
                    }
                    else if(matriz[i,j] < 0)
                    {
                        negativos++;
                    }
                    else
                    {
                        zero++;
                    }
                }
            }
            Console.WriteLine("Quantidade de pares: " + pares);
            Console.WriteLine("Quantidade de ímpares: " + impares);
            Console.WriteLine("Quantidade de positivos: " + positivos);
            Console.WriteLine("Quantidade de negativos: " + negativos);
            Console.WriteLine("Quantidade de zeros: " + zero);

            EXERCICIO 5
            double[,] matriz1 = new double[2, 3];
            double[,] matriz2 = new double[2, 3];
            double soma;
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Insira um valor na primeira matriz [" + i + "," + j + "]: ");
                    matriz1[i, j] = double.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Insira um valor na segunda matriz [" + i + "," + j + "]: ");
                    matriz2[i, j] = double.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    soma = 0;
                    soma = matriz1[i, j] + matriz2[i, j];
                    Console.WriteLine("Soma das posições[" + i + "," + j + "] = " + soma);
                }
                Console.WriteLine();
            }

            EXERCICIO 6
            Random rd = new Random();
            int[,] matriz = new int[4, 4];
            int maior = -1;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    matriz[i, j] = rd.Next(0, 9);
                    Console.Write("[" + i + "," + j + "] = " + matriz[i, j] + "  ");
                    if(maior < matriz[i, j])
                    {
                        maior = matriz[i, j];
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("Maior número: " + maior);

            EXERCICIO 7
            double[,] matriz1 = new double[3, 3];
            double[,] matriz2 = new double[3, 3];
            double[,] matriz3 = new double[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Insira um valor na primeira matriz [" + i + "," + j + "]: ");
                    matriz1[i, j] = double.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Insira um valor na segunda matriz [" + i + "," + j + "]: ");
                    matriz2[i, j] = double.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matriz3[i, j] = matriz1[i, j] - matriz2[i, j];
                    Console.Write("Matriz 3[" + i + "," + j + "] = " + matriz3[i,j] + "\t");
                }
                Console.WriteLine();
            } 

            EXERCICIO 8
            int[,] matriz = new int[4, 4];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine("Insira um valor na matriz [" + i + "," + j + "]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 3; i >= 0; i--)
            {
                for (int j = 3; j >= 0; j--)
                {
                    Console.WriteLine("Matriz [" + i + "," + j + "] = " + matriz[i, j] + "\t");
                }
            }

            EXERCICIO 9
            int[,] matriz = new int[3, 3];
            int num;
            bool existe = false;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Insira um valor na matriz [" + i + "," + j + "]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("\nDigite o número a ser pesquisado: ");
            num = int.Parse(Console.ReadLine());
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if(matriz[i, j] == num)
                    {
                        existe = true;
                    }
                }
            }
            if(existe == true)
            {
                Console.WriteLine("O número existe na matriz.");
            }
            else
            {
                Console.WriteLine("Número inexistente.");
            }

            EXERCICIO 10
            double[,] matriz1 = new double[4, 4];
            double[,] matriz2 = new double[4, 4];
            double soma = 0, media;
            int acima = 0, abaixo = 0, medio = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine("Insira um valor na primeira matriz [" + i + "," + j + "]: ");
                    matriz1[i, j] = double.Parse(Console.ReadLine());
                    soma += matriz1[i, j];
                }
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine("Insira um valor na segunda matriz [" + i + "," + j + "]: ");
                    matriz2[i, j] = double.Parse(Console.ReadLine());
                    soma += matriz1[i, j];
                }
            }
            media = soma / 32;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (matriz1[i,j] > media)
                    {
                        acima++;
                    }else if(matriz1[i, j] < media)
                    {
                        abaixo++;
                    }
                    else if (matriz1[i,j] == media)
                    {
                        medio++;
                    }
                    else { }
                    if (matriz2[i, j] > media)
                    {
                        acima++;
                    }
                    else if (matriz2[i, j] < media)
                    {
                        abaixo++;
                    }
                    else if (matriz2[i, j] == media)
                    {
                        medio++;
                    }
                    else { };
                }
            }
            Console.WriteLine("Acima da média: " + acima);
            Console.WriteLine("Abaixo da média: " + abaixo);
            Console.WriteLine("Na média: " + medio);

            EXERCICIO 11
            int[,] matriz1 = new int[3, 3];
            int[,] matriz2 = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Insira um valor na matriz [" + i + "," + j + "]: ");
                    matriz1[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i > 0 || j > 0) {
                        matriz2[i, j] = matriz1[i, j] / (i + j);
                    }
                    else
                    {
                        matriz2[i, j] = 0;
                    }
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("Matriz B[" + i + "," + j + "] = " + matriz2[i, j] + "\t");
                }
                Console.WriteLine();
            }*/
        }
    }
}
