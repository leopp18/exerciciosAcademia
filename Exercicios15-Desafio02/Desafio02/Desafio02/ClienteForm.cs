using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio02
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
            Banco b = new Banco();
            DataTable dt = new DataTable();

            dt = b.executaConsulta("select id as 'Código', nome as 'Cliente', cpf as 'CPF', email as 'E-mail', " +
                "endereco as 'Endereço', dataNasc as 'Data de nascimento' from clientes order by nome");
            dataGridView1.DataSource = dt;
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
            //Cliente c = new Cliente(nome, cpf, email, endereco, data);
            pnlDados.Enabled = true;
            btnCadastrar.Enabled = false;
            btnDeletar.Enabled = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string cpf = txtCpf.Text;
            string email = txtEmail.Text;
            string endereco = txtEndereco.Text;
            string data = txtNascimento.Text;
            if (btnCadastrar.Enabled == true)
            {
                Cliente c = new Cliente(nome, cpf, email, endereco, data);
                c.cadastrarCliente();
            }
            else if (btnEditar.Enabled == true)
            {
                int id = int.Parse(txtId.Text);
                Cliente c = new Cliente(id, nome, cpf, email, endereco, data);
                c.editarCliente();
            }
            else { }
            atualizarView();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Tem certeza que deseja excluir este cliente?", "Exclusão",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Banco b = new Banco();
                int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                string tabela = "clientes";
                b.excluirDado(id, tabela);
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
            Banco b = new Banco();
            DataTable dt = new DataTable();
            string filtro = txtFiltroCli.Text;
            dt = b.executaConsulta("select id as 'Código', nome as 'Cliente', cpf as 'CPF', email as 'E-mail', endereco as 'Endereço', " +
                "dataNasc as 'Data de nascimento' from clientes where nome like '" + filtro + "%' order by nome");
            dataGridView1.DataSource = dt;
        }
    }
}
