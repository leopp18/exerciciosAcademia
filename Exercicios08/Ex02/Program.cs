namespace Lista08_Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome = "";
            string tipo = "";
            Animal a;
            int gato = 0;
            int cao = 0;
            int peixe = 0;
            for (int i = 0; i < 5; i++)
            {                
                Console.WriteLine("Informe o nome do animal:");
                nome = Console.ReadLine();
                Console.WriteLine("Informe o tipo do animal:");
                tipo = Console.ReadLine().ToUpper();
                if (tipo != "GATO" && tipo != "PEIXE" && tipo != "CACHORRO")
                {
                    Console.WriteLine("Insira um tipo de animal válido.");
                    i--;
                }
                if (tipo == "GATO")
                {
                    a = new Gato(nome, tipo);
                    gato++;
                }else if (tipo == "CACHORRO")
                {
                    a = new Cachorro(nome, tipo);
                    cao++;
                }
                else if (tipo == "PEIXE")
                {
                    a = new Peixe(nome, tipo);
                    peixe++;
                }
            }
            Console.WriteLine("Quantidade de gatos: " + gato);
            Console.WriteLine("Quantidade de cachorros: " + cao);
            Console.WriteLine("Quantidade de peixes: " + peixe);

        }
    }
}