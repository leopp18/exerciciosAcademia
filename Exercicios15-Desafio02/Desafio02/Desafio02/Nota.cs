using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Kernel.Geom;

namespace Desafio02
{
    internal class Nota
    {
        private int id;
        private int fk_cliente;
        private int fk_produto;
        private int quantidade;
        private float valorUnitario;
        private string descricao;
        private DateTime dataEmissao = DateTime.Now;

        public int Id { get => id; set => id = value; }
        public int Fk_cliente { get => fk_cliente; set => fk_cliente = value; }
        public int Fk_produto { get => fk_produto; set => fk_produto = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public int Quantidade { get => quantidade; set => quantidade = value; }

        public Nota(int fk_cliente, int fk_produto, int quantidade, float valorUnitario, string descricao)
        {
            this.fk_cliente = fk_cliente;
            this.fk_produto = fk_produto;
            this.quantidade = quantidade;
            this.valorUnitario = valorUnitario;
            this.descricao = descricao;
        }

        public bool gerarNota()
        {
            Banco b = new Banco();
            SqlConnection cn = b.abrirConexao();
            SqlTransaction transacao = cn.BeginTransaction();
            SqlCommand comando = new SqlCommand();

            comando.Connection = cn;
            comando.Transaction = transacao;
            comando.CommandType = CommandType.Text;

            comando.CommandText = "insert into notas values (@fk_cliente, @fk_produto, @quantidade, @valorUnitario, @descricao, @dataEmissao);";
            comando.Parameters.Add("@fk_cliente", SqlDbType.Int);
            comando.Parameters.Add("@fk_produto", SqlDbType.Int);
            comando.Parameters.Add("@quantidade", SqlDbType.Int);
            comando.Parameters.Add("@valorUnitario", SqlDbType.Money);
            comando.Parameters.Add("@descricao", SqlDbType.VarChar);
            comando.Parameters.Add("@dataEmissao", SqlDbType.DateTime);
            comando.Parameters[0].Value = fk_cliente;
            comando.Parameters[1].Value = fk_produto;
            comando.Parameters[2].Value = quantidade;
            comando.Parameters[3].Value = valorUnitario;
            comando.Parameters[4].Value = descricao;
            comando.Parameters[5].Value = dataEmissao;
            try
            {
                comando.ExecuteNonQuery();
                transacao.Commit();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao emitir nota!", "ERRO");
                transacao.Rollback();
                return false;
            }
            finally
            {
                b.fecharConexao();
            }
        }

        public bool gerarPdf(int numero, string cliente, string produto)
        {
            string pasta = null;
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if(fbd.ShowDialog() == DialogResult.OK)
            {
                pasta = fbd.SelectedPath;
            }

            string arquivo = @"\NotaFiscal" + numero + ".pdf";
            string download = pasta + arquivo;
            PdfWriter pdfw = new PdfWriter(download);
            var pdf = new PdfDocument(pdfw);
            var documento = new Document(pdf, PageSize.A4);
            try
            {
                Banco b = new Banco();
                
                documento.Add(new Paragraph("NOTA FISCAL"));
                documento.Add(new Paragraph("Número da nota: " + numero));
                documento.Add(new Paragraph("Cliente: " + cliente));
                documento.Add(new Paragraph("Produto: " + produto));
                documento.Add(new Paragraph("Quantidade: " + quantidade));
                documento.Add(new Paragraph("Valor unitário: " + valorUnitario.ToString("C")));
                documento.Add(new Paragraph("Descrição: " + descricao));
                documento.Add(new Paragraph("Data da emissão: " + dataEmissao));
                documento.Add(new Paragraph("Valor total: " + ((quantidade * valorUnitario).ToString("C"))));
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
            finally
            {
                documento.Close();
                pdf.Close();
            }
        }
    }
}
