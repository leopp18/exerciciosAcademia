using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Kernel.Geom;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Document = iText.Layout.Document;

namespace Desafio02Entity
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
            Contexto contexto = new Contexto();
            List<Produto> lista = (from Produto p in contexto.Produtos select p).ToList<Produto>();
            dgvProdutos.DataSource = lista;
            List<Cliente> lista2 = (from Cliente c in contexto.Clientes select c).ToList<Cliente>();
            dgvClientes.DataSource = lista2;
            List<Nota> lista3 = (from Nota n in contexto.Notas select n).ToList<Nota>();
            dgvNotas.DataSource = lista3;
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
        }

        private void txtFiltroCli_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnEmitir_Click(object sender, EventArgs e)
        {
            try
            {
                Contexto contexto = new Contexto();
                Nota n = new Nota();
                n.FkCliente = int.Parse(dgvClientes.CurrentRow.Cells[0].Value.ToString());
                n.FkProduto = int.Parse(dgvProdutos.CurrentRow.Cells[0].Value.ToString());
                n.Quantidade = int.Parse(txtQuantidade.Text);
                n.ValorUnitario = decimal.Parse(txtValorUnitario.Text);
                n.Descricao = txtDescricao.Text;
                contexto.Notas.Add(n);
                contexto.SaveChanges();

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
                numero+=2;
                if(n.gerarPdf(numero, txtCliente.Text, txtProduto.Text))
                {
                    MessageBox.Show("Nota fiscal emitida com êxito! PDF gerado na pasta indicada.", "Sucesso");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro!");
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
