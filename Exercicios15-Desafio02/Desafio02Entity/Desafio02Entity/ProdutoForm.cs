using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio02Entity
{
    public partial class ProdutoForm : Form
    {
        public ProdutoForm()
        {
            InitializeComponent();
            atualizarView();
        }
        private void atualizarView()
        {
            Contexto contexto = new Contexto();
            List<Produto> lista = (from Produto p in contexto.Produtos select p).ToList<Produto>();
            dgvProdutos.DataSource = lista;
            List<Fornecedor> lista2 = (from Fornecedor f in contexto.Fornecedores select f).ToList<Fornecedor>();
            dgvFornecedores.DataSource = lista2;
            txtId.Text = String.Empty;
            txtNome.Text = String.Empty;
            txtValor.Text = String.Empty;
            txtFkFornecedor.Text = String.Empty;
            btnCadastrar.Enabled = true;
            btnEditar.Enabled = true;
            btnDeletar.Enabled = true;
            pnlDados.Enabled = false;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            pnlDados.Enabled = true;
            btnEditar.Enabled = false;
            btnDeletar.Enabled = false;
            int fkFornecedor = int.Parse(dgvFornecedores.CurrentRow.Cells[0].Value.ToString());
            txtFkFornecedor.Text = fkFornecedor.ToString();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgvProdutos.CurrentRow.Cells[0].Value.ToString());
            string nome = dgvProdutos.CurrentRow.Cells[1].Value.ToString();
            float valor = float.Parse(dgvProdutos.CurrentRow.Cells[2].Value.ToString());
            int fkFornecedor = int.Parse(dgvFornecedores.CurrentRow.Cells[0].Value.ToString());
            txtId.Text = id.ToString();
            txtNome.Text = nome;
            txtValor.Text = valor.ToString();
            txtFkFornecedor.Text = fkFornecedor.ToString();
            pnlDados.Enabled = true;
            btnCadastrar.Enabled = false;
            btnDeletar.Enabled = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Contexto contexto = new Contexto();
            if (btnCadastrar.Enabled == true)
            {
                try
                {
                    Produto p = new Produto();
                    p.Nome = txtNome.Text;
                    p.Valor = decimal.Parse(txtValor.Text);
                    p.FkFornecedor = int.Parse(txtFkFornecedor.Text);
                    contexto.Produtos.Add(p);
                    contexto.SaveChanges();
                    MessageBox.Show("Produto cadastrado com êxito!", "Sucesso!");
                }catch(Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message, "Erro!");
                }
            }
            else if (btnEditar.Enabled == true)
            {
                try
                {
                    int id = int.Parse(txtId.Text);
                    Produto p = contexto.Produtos.Find(id);
                    p.Nome = txtNome.Text;
                    p.Valor = decimal.Parse(txtValor.Text);
                    p.FkFornecedor = int.Parse(txtFkFornecedor.Text);
                    contexto.Produtos.Update(p);
                    contexto.SaveChanges();
                    MessageBox.Show("Produto alterado com êxito!", "Sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message, "Erro!");
                }
            }
            else { }
            atualizarView();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Tem certeza que deseja excluir este produto?", "Exclusão",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                int id = int.Parse(dgvProdutos.CurrentRow.Cells[0].Value.ToString());
                try
                {
                    Contexto contexto = new Contexto();
                    Produto p = contexto.Produtos.Find(id);
                    contexto.Produtos.Remove(p);
                    contexto.SaveChanges();
                    Console.WriteLine("Produto excluído com êxito!", "Sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message, "Erro");
                }
            }
            else
            {
                return;
            }
            atualizarView();
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FornecedorForm ff = new FornecedorForm();
            this.Close();
            ff.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClienteForm cf = new ClienteForm();
            this.Close();
            cf.Show();
        }

        private void emissãoDeNotaFiscalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NotaForm nf = new NotaForm();
            this.Close();
            nf.Show();
        }

        private void dgvFornecedores_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
        }

        private void txtFiltroCli_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtFiltroForn_TextChanged(object sender, EventArgs e)
        {
        }

        private void dgvFornecedores_MouseClick(object sender, MouseEventArgs e)
        {
            int fkFornecedor = int.Parse(dgvFornecedores.CurrentRow.Cells[0].Value.ToString());
            txtFkFornecedor.Text = fkFornecedor.ToString();
        }
    }
}
