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
    public partial class FornecedorForm : Form
    {
        public FornecedorForm()
        {
            InitializeComponent();
            atualizarView();
        }

        private void atualizarView()
        {
            Contexto contexto = new Contexto();
            List<Fornecedor> lista = (from Fornecedor f in contexto.Fornecedores select f).ToList<Fornecedor>();
            dataGridView1.DataSource = lista;
            txtId.Text = String.Empty;
            txtNome.Text = String.Empty;
            txtCnpj.Text = String.Empty;
            txtEmail.Text = String.Empty;
            txtEndereco.Text = String.Empty;
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
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            string nome = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string cnpj = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            string email = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            string endereco = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtId.Text = id.ToString();
            txtNome.Text = nome;
            txtCnpj.Text = cnpj;
            txtEmail.Text = email;
            txtEndereco.Text = endereco;
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
                    Fornecedor f = new Fornecedor();
                    f.Nome = txtNome.Text;
                    f.Cnpj = txtCnpj.Text;
                    f.Email = txtEmail.Text;
                    f.Endereco = txtEndereco.Text;
                    contexto.Fornecedores.Add(f);
                    contexto.SaveChanges();
                    MessageBox.Show("Fornecedor cadastrado com êxito!", "Sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message, "Erro!");
                }
            }
            else if (btnEditar.Enabled == true)
            {
                try
                {
                    int id = int.Parse(txtId.Text);
                    Fornecedor f = contexto.Fornecedores.Find(id);
                    f.Nome = txtNome.Text;
                    f.Cnpj = txtCnpj.Text;
                    f.Email = txtEmail.Text;
                    f.Endereco = txtEndereco.Text;
                    contexto.Fornecedores.Update(f);
                    contexto.SaveChanges();
                    MessageBox.Show("Fornecedor alterado com êxito!", "Sucesso!");
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
            var resultado = MessageBox.Show("Tem certeza que deseja excluir este fornecedor?", "Exclusão",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                try
                {
                    Contexto contexto = new Contexto();
                    Fornecedor f = contexto.Fornecedores.Find(id);
                    contexto.Fornecedores.Remove(f);
                    contexto.SaveChanges();
                    Console.WriteLine("Fornecedor excluído com êxito!", "Sucesso!");
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

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProdutoForm pf = new ProdutoForm();
            this.Close();
            pf.Show();
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

        private void txtFiltroCli_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
