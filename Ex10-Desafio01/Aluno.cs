using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio01
{
    internal class Aluno : Pessoa
    {
        private string curso;
        private string matricula;
        private string codigo;
        public Aluno(string nome, string telefone, string cidade, string rg, string cpf, string matricula, string codigo, string curso) : base(nome, telefone, cidade, rg, cpf)
        {
            this.curso = curso;
            this.matricula = matricula;
            this.codigo = codigo;
        }

        public string Codigo { get => codigo; set => codigo = value; }
        public string Matricula { get => matricula; set => matricula = value; }
        public string Curso { get => curso; set => curso = value; }
    }
}
