using System.ComponentModel;
using System.Security.Principal;

namespace Lista08_Ex06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op;
            string nome;
            int cargo;
            string departamento;
            double salario;
            string data;
            string rg;
            bool ativo;
            string nomeBusca;

            List <Funcionario> funcs= new List<Funcionario>();
            while (true)
            {
                Console.WriteLine("MENU DE OPÇÕES:");
                Console.WriteLine("[1] Cadastrar funcionário");
                Console.WriteLine("[2] Listar funcionários");
                Console.WriteLine("[3] Bonificar funcionário");
                Console.WriteLine("[4] Demitir funcionário");
                Console.WriteLine("[5] Sair");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Console.WriteLine("Insira o nome:");
                        nome = Console.ReadLine();
                        Console.WriteLine("Insira o cargo: (1 p/ gerente e 2 p/ operador)");
                        cargo = int.Parse(Console.ReadLine());
                        Console.WriteLine("Insira o departamento:");
                        departamento = Console.ReadLine();
                        Console.WriteLine("Insira o salario:");
                        salario = double.Parse(Console.ReadLine());
                        Console.WriteLine("Insira a data de admissão:");
                        data = Console.ReadLine();
                        Console.WriteLine("Insira o RG:");
                        rg = Console.ReadLine();
                        ativo = true;
                        if(cargo == 1)
                        {
                            Funcionario f = new Gerente(nome, departamento, salario, data, rg, ativo);
                            funcs.Add(f);
                        }
                        else
                        {
                            Funcionario f = new Operador(nome, departamento, salario, data, rg, ativo);
                            funcs.Add(f);
                        }
                        break;
                    case 2:
                        foreach(Funcionario i in funcs)
                        {
                            Console.WriteLine("Nome: " + i.Nome);
                            Console.WriteLine("Departamento: " + i.Departamento);
                            Console.WriteLine("Salario: " + i.Salario);
                            Console.WriteLine("Data: " + i.Data);
                            Console.WriteLine("RG: " + i.Rg);
                            Console.WriteLine("Ativo: " + i.Ativo);
                            Console.WriteLine();
                        }
                        break;
                    case 3:
                        int adicional;
                        Funcionario f3 = new Gerente();
                        Console.WriteLine("Digite o nome do funcionário que deseja aumentar o salário:");
                        nomeBusca = Console.ReadLine();
                        f3 = funcs.Find(delegate (Funcionario f3) { return f3.Nome == nomeBusca; });
                        if (f3 == null)
                        {
                            Console.WriteLine("Funcionário não encontrado");
                            break;
                        }
                        Console.WriteLine("Em quanto deseja aumentar o salário? ");
                        adicional = int.Parse(Console.ReadLine());
                        f3.bonifica(adicional);
                        break;
                    case 4:
                        Funcionario f2 = new Gerente();
                        Console.WriteLine("Digite o nome do funcionário a ser demitido:");
                        nomeBusca = Console.ReadLine();
                        f2 = funcs.Find(delegate (Funcionario f2) { return f2.Nome == nomeBusca; });
                        if (f2 == null)
                        {
                            Console.WriteLine("Funcionário não encontrado");
                            break;
                        }
                        f2.demite();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
        }
    }
}