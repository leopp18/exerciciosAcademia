namespace Lista08_Ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Item item = new Item();
            string descricao;
            float altura;

            Console.WriteLine("Descreva o item a ser inserido: ");
            descricao = Console.ReadLine();
            Console.WriteLine("Digite sua altura: ");
            altura = float.Parse(Console.ReadLine());
            DateTime data = DateTime.Now;

            item.setDescricao(descricao);
            item.setAltura(altura);
            item.setDataCriacao(data);

            item.calculaTempo(data);
            item.GetDataCriacao();
            item.exibeDados();
        }
    }
}