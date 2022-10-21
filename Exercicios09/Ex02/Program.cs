namespace Lista09_Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op;
            Email e = new Email();
            e.populaLista();
            while (true)
            {
                Console.WriteLine("MENU DE OPÇÕES:");
                Console.WriteLine("[1] Cadastrar e-mail");
                Console.WriteLine("[2] Listar");
                Console.WriteLine("[3] Sair");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        e.pedeEmail();
                        e.pegaDominio();
                        Console.WriteLine();
                        break;
                    case 2:
                        e.exibeListas();
                        Console.WriteLine();
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        Console.WriteLine();
                        break;

                }
            }
        }
    }
}