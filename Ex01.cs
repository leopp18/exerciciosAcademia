namespace Lista07_Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name, author;
            int year;

            Console.WriteLine("Insira o nome do livro:");
            name = Console.ReadLine();
            Console.WriteLine("Insira o nome do autor:");
            author = Console.ReadLine();
            Console.WriteLine("Insira o ano de publicação:");
            year = int.Parse(Console.ReadLine());

            Livro l1 = new Livro(name, author, year);
            l1.exibirDados();
        }
    }
}