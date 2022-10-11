using System.Runtime.CompilerServices;

namespace Lista07_Ex05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();
            Pagamento pagamento = new Pagamento();
            string nome, metodo;
            double valor;
            int quantidade;

            Console.WriteLine("Qual produto deseja comprar?");
            nome = Console.ReadLine();
            Console.WriteLine("Qual o valor?");
            valor = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantos itens?");
            quantidade = int.Parse(Console.ReadLine());

            produto.setNome(nome);
            produto.setValor(valor);
            produto.setQuantidade(quantidade);
            produto.setEstoque(produto.getEstoque() - quantidade);

            Console.WriteLine("Qual o método de pagamento?");
            metodo = Console.ReadLine();
            pagamento.setMetodo(metodo);
            pagamento.setTotal(quantidade * valor);

            Pedido pedido1 = new Pedido();
            pedido1.setProduto(produto);
            pedido1.setPagamento(pagamento);
            pedido1.exibeDados();

        }
    }
}