namespace Lista07_Ex07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op, andar;
            Elevador elevador = new Elevador();
            while (true)
            {
                Console.WriteLine("\n\nMENU DE OPÇÕES:");
                Console.WriteLine("[1] Subir 1 andar");
                Console.WriteLine("[2] Descer 1 andar");
                Console.WriteLine("[3] Entrar 1 pessoa");
                Console.WriteLine("[4] Sair 1 pessoa");
                Console.WriteLine("[5] Ir para andar específico");
                Console.WriteLine("[6] Ver andar e quantidade de pessoas");
                Console.WriteLine("[7] Desligar elevador");
                Console.WriteLine("\nInsira a opção:");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        if(elevador.getAndar() >= 0 && elevador.getAndar() < 12)
                        {
                            elevador.sobeAndar();
                        }
                        else
                        {
                            Console.WriteLine("Você chegou no último andar! Só é possível descer.");
                        }
                        break;
                    case 2:
                        if (elevador.getAndar() > 0 && elevador.getAndar() <= 12)
                        {
                            elevador.desceAndar();
                        }
                        else
                        {
                            Console.WriteLine("Você chegou no térreo! Só é possível subir.");
                        }
                        break;
                    case 3:
                        if (elevador.getQuantidade() >= 0 && elevador.getQuantidade() < 8)
                        {
                            elevador.entraPessoa();
                        }
                        else
                        {
                            Console.WriteLine("O elevador já está na capacidade máxima.");
                        }
                        break;
                    case 4:
                        if (elevador.getQuantidade() > 0 && elevador.getQuantidade() <= 8)
                        {
                            elevador.saiPessoa();
                        }
                        else
                        {
                            Console.WriteLine("O elevador já está vazio.");
                        }
                        break;
                    case 5:
                        Console.WriteLine("Em qual andar deseja chegar?");
                        andar = int.Parse(Console.ReadLine());
                        if (andar >= 0 && andar <= 8)
                        {
                            elevador.setAndar(andar);
                        }
                        else
                        {
                            Console.WriteLine("Andar inválido!");
                        }
                        break;
                    case 6:
                        Console.WriteLine("Andar atual: " + elevador.getAndar());
                        Console.WriteLine("Quantidade atual de pessoas: " + elevador.getQuantidade());
                        break;
                    case 7:
                        Console.WriteLine("Desligando!");
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