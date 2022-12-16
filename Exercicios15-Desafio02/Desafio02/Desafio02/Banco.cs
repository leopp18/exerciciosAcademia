using System.Data;
using System.Data.SqlClient;

namespace Desafio02
{
    internal class Banco
    {
        private string user = "usuario";
        private string password = "senha";
        private string db = "desafio02";
        private string conec = "";

        private SqlConnection cn;

        public global::System.String User { get => user; set => user = value; }
        public global::System.String Password { get => password; set => password = value; }
        public string Db { get => db; set => db = value; }

        private void conexao()
        {
            conec = "Data Source=localhost;" +
            "Initial Catalog=" + db + ";" + "User ID=" +
            user + ";password =" +
            password + ";" +
            "Language=Portuguese";

            cn = new SqlConnection(conec);
        }

        public SqlConnection abrirConexao()
        {
            try
            {
                conexao();
                cn.Open();
                return cn;
            }
            catch (Exception e)
            {
                return null;
            }

        }

        public void fecharConexao()
        {
            try
            {
                cn.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public DataTable executaConsulta(string sql)
        {
            try
            {
                abrirConexao();
                SqlCommand comando = new SqlCommand(sql, cn);
                comando.ExecuteNonQuery();
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                fecharConexao();
            }
        }

        public bool excluirDado(int id, string tabela)
        {
            Banco b = new Banco();
            SqlConnection cn = b.abrirConexao();
            SqlTransaction transacao = cn.BeginTransaction();
            SqlCommand comando = new SqlCommand();

            comando.Connection = cn;
            comando.Transaction = transacao;
            comando.CommandType = CommandType.Text;

            comando.CommandText = "delete from " + tabela + " where id = @id;";
            //comando.Parameters.Add("@tabela", SqlDbType.VarChar);
            comando.Parameters.Add("@id", SqlDbType.Int);
            //comando.Parameters[0].Value = tabela;
            comando.Parameters[0].Value = id;
            try
            {
                comando.ExecuteNonQuery();
                transacao.Commit();
                MessageBox.Show("Dado excluído com êxito!", "Sucesso");
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao excluir dado!", "ERRO");
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
