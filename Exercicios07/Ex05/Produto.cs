using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista07_Ex05
{
    internal class Produto
    {
        private string nome;
        private double valor;
        private int estoque = 100;
        private int quantidade;

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public string getNome()
        {
            return nome;
        }

        public void setValor(double valor)
        {
            this.valor = valor;
        }

        public double getValor()
        {
            return valor;
        }

        public void setEstoque(int estoque)
        {
            this.estoque = estoque;
        }

        public int getEstoque()
        {
            return estoque;
        }

        public void setQuantidade(int quantidade)
        {
            this.quantidade = quantidade;
        }

        public int getQuantidade()
        {
            return quantidade;
        }

    }
}
