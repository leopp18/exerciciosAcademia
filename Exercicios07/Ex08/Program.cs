using System.Xml.Linq;

namespace Lista07_Ex08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op, canal;
            ControleRemoto cr = new ControleRemoto();
            while (true)
            {
                Console.WriteLine("\n\nMENU DE OPÇÕES:");
                Console.WriteLine("[1] Aumentar volume");
                Console.WriteLine("[2] Diminuir volume");
                Console.WriteLine("[3] Aumentar canal");
                Console.WriteLine("[4] Diminuir canal");
                Console.WriteLine("[5] Definir canal");
                Console.WriteLine("[6] Ver canal e volume");
                Console.WriteLine("[7] Desligar televisão");
                Console.WriteLine("\nInsira a opção:");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        cr.aumentaVolume();
                        break;
                    case 2:
                        cr.diminuiVolume();
                        break;
                    case 3:
                        cr.aumentaCanal();
                        break;
                    case 4:
                        cr.diminuiCanal();
                        break;
                    case 5:
                        Console.WriteLine("Qual canal deseja assistir?");
                        canal = int.Parse(Console.ReadLine());
                        cr.setCanal(canal);
                        break;
                    case 6:
                        cr.consultar();
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