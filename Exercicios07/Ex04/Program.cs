namespace Lista07_Ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoaFilho = new Pessoa();
            pessoaFilho.nome = "Bruno";
            pessoaFilho.idade = 21;
            Pessoa pessoaMae = new Pessoa();
            pessoaMae.nome = "Fernanda";
            pessoaMae.idade = 42;
            Pessoa pessoaPai = new Pessoa();
            pessoaPai.nome = "Glauber";
            pessoaPai.idade = 48;
            Pessoa pAvoPai = new Pessoa();
            pAvoPai.nome = "João";
            pAvoPai.idade = 62;
            pessoaPai.pai = pAvoPai;
            pessoaFilho.mae = pessoaMae;
            pessoaFilho.pai = pessoaPai;

            Console.WriteLine("Nome do filho: " + pessoaFilho.nome);
            Console.WriteLine("Idade do filho: " + pessoaFilho.idade);
            Console.WriteLine("Nome da mãe: " + pessoaMae.nome);
            Console.WriteLine("Idade da mãe: " + pessoaMae.idade);
            Console.WriteLine("Nome do pai: " + pessoaPai.nome);
            Console.WriteLine("Idade do pai: " + pessoaPai.idade);
            Console.WriteLine("Nome do avô: " + pAvoPai.nome);
            Console.WriteLine("Idade do avô: " + pAvoPai.idade);
        }
    }
}