using System.Runtime.CompilerServices;

namespace Lista09_Ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op;
            Figurinha f = new Figurinha();
            Util u = new Util();
            u.popularListas();
            while (true)
            {
                Console.WriteLine("MENU DE FIGURINHAS:");
                Console.WriteLine("[1] Cadastrar figurinha repetida");
                Console.WriteLine("[2] Cadastrar figurinha faltante");
                Console.WriteLine("[3] Listar figurinhas repetidas");
                Console.WriteLine("[4] Listar figurinhas faltantes");
                Console.WriteLine("[5] Sair");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        //Console.WriteLine("Insira o código da figurinha repetida:");
                        //f.setCodigo(Console.ReadLine());
                        //Console.WriteLine("Insira a seleção da figurinha repetida:");
                        //f.setSelecao(Console.ReadLine());
                        //Console.WriteLine("Insira o nome da figurinha repetida:");
                        //f.setNome(Console.ReadLine());
                        //string texto = f.getCodigo() + "; " + f.getSelecao() + "; " + f.getNome() + "; ";
                        u.cadastrarRepetida();
                        break;
                    case 2:
                        u.cadastrarFaltante();
                        break;
                    case 3:
                        u.listarRepetidas();
                        break;
                    case 4:
                        u.listarFaltantes();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            }
        }
    }
}