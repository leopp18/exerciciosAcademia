namespace Exercicios1
{

    internal class Program
    {
        static void Main(string[] args)
        {
            /*EXERCICIO 1
            int x = 10;
            int y = 8;
            Console.WriteLine("A média é " + (x + y) / 2);

            EXERCICIO 2
            int x = 10;
            int y = 8;
            int v = 7;
            int z = 11;
            Console.WriteLine("A média é " + (x + y + v + z) / 4);

            EXERCICIO 3
            int a = 2;
            int b = 3;
            int aux = a;
            int a = b;
            int b = aux;

            EXERCICIO 4
            int dia, mes, ano;
            string anoString;
            Console.WriteLine("Insira o dia:");
            dia = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o mes:");
            mes = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o ano:");
            ano = int.Parse(Console.ReadLine());
            Console.WriteLine("A data é " + ano + mes + dia);
            anoString = ano.ToString();
            Console.WriteLine("Ou simplificando, é " + anoString[2] + anoString[3] + mes + dia);

            EXERCICIO 5
            int km, litros;
            Console.WriteLine("Insira a distância percorrida:");
            km = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o volume de combustível consumido:");
            litros = int.Parse(Console.ReadLine());
            Console.WriteLine("O consumo foi de " + km/litros + " km/l");


            EXERCICIO 6
            int idp1, quantp1, valorp1;
            int idp2, quantp2, valorp2;
            float ipip1, ipip2;
            Console.WriteLine("Insira o código do parafuso 1:");
            idp1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira a quantidade de parafuso 1:");
            quantp1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor do parafuso 1:");
            valorp1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o IPI do parafuso 1:");
            ipip1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Insira o código do parafuso 2:");
            idp2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira a quantidade de parafuso 2:");
            quantp2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor do parafuso 2:");
            valorp2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o IPI do parafuso 2:");
            ipip2 = float.Parse(Console.ReadLine());

            Console.WriteLine("DADOS DOS PARAFUSOS:\n");
            Console.WriteLine("PARAFUSO 1:\n");
            Console.WriteLine("\nCódigo: " + idp1);
            Console.WriteLine("\nQuantidade: " + quantp1);
            Console.WriteLine("\nValor: " + valorp1);
            Console.WriteLine("\nIPI: " + ipip1 + "%\n");
            Console.WriteLine("PARAFUSO 2:\n");
            Console.WriteLine("\nCódigo: " + idp2);
            Console.WriteLine("\nQuantidade: " + quantp2);
            Console.WriteLine("\nValor: " + valorp2);
            Console.WriteLine("\nIPI: " + ipip2 + "%\n"); 

            EXERCÍCIO 7
            int num;
            float salarioBase, totalVendas, percentual, salarioTotal;
            Console.WriteLine("Insira o número do vendedor:");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o salário base deste vendedor:");
            salarioBase = float.Parse(Console.ReadLine());
            Console.WriteLine("Insira o total de vendas:");
            totalVendas = float.Parse(Console.ReadLine());
            Console.WriteLine("Insira o percentual de comissão sobre o total de vendas:");
            percentual = float.Parse(Console.ReadLine());
            salarioTotal = salarioBase + (totalVendas * (percentual / 100));
            Console.WriteLine("O salário total do vendedor " + num + " é de " + salarioTotal); 

            EXERCICIO 8
            float celsius, fahrenheit;
            Console.WriteLine("Insira a temperatura em Celsius:");
            celsius = float.Parse(Console.ReadLine());
            fahrenheit = (9 * celsius + 160) / 5;
            Console.WriteLine("A temperatura em Fahrenheit é igual a " + fahrenheit);

            EXERCICIO 9
            float valor, entrada, prest, aux;
            Console.WriteLine("Insira o valor do produto:");
            valor = float.Parse(Console.ReadLine());
            if(valor % 3 == 0)
            {
                entrada = valor / 3;
                prest = entrada;
            }
            else
            {
                aux = valor;
                valor -= (valor % 3);
                entrada = (valor / 3) + (aux % 3);
                entrada = (float)Math.Round(entrada, 2);
                prest = (valor / 3);
            }
            Console.WriteLine("A entrada é de " + entrada + " e as duas prestações são de " + prest); 

            EXERCICIO 10
            int valor, aux, nota100, nota50, nota20, nota10, nota5, nota2, nota1;
            Console.WriteLine("Insira o valor:");
            valor = int.Parse(Console.ReadLine());
            aux = valor;
            valor -= aux % 100;
            nota100 = valor / 100;
            valor = aux - 100 * nota100;//fechou as de 100
            aux = valor;
            valor -= aux % 50;
            nota50 = valor / 50;
            valor = aux - 50 * nota50;//fechou as de 50
            aux = valor;
            valor -= aux % 20;
            nota20 = valor / 20;
            valor = aux - 20 * nota20;//fechou as de 20
            aux = valor;
            valor -= aux % 10;
            nota10 = valor / 10;
            valor = aux - 10 * nota10;//fechou as de 10
            aux = valor;
            valor -= aux % 5;
            nota5 = valor / 5;
            valor = aux - 5 * nota5;//fechou as de 5
            aux = valor;
            valor -= aux % 2;
            nota2 = valor / 2;
            valor = aux - 2 * nota2;//fechou as de 2
            aux = valor;
            valor -= aux % 1;
            nota1 = valor / 1;//fechou as de 1

            Console.WriteLine("Notas de 100: " + nota100);
            Console.WriteLine("Notas de 50: " + nota50);
            Console.WriteLine("Notas de 20: " + nota20);
            Console.WriteLine("Notas de 10: " + nota10);
            Console.WriteLine("Notas de 5: " + nota5);
            Console.WriteLine("Notas de 2: " + nota2);
            Console.WriteLine("Notas de 1: " + nota1);

            EXERCICIO 11
            int eleitores, brancos, nulos, validos;
            Console.WriteLine("Insira o número de eleitores:");
            eleitores = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o número de votos em branco:");
            brancos = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o número de votos nulos:");
            nulos = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o número de votos válidos:");
            validos = int.Parse(Console.ReadLine());
            if(brancos + nulos + validos > eleitores)
            {
                Console.WriteLine("Quantidade de votos inválida.");
            }
            else {
                Console.WriteLine("Votos em branco: " + (brancos * 100 / eleitores) + "%");
                Console.WriteLine("Votos nulos: " + (nulos * 100 / eleitores) + "%");
                Console.WriteLine("Votos válidos: " + (validos * 100 / eleitores) + "%");
            }

            EXERCICIO 12
            float kmIni, kmFim, kmSaldo, gas, valor;
            Console.WriteLine("Insira a marcação do odômetro no início do dia:");
            kmIni = float.Parse(Console.ReadLine());
            Console.WriteLine("Insira a marcação do odômetro no fim do dia:");
            kmFim = float.Parse(Console.ReadLine());
            Console.WriteLine("Insira o volume de combustível gasto:");
            gas = float.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor total recebido pelos clientes:");
            valor = float.Parse(Console.ReadLine());
            kmSaldo = kmFim - kmIni;
            Console.WriteLine("Média de combustível gasto: " + kmSaldo / gas );
            Console.WriteLine("Lucro líquido do dia: " + (valor - (gas * 6.90)));

            EXERCICIO 13
            float salario, custo;
            int quant;
            Console.WriteLine("Insira o salario:");
            salario = float.Parse(Console.ReadLine());
            Console.WriteLine("Insira o preço de custo da bicicleta:");
            custo = float.Parse(Console.ReadLine());
            Console.WriteLine("Insira a quantidade de bicicletas vendidas:");
            quant = int.Parse(Console.ReadLine());
            Console.WriteLine("Salario total é " + ((salario * 2) + (custo * quant * 0.15))); */

        }
    }
    
}
