namespace Lista08_Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maior;
            string nome;
            Personagens p;

            p = new Pers1("Zelda", 6);
            p.exibeDados();
            maior = p.getPoder();
            nome = p.getNome();
            p = new Pers2("Crash", 7);
            p.exibeDados();
            if(p.getPoder() > maior)
            {
                maior = p.getPoder();
                nome = p.getNome();
            }
            p = new Pers3("Sonic", 8);
            p.exibeDados();
            if (p.getPoder() > maior)
            {
                maior = p.getPoder();
                nome = p.getNome();
            }

            Console.WriteLine("Personagem mais poderoso: " + nome + ", com poder de " + maior);
        }
    }
}