namespace Lista07_Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int year, height;

            Console.WriteLine("Insira o nome:");
            name = Console.ReadLine();
            Console.WriteLine("Insira a idade:");
            year = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira a altura em cm:");
            height = int.Parse(Console.ReadLine());

            Pessoa p1 = new Pessoa(name, year, height);
            p1.exibirDados();
        }
    }
}