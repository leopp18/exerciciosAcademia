using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio02
{
    internal class Cliente
    {
        private int id;
        private string nome;
        private string cpf;
        private string email;
        private string endereco;
        private string dataNasc;
        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Email { get => email; set => email = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string DataNasc { get => dataNasc; set => dataNasc = value; }

        public Cliente(int id, string nome, string cpf, string email, string endereco, string dataNasc)
        {
            this.id = id;
            this.nome = nome;
            this.cpf = cpf;
            this.email = email;
            this.endereco = endereco;
            this.dataNasc = dataNasc;
        }
        public Cliente(string nome, string cpf, string email, string endereco, string dataNasc)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.email = email;
            this.endereco = endereco;
            this.dataNasc = dataNasc;
        }

        public bool cadastrarCliente()
        {
            Banco b = new Banco();
            SqlConnection cn = b.abrirConexao();
            SqlTransaction transacao = cn.BeginTransaction();
            SqlCommand comando = new SqlCommand();

            comando.Connection = cn;
            comando.Transaction = transacao;
            comando.CommandType = CommandType.Text;

            comando.CommandText = "insert into clientes values (@nome, @cpf, @email, @endereco, @dataNasc);";
            comando.Parameters.Add("@nome", SqlDbType.VarChar);
            comando.Parameters.Add("@cpf", SqlDbType.VarChar);
            comando.Parameters.Add("@email", SqlDbType.VarChar);
            comando.Parameters.Add("@endereco", SqlDbType.VarChar);
            comando.Parameters.Add("@dataNasc", SqlDbType.DateTime);
            comando.Parameters[0].Value = nome;
            comando.Parameters[1].Value = cpf;
            comando.Parameters[2].Value = email;
            comando.Parameters[3].Value = endereco;
            comando.Parameters[4].Value = dataNasc;
            try
            {
                MessageBox.Show("Cliente cadastrado com êxito!", "Sucesso");
                comando.ExecuteNonQuery();
                transacao.Commit();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao cadastrar cliente!", "ERRO");
                transacao.Rollback();
                return false;
            }
            finally
            {
                b.fecharConexao();
            }
        }

        public bool editarCliente()
        {
            Banco b = new Banco();
            SqlConnection cn = b.abrirConexao();
            SqlTransaction transacao = cn.BeginTransaction();
            SqlCommand comando = new SqlCommand();

            comando.Connection = cn;
            comando.Transaction = transacao;
            comando.CommandType = CommandType.Text;

            comando.CommandText = "update clientes " +
                "set nome = @nome, cpf = @cpf, email = @email, endereco = @endereco, dataNasc = @dataNasc " +
                "where id = @id;";
            comando.Parameters.Add("@nome", SqlDbType.VarChar);
            comando.Parameters.Add("@cpf", SqlDbType.VarChar);
            comando.Parameters.Add("@email", SqlDbType.VarChar);
            comando.Parameters.Add("@endereco", SqlDbType.VarChar);
            comando.Parameters.Add("@dataNasc", SqlDbType.DateTime);
            comando.Parameters.Add("@id", SqlDbType.Int);
            comando.Parameters[0].Value = nome;
            comando.Parameters[1].Value = cpf;
            comando.Parameters[2].Value = email;
            comando.Parameters[3].Value = endereco;
            comando.Parameters[4].Value = dataNasc;
            comando.Parameters[5].Value = id;
            try
            {
                MessageBox.Show("Cliente editado com êxito!", "Sucesso");
                comando.ExecuteNonQuery();
                transacao.Commit();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao editar cliente!", "ERRO");
                transacao.Rollback();
                return false;
            }
            finally
            {
                b.fecharConexao();
            }
        }
    }
}
