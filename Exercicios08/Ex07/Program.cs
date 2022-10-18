namespace Lista08_Ex07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> livros = new Dictionary<string, int>();
            string nome;
            int pag, op;
            while (true)
            {
                Console.WriteLine("MENU DE OPÇÕES");
                Console.WriteLine("[1] Cadastrar livro");
                Console.WriteLine("[2] Pesquisar livro por nome");
                Console.WriteLine("[3] Listar acervo");
                Console.WriteLine("[4] Sair");
                op = int.Parse(Console.ReadLine());
                Console.WriteLine();
                switch (op)
                {
                    case 1:
                        Console.WriteLine("Digite o nome do livro:");
                        nome = Console.ReadLine();
                        Console.WriteLine("Digite o numero de páginas:");
                        pag = int.Parse(Console.ReadLine());
                        livros.Add(nome, pag);
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.WriteLine("Digite o nome do livro a ser pesquisado:");
                        nome = Console.ReadLine();
                        int n;
                        if (livros.TryGetValue(nome, out n))
                        {
                            Console.WriteLine("Livro " + nome + " encontrado! Ele possui " + n + " páginas");
                        }
                        else
                        {
                            Console.WriteLine("Livro não encontrado");
                        }
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.WriteLine("NOME, PÁGINAS");
                        foreach (KeyValuePair<string, int> p in livros)
                        {
                            Console.WriteLine(p.Key + ", " + p.Value);
                        }
                        Console.WriteLine();
                        break;
                    case 4:
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