using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio02
{
    internal class Produto
    {
        private int id;
        private string nome;
        private float valor;
        private int fk_fornecedor;
        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public float Valor { get => valor; set => valor = value; }
        public int Fk_fornecedor { get => fk_fornecedor; set => fk_fornecedor = value; }

        public Produto(int id, string nome, float valor, int fk_fornecedor)
        {
            this.id = id;
            this.nome = nome;
            this.valor = valor;
            this.fk_fornecedor = fk_fornecedor;
        }

        public Produto(string nome, float valor, int fk_fornecedor)
        {
            this.nome = nome;
            this.valor = valor;
            this.fk_fornecedor = fk_fornecedor;
        }

        public bool cadastrarProduto()
        {
            Banco b = new Banco();
            SqlConnection cn = b.abrirConexao();
            SqlTransaction transacao = cn.BeginTransaction();
            SqlCommand comando = new SqlCommand();

            comando.Connection = cn;
            comando.Transaction = transacao;
            comando.CommandType = CommandType.Text;

            comando.CommandText = "insert into produtos values (@nome, @valor, @fk_fornecedor);";
            comando.Parameters.Add("@nome", SqlDbType.VarChar);
            comando.Parameters.Add("@valor", SqlDbType.Money);
            comando.Parameters.Add("@fk_fornecedor", SqlDbType.Int);
            comando.Parameters[0].Value = nome;
            comando.Parameters[1].Value = valor;
            comando.Parameters[2].Value = fk_fornecedor;
            try
            {
                MessageBox.Show("Produto cadastrado com êxito!", "Sucesso");
                comando.ExecuteNonQuery();
                transacao.Commit();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao cadastrar produto!", "ERRO");
                transacao.Rollback();
                return false;
            }
            finally
            {
                b.fecharConexao();
            }
        }

        public bool editarProduto()
        {
            Banco b = new Banco();
            SqlConnection cn = b.abrirConexao();
            SqlTransaction transacao = cn.BeginTransaction();
            SqlCommand comando = new SqlCommand();

            comando.Connection = cn;
            comando.Transaction = transacao;
            comando.CommandType = CommandType.Text;

            comando.CommandText = "update produtos " +
                "set nome = @nome, valor = @valor, fk_fornecedor = @fk_fornecedor " +
                "where id = @id;";
            comando.Parameters.Add("@nome", SqlDbType.VarChar);
            comando.Parameters.Add("@valor", SqlDbType.Money);
            comando.Parameters.Add("@fk_fornecedor", SqlDbType.Int);
            comando.Parameters.Add("@id", SqlDbType.Int);
            comando.Parameters[0].Value = nome;
            comando.Parameters[1].Value = valor;
            comando.Parameters[2].Value = fk_fornecedor;
            comando.Parameters[3].Value = id;
            try
            {
                MessageBox.Show("Produto editado com êxito!", "Sucesso");
                comando.ExecuteNonQuery();
                transacao.Commit();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao editar produto!", "ERRO");
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
