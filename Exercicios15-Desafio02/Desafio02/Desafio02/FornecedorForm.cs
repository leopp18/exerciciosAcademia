using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Desafio02
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
            Banco b = new Banco();
            DataTable dt = new DataTable();

            dt = b.executaConsulta("select id as 'Código', nome as 'Empresa', cnpj as 'CNPJ', email as 'E-mail', " +
                "endereco as 'Endereço' from fornecedores order by nome");
            dataGridView1.DataSource = dt;
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
            Fornecedor f = new Fornecedor(nome, cnpj, email, endereco);
            pnlDados.Enabled = true;
            btnCadastrar.Enabled = false;
            btnDeletar.Enabled = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string cnpj = txtCnpj.Text;
            string email = txtEmail.Text;
            string endereco = txtEndereco.Text;
            if (btnCadastrar.Enabled == true)
            {
                Fornecedor f = new Fornecedor(nome, cnpj, email, endereco);
                f.cadastrarFornecedor();
            }
            else if (btnEditar.Enabled == true)
            {
                int id = int.Parse(txtId.Text);
                Fornecedor f = new Fornecedor(id, nome, cnpj, email, endereco);
                f.editarFornecedor();
            }
            else { }
            atualizarView();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Tem certeza que deseja excluir este fornecedor?", "Exclusão",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes) {
                Banco b = new Banco();
                int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                string tabela = "fornecedores";
                b.excluirDado(id, tabela);
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
            Banco b = new Banco();
            DataTable dt = new DataTable();
            string filtro = txtFiltroCli.Text;
            dt = b.executaConsulta("select id as 'Código', nome as 'Empresa', cnpj as 'CNPJ', email as 'E-mail', endereco as 'Endereço' from " +
                "fornecedores where nome like '" + filtro + "%' order by nome");
            dataGridView1.DataSource = dt;
        }
    }
}
