using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio01
{
    internal class Pessoa
    {
        private string nome;
        private string telefone;
        private string cidade;
        private string rg;
        private string cpf;

        public string Nome { get => nome; set => nome = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Rg { get => rg; set => rg = value; }
        public string Cpf { get => cpf; set => cpf = value; }

        public Pessoa(string nome, string telefone, string cidade, string rg, string cpf)
        {
            this.nome = nome;
            this.telefone = telefone;
            this.cidade = cidade;
            this.rg = rg;
            this.cpf = cpf;
        }
    }
}
