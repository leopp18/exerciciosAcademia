using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio01
{
    internal class Util
    {
        List<Pessoa> pessoas = new List<Pessoa>();
        List<Pessoa> alunos = new List<Pessoa>();
        public void leArquivo()
        {
            try
            {
                string nome = "", telefone = "", cidade = "", rg = "", cpf = "";
                string curso = "", matricula = "", codigo = "";
                bool aluno = false;
                string nomeArquivo = "dados.txt";
                StreamReader sr = new StreamReader(nomeArquivo);
                string linha = "";
                string[] dados;
                while ((linha = sr.ReadLine()) != null)
                {
                    dados = linha.Split("-");
                    if (dados[0].Equals("Z"))
                    {
                        nome = dados[1];
                        telefone = dados[2];
                        cidade = dados[3];
                        rg = dados[4];
                        cpf = dados[5];
                    }
                    if (dados[0].Equals("Y"))
                    {
                        matricula = dados[1];
                        codigo = dados[2];
                        curso = dados[3];
                        aluno = true;
                        Pessoa a = new Aluno(nome, telefone, cidade, rg, cpf, matricula, codigo, curso);
                        alunos.Add(a);
                    }
                    if (aluno == false)
                    {
                        Pessoa p = new Pessoa(nome, telefone, cidade, rg, cpf);
                        pessoas.Add(p);
                    }
                }
                sr.Close();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Arquivo não encontrado.");
                Environment.Exit(0);
            }
        }

        public void exibeDados()
        {
            Console.WriteLine("Foram criadas " + pessoas.Count + " pessoas.");
            Console.WriteLine("Foram criados " + alunos.Count + " alunos.");
            Console.WriteLine();
            int i = 1;
            foreach (Aluno aluno in alunos)
            {
                Console.WriteLine("ALUNO " + i + ":");
                Console.WriteLine("Nome: " + aluno.Nome);
                Console.WriteLine("Curso: " + aluno.Curso);
                Console.WriteLine();
                i++;
            }
        }
    }
}
