namespace Lista08_Ex03
{
    internal class Program
    {
        static List<Asteroide> asteroides = new List<Asteroide>();
        static void Main(string[] args)
        {
            
            Random random = new Random();
            int x = random.Next(-20, 20);
            int y = random.Next(-20, 20);
            int tamanho = random.Next(0, 11);
            int energia = random.Next(0, 6);
            int velocidade = random.Next(0, 6);

            Asteroide ast = new Asteroide(); 
            Console.WriteLine("Digite a posicao x:");
            ast.setX(int.Parse(Console.ReadLine()));
            Console.WriteLine("Digite a posicao y:");
            ast.setY(int.Parse(Console.ReadLine()));
            Console.WriteLine("Digite o tamanho:");
            ast.setTamanho(int.Parse(Console.ReadLine()));
            Console.WriteLine("Digite a velocidade:");
            ast.setVelocidade(int.Parse(Console.ReadLine()));
            Console.WriteLine("Digite a energia:");
            ast.setEnergia(int.Parse(Console.ReadLine()));

            Asteroide ast2 = new Asteroide(x, y, tamanho, energia, velocidade);
            Asteroide ast3 = new Asteroide(x, y);
            ast3.setTamanho(ast.getTamanho());
            ast3.setEnergia(ast.getEnergia());
            ast3.setVelocidade(ast.getVelocidade());

            asteroides.Add(ast);
            asteroides.Add(ast2);
            asteroides.Add(ast3);

            exibeDados();

        }

        public static void exibeDados()
        {
            foreach (Asteroide i in asteroides)
            {
                Console.WriteLine("Posição X: " + i.getX());
                Console.WriteLine("Posição Y: " + i.getY());
                Console.WriteLine("Tamanho: " + i.getTamanho());
                Console.WriteLine("Velocidade: " + i.getVelocidade());
                Console.WriteLine("Energia: " + i.getEnergia());
                Console.WriteLine();
            }
        }
    }
}