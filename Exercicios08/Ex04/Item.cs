using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista08_Ex04
{
    internal class Item
    {
        private string descricao;
        private float altura;
        private DateTime dataCriacao;
        private TimeSpan tempo;

        public Item()
        {
        }

        public void setDescricao(string descricao)
        {
            this.descricao = descricao;
        }

        public string getDescricao()
        {
            return descricao;
        }
        public void setAltura(float altura)
        {
            this.altura = altura;
        }

        public float getAltura()
        {
            return altura;
        }
        public void setDataCriacao(DateTime dataCriacao)
        {
            this.dataCriacao = dataCriacao;
        }

        public DateTime getDataCriacao()
        {
            return dataCriacao;
        }

        public DateTime GetDataCriacao()
        {
            return dataCriacao;
        }

        public void calculaTempo(DateTime data)
        {
            DateTime dt = DateTime.Now;
            tempo = dt - data;
        }
        public void exibeDados()
        {
            Console.WriteLine("Descrição do item: " + descricao);
            Console.WriteLine("Altura do item: " + altura);
            Console.WriteLine("Data de criação: " + dataCriacao);
            Console.WriteLine("Foi inserido há quanto tempo: " + tempo);
        }
    }
}
