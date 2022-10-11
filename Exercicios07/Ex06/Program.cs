namespace Lista07_Ex06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age, op;
            float height;
            Agenda agenda = new Agenda();

            while (true)
            {
                Console.WriteLine("\n\nMENU DE OPÇÕES:");
                Console.WriteLine("[1] Cadastrar pessoa");
                Console.WriteLine("[2] Remover pessoa");
                Console.WriteLine("[3] Buscar pessoa");
                Console.WriteLine("[4] Listar agenda");
                Console.WriteLine("[5] Sair");
                Console.WriteLine("\nInsira a opção:");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Console.WriteLine("Insira o nome:");
                        name = Console.ReadLine();
                        Console.WriteLine("Insira a idade:");
                        age = int.Parse(Console.ReadLine());
                        Console.WriteLine("Insira a altura:");
                        height = float.Parse(Console.ReadLine());
                        agenda.armazenaPessoa(name, age, height);
                        break;
                    case 2:
                        Console.WriteLine("Insira o nome:");
                        name = Console.ReadLine();
                        agenda.removePessoa(name);
                        break;
                    case 3:
                        Console.WriteLine("Insira o nome:");
                        name = Console.ReadLine();
                        agenda.buscaPessoa(name);
                        break;
                    case 4:
                        agenda.imprimeAgenda();
                        break;
                    case 5:
                        Console.WriteLine("Encerrando aplicação!");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }
        }
    }
}