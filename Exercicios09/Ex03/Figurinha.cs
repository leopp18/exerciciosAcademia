using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista09_Ex03
{
    internal class Figurinha
    {
        private string codigo;
        private string selecao;
        private string nome;


        public Figurinha()
        {
        }

        public string getCodigo()
        {
            return codigo;
        }
        public void setCodigo(string codigo)
        {
            this.codigo = codigo;
        }
        public string getSelecao()
        {
            return selecao;
        }
        public void setSelecao(string selecao)
        {
            this.selecao = selecao;
        }
        public string getNome()
        {
            return nome;
        }
        public void setNome(string nome)
        {
            this.nome = nome;
        }


    }
}
