using Microsoft.EntityFrameworkCore;
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
    public partial class ClienteForm : Form
    {
        public ClienteForm()
        {
            InitializeComponent();
            atualizarView();
        }

        private void atualizarView()
        {
            Contexto contexto = new Contexto();
            List<Cliente> lista = (from Cliente c in contexto.Clientes select c).ToList<Cliente>();
            dataGridView1.DataSource = lista;
            txtId.Text = String.Empty;
            txtNome.Text = String.Empty;
            txtCpf.Text = String.Empty;
            txtEmail.Text = String.Empty;
            txtEndereco.Text = String.Empty;
            txtNascimento.Text = String.Empty;
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
            string cpf = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            string email = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            string endereco = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            string data = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtId.Text = id.ToString();
            txtNome.Text = nome;
            txtCpf.Text = cpf;
            txtEmail.Text = email;
            txtEndereco.Text = endereco;
            txtNascimento.Text = data;
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
                    Cliente c = new Cliente();
                    c.Nome = txtNome.Text;
                    c.Cpf = txtCpf.Text;
                    c.Email = txtEmail.Text;
                    c.Endereco = txtEndereco.Text;
                    c.DataNasc = DateTime.Parse(txtNascimento.Text);
                    contexto.Clientes.Add(c);
                    contexto.SaveChanges();
                    MessageBox.Show("Cliente cadastrado com êxito!", "Sucesso!");
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
                    Cliente c = contexto.Clientes.Find(id);
                    c.Nome = txtNome.Text;
                    c.Cpf = txtCpf.Text;
                    c.Email = txtEmail.Text;
                    c.Endereco = txtEndereco.Text;
                    c.DataNasc = DateTime.Parse(txtNascimento.Text);
                    contexto.Clientes.Update(c);
                    contexto.SaveChanges();
                    MessageBox.Show("Cliente alterado com êxito!", "Sucesso!");
                }catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message, "Erro!");
                }
            }
            else { }
            atualizarView();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Tem certeza que deseja excluir este cliente?", "Exclusão",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            Contexto contexto = new Contexto();
            if (resultado == DialogResult.Yes)
            {
                int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                try
                {
                    Cliente c = contexto.Clientes.Find(id);
                    contexto.Clientes.Remove(c);
                    contexto.SaveChanges();
                    Console.WriteLine("Cliente excluído com êxito!", "Sucesso!");
                }catch(Exception ex)
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

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProdutoForm pf = new ProdutoForm();
            this.Close();
            pf.Show();
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
