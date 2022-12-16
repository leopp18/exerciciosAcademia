using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio02
{
    internal class Fornecedor
    {
        private int id;
        private string nome;
        private string cnpj;
        private string email;
        private string endereco;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Cnpj { get => cnpj; set => cnpj = value; }
        public string Email { get => email; set => email = value; }
        public string Endereco { get => endereco; set => endereco = value; }

        public Fornecedor(int id, string nome, string cnpj, string email, string endereco)
        {
            this.id = id;
            this.nome = nome;
            this.cnpj = cnpj;
            this.email = email;
            this.endereco = endereco;
        }
        public Fornecedor(string nome, string cnpj, string email, string endereco)
        {
            this.nome = nome;
            this.cnpj = cnpj;
            this.email = email;
            this.endereco = endereco;
        }

        public bool cadastrarFornecedor()
        {
            Banco b = new Banco();
            SqlConnection cn = b.abrirConexao();
            SqlTransaction transacao = cn.BeginTransaction();
            SqlCommand comando = new SqlCommand();

            comando.Connection = cn;
            comando.Transaction = transacao;
            comando.CommandType = CommandType.Text;

            comando.CommandText = "insert into fornecedores values (@nome, @cnpj, @email, @endereco);";
            comando.Parameters.Add("@nome", SqlDbType.VarChar);
            comando.Parameters.Add("@cnpj", SqlDbType.VarChar);
            comando.Parameters.Add("@email", SqlDbType.VarChar);
            comando.Parameters.Add("@endereco", SqlDbType.VarChar);
            comando.Parameters[0].Value = nome;
            comando.Parameters[1].Value = cnpj;
            comando.Parameters[2].Value = email;
            comando.Parameters[3].Value = endereco;
            try
            {
                MessageBox.Show("Fornecedor cadastrado com êxito!", "Sucesso");
                comando.ExecuteNonQuery();
                transacao.Commit();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao cadastrar fornecedor!", "ERRO");
                transacao.Rollback();
                return false;
            }
            finally
            {
                b.fecharConexao();
            }
        }

        public bool editarFornecedor()
        {
            Banco b = new Banco();
            SqlConnection cn = b.abrirConexao();
            SqlTransaction transacao = cn.BeginTransaction();
            SqlCommand comando = new SqlCommand();

            comando.Connection = cn;
            comando.Transaction = transacao;
            comando.CommandType = CommandType.Text;

            comando.CommandText = "update fornecedores " +
                "set nome = @nome, cnpj = @cnpj, email = @email, endereco = @endereco " +
                "where id = @id;";
            comando.Parameters.Add("@nome", SqlDbType.VarChar);
            comando.Parameters.Add("@cnpj", SqlDbType.VarChar);
            comando.Parameters.Add("@email", SqlDbType.VarChar);
            comando.Parameters.Add("@endereco", SqlDbType.VarChar);
            comando.Parameters.Add("@id", SqlDbType.Int);
            comando.Parameters[0].Value = nome;
            comando.Parameters[1].Value = cnpj;
            comando.Parameters[2].Value = email;
            comando.Parameters[3].Value = endereco;
            comando.Parameters[4].Value = id;
            try
            {
                MessageBox.Show("Fornecedor editado com êxito!", "Sucesso");
                comando.ExecuteNonQuery();
                transacao.Commit();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao editar fornecedor!", "ERRO");
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
