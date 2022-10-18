using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista08_Ex06
{
    internal abstract class Funcionario
    {
        private string nome;
        private string departamento;
        private double salario;
        private string data;
        private string rg;
        private bool ativo;

        public Funcionario(string nome, string departamento, double salario, string data, string rg, bool ativo)
        {
            this.nome = nome;
            this.departamento = departamento;
            this.salario = salario;
            this.Data = data;
            this.Rg = rg;
            this.Ativo = ativo;
        }

        protected Funcionario()
        {
        }

        public string Nome { get => nome; set => nome = value; }
        public string Departamento { get => departamento; set => departamento = value; }
        public double Salario { get => salario; set => salario = value; }
        public string Data { get => data; set => data = value; }
        public string Rg { get => rg; set => rg = value; }
        public bool Ativo { get => ativo; set => ativo = value; }

        public void bonifica(double adicional)
        {
            salario += adicional;
            Console.WriteLine("Salário aumentado para " + salario);
        }

        public void demite()
        {
            Ativo = false;
            Console.WriteLine("Funcionário demitido.");
        }

        public abstract void ExecutaTrabalho();
    }
}
