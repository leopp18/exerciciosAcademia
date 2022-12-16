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
    public partial class ProdutoForm : Form
    {
        public ProdutoForm()
        {
            InitializeComponent();
            atualizarView();
        }
        private void atualizarView()
        {
            Banco b = new Banco();
            DataTable dt = new DataTable();

            dt = b.executaConsulta("select produtos.id as 'Código', produtos.nome as 'Produto', valor as 'Preço', fornecedores.nome as 'Fornecedor', " +
                "fk_fornecedor as 'Código do fornecedor' from produtos inner join fornecedores on produtos.fk_fornecedor = fornecedores.id order by produtos.nome");
            dgvProdutos.DataSource = dt;
            dt = b.executaConsulta("select id as 'Código', nome as 'Empresa' from fornecedores order by nome");
            dgvFornecedores.DataSource = dt;
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
            Produto p = new Produto(nome, valor, fkFornecedor);
            pnlDados.Enabled = true;
            btnCadastrar.Enabled = false;
            btnDeletar.Enabled = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            float valor = float.Parse(txtValor.Text);
            int fkFornecedor = int.Parse(txtFkFornecedor.Text);
            if (btnCadastrar.Enabled == true)
            {
                Produto p = new Produto(nome, valor, fkFornecedor);
                p.cadastrarProduto();
            }
            else if (btnEditar.Enabled == true)
            {
                int id = int.Parse(txtId.Text);
                Produto p = new Produto(id, nome, valor, fkFornecedor);
                p.editarProduto();
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
                Banco b = new Banco();
                int id = int.Parse(dgvProdutos.CurrentRow.Cells[0].Value.ToString());
                b.excluirDado(id, "produtos");
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
            int fkFornecedor = int.Parse(dgvFornecedores.CurrentRow.Cells[0].Value.ToString());
            txtFkFornecedor.Text = fkFornecedor.ToString();
        }

        private void txtFiltroCli_TextChanged(object sender, EventArgs e)
        {
            Banco b = new Banco();
            DataTable dt = new DataTable();
            string filtro = txtFiltroProd.Text;
            dt = b.executaConsulta("select produtos.id as 'Código', produtos.nome as 'Produto', valor as 'Preço', fornecedores.nome as 'Fornecedor', " +
                "fk_fornecedor as 'Código do fornecedor' from produtos inner join fornecedores on produtos.fk_fornecedor = fornecedores.id where " +
                "produtos.nome like '" + filtro + "%' order by produtos.nome");
            dgvProdutos.DataSource = dt;
        }

        private void txtFiltroForn_TextChanged(object sender, EventArgs e)
        {
            Banco b = new Banco();
            DataTable dt = new DataTable();
            string filtro = txtFiltroForn.Text;
            dt = b.executaConsulta("select id as 'Código', nome as 'Empresa' from fornecedores where nome like '" + filtro + "%' order by nome");
            dgvFornecedores.DataSource = dt;
        }
    }
}
