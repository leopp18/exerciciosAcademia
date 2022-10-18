namespace Lista08_Ex05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            List<int> obj = new List<int>();
            int x, y;
            for (int i = 0; i < 10; i++)
            {
                x = random.Next(-20, 20);
                y = random.Next(-20, 20);
                obj.Add(x);
                obj.Add(y);
            }

            foreach (int i in obj)
            {
                Console.Write("X: " + i);
                Console.Write("\tY: " + (i+1));
                Console.WriteLine();
            }

        }
    }
}