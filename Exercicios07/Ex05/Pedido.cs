using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista07_Ex05
{
    internal class Pedido
    {
        private Produto produto;
        private Pagamento pagamento;

        public void setProduto(Produto produto)
        {
            this.produto = produto;
        }

        public void setPagamento(Pagamento pagamento)
        {
            this.pagamento = pagamento;
        }

        public void exibeDados()
        {
            Console.WriteLine("\n\nNome do produto: " + produto.getNome());
            Console.WriteLine("Valor do produto: " + produto.getValor());
            Console.WriteLine("Quantidade do produto: " + produto.getQuantidade());
            Console.WriteLine("Método de pagamento: " + pagamento.getMetodo());
            Console.WriteLine("Valor total do pedido: " + pagamento.getTotal());

        }
    }
}
