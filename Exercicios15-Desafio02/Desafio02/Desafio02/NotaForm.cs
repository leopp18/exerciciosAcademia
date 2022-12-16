using iText.Layout.Element;
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
    public partial class NotaForm : Form
    {
        public NotaForm()
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
            dgvClientes.DataSource = dt;
            dt = b.executaConsulta("select produtos.id as 'Código', produtos.nome as 'Produto', valor as 'Preço', fornecedores.nome as 'Fornecedor', " +
                "fk_fornecedor as 'Código do fornecedor' from produtos inner join fornecedores on produtos.fk_fornecedor = fornecedores.id order by produtos.nome");
            dgvProdutos.DataSource = dt;
            dt = b.executaConsulta("select notas.id as 'Código', clientes.nome as 'Cliente', produtos.nome as 'Produto', quantidade as 'Quantidade', notas.valorUnitario as 'Valor unitário', " +
                "descricao as 'Descrição', dataEmissao as 'Data de emissão', quantidade * valorUnitario as 'Valor total' from notas inner join clientes " +
                "on notas.fk_cliente = clientes.id inner join produtos on produtos.id = notas.fk_produto");
            dgvNotas.DataSource = dt;
            txtFiltroCli.Text = String.Empty;
            txtFiltroProd.Text = String.Empty;
            txtCliente.Text = String.Empty;
            txtProduto.Text = String.Empty;
            txtQuantidade.Text = String.Empty;
            txtValorUnitario.Text = String.Empty;
            txtDescricao.Text = String.Empty;
            txtValorTotal.Text = String.Empty;
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

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClienteForm cf = new ClienteForm();
            this.Close();
            cf.Show();
        }

        private void txtFiltroProd_TextChanged(object sender, EventArgs e)
        {
            Banco b = new Banco();
            DataTable dt = new DataTable();
            string filtro = txtFiltroProd.Text;
            dt = b.executaConsulta("select produtos.id as 'Código', produtos.nome as 'Produto', valor as 'Preço', fornecedores.nome as 'Fornecedor', " +
                "fk_fornecedor as 'Código do fornecedor' from produtos inner join fornecedores on " +
                "produtos.fk_fornecedor = fornecedores.id where produtos.nome like '" + filtro + "%' order by produtos.nome");
            dgvProdutos.DataSource = dt;
        }

        private void txtFiltroCli_TextChanged(object sender, EventArgs e)
        {
            Banco b = new Banco();
            DataTable dt = new DataTable();
            string filtro = txtFiltroCli.Text;
            dt = b.executaConsulta("select id as 'Código', nome as 'Cliente', cpf as 'CPF', email as 'E-mail', endereco as 'Endereço', " +
                "dataNasc as 'Data de nascimento' from clientes where nome like '" + filtro + "%' order by nome");
            dgvClientes.DataSource = dt;
        }

        private void btnEmitir_Click(object sender, EventArgs e)
        {
            int fkCliente = int.Parse(dgvClientes.CurrentRow.Cells[0].Value.ToString());
            int fkProduto = int.Parse(dgvProdutos.CurrentRow.Cells[0].Value.ToString());
            int quantidade = int.Parse(txtQuantidade.Text);
            float valorUnitario = float.Parse(txtValorUnitario.Text);
            string descricao = txtDescricao.Text;
            Nota n = new Nota(fkCliente, fkProduto, quantidade, valorUnitario, descricao);
            if (n.gerarNota())
            {
                int numero = 0;
                int aux = 0;
                for (int i = 1; i < dgvNotas.Rows.Count - 1; i++)
                {
                    aux = int.Parse(dgvNotas.Rows[i].Cells[0].Value.ToString());
                    if (aux > numero)
                    {
                        numero = aux;
                    }
                }
                numero++;
                n.gerarPdf(numero, txtCliente.Text, txtProduto.Text);
                MessageBox.Show("Nota fiscal emitida com êxito! PDF gerado na pasta indicada.", "Sucesso");
            }
            atualizarView();
        }

        private void dgvClientes_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string cliente = dgvClientes.CurrentRow.Cells[1].Value.ToString();
            txtCliente.Text = cliente;
        }

        private void dgvProdutos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string produto = dgvProdutos.CurrentRow.Cells[1].Value.ToString();
            txtProduto.Text = produto;
        }

        private void txtQuantidade_TextChanged(object sender, EventArgs e)
        {
            float valorUnitario;
            bool tentatbm = float.TryParse(txtValorUnitario.Text, out valorUnitario);
            int quantidade;
            bool tenta = int.TryParse(txtQuantidade.Text, out quantidade);
            txtValorTotal.Text = (quantidade * valorUnitario).ToString("C");
        }

        private void txtValorUnitario_TextChanged(object sender, EventArgs e)
        {
            float valorUnitario;
            bool op1 = float.TryParse(txtValorUnitario.Text, out valorUnitario);
            int quantidade;
            bool op2 = int.TryParse(txtQuantidade.Text, out quantidade);
            txtValorTotal.Text = (quantidade * valorUnitario).ToString("C");
        }
    }
}
