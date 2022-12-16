using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using System;
using System.Collections.Generic;

namespace Desafio02Entity;

public partial class Nota
{
    public int Id { get; set; }

    public int FkCliente { get; set; }

    public int FkProduto { get; set; }

    public int Quantidade { get; set; }

    public decimal ValorUnitario { get; set; }

    public string? Descricao { get; set; }

    public DateTime DataEmissao = DateTime.Now;

    public virtual Cliente FkClienteNavigation { get; set; } = null!;

    public virtual Produto FkProdutoNavigation { get; set; } = null!;


    public bool gerarPdf(int numero, string cliente, string produto)
    {
        string pasta = null;
        FolderBrowserDialog fbd = new FolderBrowserDialog();
        if (fbd.ShowDialog() == DialogResult.OK)
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
            documento.Add(new Paragraph("NOTA FISCAL"));
            documento.Add(new Paragraph("Número da nota: " + numero));
            documento.Add(new Paragraph("Cliente: " + cliente));
            documento.Add(new Paragraph("Produto: " + produto));
            documento.Add(new Paragraph("Quantidade: " + Quantidade));
            documento.Add(new Paragraph("Valor unitário: " + ValorUnitario.ToString("C")));
            documento.Add(new Paragraph("Descrição: " + Descricao));
            documento.Add(new Paragraph("Data da emissão: " + DataEmissao));
            documento.Add(new Paragraph("Valor total: " + ((Quantidade * ValorUnitario).ToString("C"))));
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
