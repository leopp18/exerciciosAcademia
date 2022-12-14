namespace Desafio02
{
    partial class ProdutoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuDePáginasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emissãoDeNotaFiscalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.pnlDados = new System.Windows.Forms.Panel();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtFkFornecedor = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.dgvFornecedores = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFiltroProd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFiltroForn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.pnlDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedores)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDePáginasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(911, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuDePáginasToolStripMenuItem
            // 
            this.menuDePáginasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fornecedoresToolStripMenuItem,
            this.produtosToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.emissãoDeNotaFiscalToolStripMenuItem});
            this.menuDePáginasToolStripMenuItem.Name = "menuDePáginasToolStripMenuItem";
            this.menuDePáginasToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.menuDePáginasToolStripMenuItem.Text = "Menu de páginas";
            // 
            // fornecedoresToolStripMenuItem
            // 
            this.fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
            this.fornecedoresToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.fornecedoresToolStripMenuItem.Text = "Fornecedores";
            this.fornecedoresToolStripMenuItem.Click += new System.EventHandler(this.fornecedoresToolStripMenuItem_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.produtosToolStripMenuItem.Text = "Produtos";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // emissãoDeNotaFiscalToolStripMenuItem
            // 
            this.emissãoDeNotaFiscalToolStripMenuItem.Name = "emissãoDeNotaFiscalToolStripMenuItem";
            this.emissãoDeNotaFiscalToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.emissãoDeNotaFiscalToolStripMenuItem.Text = "Emissão de nota fiscal";
            this.emissãoDeNotaFiscalToolStripMenuItem.Click += new System.EventHandler(this.emissãoDeNotaFiscalToolStripMenuItem_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(197, 22);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(144, 23);
            this.txtId.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(124, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Código:";
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(21, 107);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.RowHeadersWidth = 60;
            this.dgvProdutos.RowTemplate.Height = 25;
            this.dgvProdutos.Size = new System.Drawing.Size(532, 208);
            this.dgvProdutos.TabIndex = 29;
            // 
            // pnlDados
            // 
            this.pnlDados.Controls.Add(this.txtId);
            this.pnlDados.Controls.Add(this.label2);
            this.pnlDados.Controls.Add(this.btnSalvar);
            this.pnlDados.Controls.Add(this.txtFkFornecedor);
            this.pnlDados.Controls.Add(this.txtValor);
            this.pnlDados.Controls.Add(this.txtNome);
            this.pnlDados.Controls.Add(this.label5);
            this.pnlDados.Controls.Add(this.label6);
            this.pnlDados.Controls.Add(this.label7);
            this.pnlDados.Enabled = false;
            this.pnlDados.Location = new System.Drawing.Point(147, 387);
            this.pnlDados.Name = "pnlDados";
            this.pnlDados.Size = new System.Drawing.Size(449, 216);
            this.pnlDados.TabIndex = 5;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(216, 177);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(98, 23);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtFkFornecedor
            // 
            this.txtFkFornecedor.Location = new System.Drawing.Point(197, 118);
            this.txtFkFornecedor.Name = "txtFkFornecedor";
            this.txtFkFornecedor.ReadOnly = true;
            this.txtFkFornecedor.Size = new System.Drawing.Size(144, 23);
            this.txtFkFornecedor.TabIndex = 19;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(197, 84);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(144, 23);
            this.txtValor.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(197, 51);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(144, 23);
            this.txtNome.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(25, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Código do fornecedor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(139, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Valor:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(132, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Nome:";
            // 
            // btnDeletar
            // 
            this.btnDeletar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeletar.Location = new System.Drawing.Point(463, 342);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(90, 28);
            this.btnDeletar.TabIndex = 4;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditar.Location = new System.Drawing.Point(242, 342);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(90, 28);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrar.Location = new System.Drawing.Point(21, 342);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(92, 28);
            this.btnCadastrar.TabIndex = 2;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // dgvFornecedores
            // 
            this.dgvFornecedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFornecedores.Location = new System.Drawing.Point(594, 107);
            this.dgvFornecedores.Name = "dgvFornecedores";
            this.dgvFornecedores.RowHeadersWidth = 75;
            this.dgvFornecedores.RowTemplate.Height = 25;
            this.dgvFornecedores.Size = new System.Drawing.Size(305, 208);
            this.dgvFornecedores.TabIndex = 30;
            this.dgvFornecedores.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvFornecedores_CellMouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(22, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "Pesquisar:";
            // 
            // txtFiltroProd
            // 
            this.txtFiltroProd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFiltroProd.Location = new System.Drawing.Point(101, 76);
            this.txtFiltroProd.Name = "txtFiltroProd";
            this.txtFiltroProd.Size = new System.Drawing.Size(100, 25);
            this.txtFiltroProd.TabIndex = 0;
            this.txtFiltroProd.TextChanged += new System.EventHandler(this.txtFiltroCli_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(595, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "Pesquisar:";
            // 
            // txtFiltroForn
            // 
            this.txtFiltroForn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFiltroForn.Location = new System.Drawing.Point(674, 76);
            this.txtFiltroForn.Name = "txtFiltroForn";
            this.txtFiltroForn.Size = new System.Drawing.Size(100, 25);
            this.txtFiltroForn.TabIndex = 1;
            this.txtFiltroForn.TextChanged += new System.EventHandler(this.txtFiltroForn_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(218, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 30);
            this.label4.TabIndex = 35;
            this.label4.Text = "PRODUTOS";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(674, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(174, 30);
            this.label8.TabIndex = 36;
            this.label8.Text = "FORNECEDORES";
            // 
            // ProdutoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(911, 614);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFiltroForn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFiltroProd);
            this.Controls.Add(this.dgvFornecedores);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.pnlDados);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ProdutoForm";
            this.Text = "Produto";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.pnlDados.ResumeLayout(false);
            this.pnlDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuDePáginasToolStripMenuItem;
        private ToolStripMenuItem fornecedoresToolStripMenuItem;
        private ToolStripMenuItem produtosToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem emissãoDeNotaFiscalToolStripMenuItem;
        private TextBox txtId;
        private Label label2;
        private DataGridView dgvProdutos;
        private Panel pnlDados;
        private Button btnSalvar;
        private TextBox txtFkFornecedor;
        private TextBox txtValor;
        private TextBox txtNome;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btnDeletar;
        private Button btnEditar;
        private Button btnCadastrar;
        private DataGridView dgvFornecedores;
        private Label label3;
        private TextBox txtFiltroProd;
        private Label label1;
        private TextBox txtFiltroForn;
        private Label label4;
        private Label label8;
    }
}