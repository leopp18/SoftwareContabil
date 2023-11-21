namespace Contabil
{
    partial class CustoLucroForm
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
            label4 = new Label();
            dgvProdutos = new DataGridView();
            menuStrip1 = new MenuStrip();
            menuDeOpçõesToolStripMenuItem = new ToolStripMenuItem();
            cadastrarProdutoToolStripMenuItem = new ToolStripMenuItem();
            venderProdutoToolStripMenuItem = new ToolStripMenuItem();
            btnConsultar = new Button();
            txtIcmsVenda = new TextBox();
            label3 = new Label();
            txtIcmsCompra = new TextBox();
            label5 = new Label();
            txtValorVenda = new TextBox();
            label1 = new Label();
            txtId = new TextBox();
            label2 = new Label();
            txtValorCompra = new TextBox();
            txtNome = new TextBox();
            label6 = new Label();
            label7 = new Label();
            txtCusto = new TextBox();
            label8 = new Label();
            txtLucro = new TextBox();
            label9 = new Label();
            dREToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(318, 57);
            label4.Name = "label4";
            label4.Size = new Size(162, 37);
            label4.TabIndex = 56;
            label4.Text = "PRODUTOS";
            // 
            // dgvProdutos
            // 
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Location = new Point(102, 117);
            dgvProdutos.Margin = new Padding(3, 4, 3, 4);
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.RowHeadersWidth = 60;
            dgvProdutos.RowTemplate.Height = 25;
            dgvProdutos.Size = new Size(666, 277);
            dgvProdutos.TabIndex = 55;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuDeOpçõesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(882, 28);
            menuStrip1.TabIndex = 57;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuDeOpçõesToolStripMenuItem
            // 
            menuDeOpçõesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarProdutoToolStripMenuItem, venderProdutoToolStripMenuItem, dREToolStripMenuItem });
            menuDeOpçõesToolStripMenuItem.Name = "menuDeOpçõesToolStripMenuItem";
            menuDeOpçõesToolStripMenuItem.Size = new Size(135, 24);
            menuDeOpçõesToolStripMenuItem.Text = "Menu de Opções";
            // 
            // cadastrarProdutoToolStripMenuItem
            // 
            cadastrarProdutoToolStripMenuItem.Name = "cadastrarProdutoToolStripMenuItem";
            cadastrarProdutoToolStripMenuItem.Size = new Size(224, 26);
            cadastrarProdutoToolStripMenuItem.Text = "Cadastrar produto";
            cadastrarProdutoToolStripMenuItem.Click += cadastrarProdutoToolStripMenuItem_Click;
            // 
            // venderProdutoToolStripMenuItem
            // 
            venderProdutoToolStripMenuItem.Name = "venderProdutoToolStripMenuItem";
            venderProdutoToolStripMenuItem.Size = new Size(224, 26);
            venderProdutoToolStripMenuItem.Text = "Vender produto";
            venderProdutoToolStripMenuItem.Click += venderProdutoToolStripMenuItem_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnConsultar.Location = new Point(96, 402);
            btnConsultar.Margin = new Padding(3, 4, 3, 4);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(105, 37);
            btnConsultar.TabIndex = 59;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click_1;
            // 
            // txtIcmsVenda
            // 
            txtIcmsVenda.Location = new Point(604, 578);
            txtIcmsVenda.Margin = new Padding(3, 4, 3, 4);
            txtIcmsVenda.Name = "txtIcmsVenda";
            txtIcmsVenda.Size = new Size(164, 27);
            txtIcmsVenda.TabIndex = 70;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(456, 580);
            label3.Name = "label3";
            label3.Size = new Size(142, 25);
            label3.TabIndex = 71;
            label3.Text = "ICMS de venda:";
            // 
            // txtIcmsCompra
            // 
            txtIcmsCompra.Location = new Point(263, 581);
            txtIcmsCompra.Margin = new Padding(3, 4, 3, 4);
            txtIcmsCompra.Name = "txtIcmsCompra";
            txtIcmsCompra.Size = new Size(164, 27);
            txtIcmsCompra.TabIndex = 68;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(102, 580);
            label5.Name = "label5";
            label5.Size = new Size(155, 25);
            label5.TabIndex = 69;
            label5.Text = "ICMS de compra:";
            // 
            // txtValorVenda
            // 
            txtValorVenda.Location = new Point(604, 538);
            txtValorVenda.Margin = new Padding(3, 4, 3, 4);
            txtValorVenda.Name = "txtValorVenda";
            txtValorVenda.Size = new Size(164, 27);
            txtValorVenda.TabIndex = 66;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(456, 537);
            label1.Name = "label1";
            label1.Size = new Size(142, 25);
            label1.TabIndex = 67;
            label1.Text = "Valor de venda:";
            // 
            // txtId
            // 
            txtId.Location = new Point(263, 462);
            txtId.Margin = new Padding(3, 4, 3, 4);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(164, 27);
            txtId.TabIndex = 65;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(175, 466);
            label2.Name = "label2";
            label2.Size = new Size(77, 25);
            label2.TabIndex = 64;
            label2.Text = "Código:";
            // 
            // txtValorCompra
            // 
            txtValorCompra.Location = new Point(263, 537);
            txtValorCompra.Margin = new Padding(3, 4, 3, 4);
            txtValorCompra.Name = "txtValorCompra";
            txtValorCompra.Size = new Size(164, 27);
            txtValorCompra.TabIndex = 61;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(528, 464);
            txtNome.Margin = new Padding(3, 4, 3, 4);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(164, 27);
            txtNome.TabIndex = 60;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(102, 537);
            label6.Name = "label6";
            label6.Size = new Size(155, 25);
            label6.TabIndex = 63;
            label6.Text = "Valor de compra:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(455, 466);
            label7.Name = "label7";
            label7.Size = new Size(67, 25);
            label7.TabIndex = 62;
            label7.Text = "Nome:";
            // 
            // txtCusto
            // 
            txtCusto.Location = new Point(263, 623);
            txtCusto.Margin = new Padding(3, 4, 3, 4);
            txtCusto.Name = "txtCusto";
            txtCusto.Size = new Size(164, 27);
            txtCusto.TabIndex = 72;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(102, 623);
            label8.Name = "label8";
            label8.Size = new Size(163, 31);
            label8.TabIndex = 73;
            label8.Text = "Custo do produto:";
            label8.UseCompatibleTextRendering = true;
            // 
            // txtLucro
            // 
            txtLucro.Location = new Point(604, 623);
            txtLucro.Margin = new Padding(3, 4, 3, 4);
            txtLucro.Name = "txtLucro";
            txtLucro.Size = new Size(164, 27);
            txtLucro.TabIndex = 74;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(456, 622);
            label9.Name = "label9";
            label9.Size = new Size(127, 25);
            label9.TabIndex = 75;
            label9.Text = "Lucro líquido:";
            // 
            // dREToolStripMenuItem
            // 
            dREToolStripMenuItem.Name = "dREToolStripMenuItem";
            dREToolStripMenuItem.Size = new Size(224, 26);
            dREToolStripMenuItem.Text = "DRE";
            dREToolStripMenuItem.Click += dREToolStripMenuItem_Click;
            // 
            // CustoLucroForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 727);
            Controls.Add(txtLucro);
            Controls.Add(label9);
            Controls.Add(txtCusto);
            Controls.Add(label8);
            Controls.Add(txtIcmsVenda);
            Controls.Add(label3);
            Controls.Add(txtIcmsCompra);
            Controls.Add(label5);
            Controls.Add(txtValorVenda);
            Controls.Add(label1);
            Controls.Add(txtId);
            Controls.Add(label2);
            Controls.Add(txtValorCompra);
            Controls.Add(txtNome);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(btnConsultar);
            Controls.Add(label4);
            Controls.Add(dgvProdutos);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "CustoLucroForm";
            Text = "CustoLucroForm";
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private DataGridView dgvProdutos;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuDeOpçõesToolStripMenuItem;
        private ToolStripMenuItem cadastrarProdutoToolStripMenuItem;
        private Button btnConsultar;
        private TextBox txtIcmsVenda;
        private Label label3;
        private TextBox txtIcmsCompra;
        private Label label5;
        private TextBox txtValorVenda;
        private Label label1;
        private TextBox txtId;
        private Label label2;
        private TextBox txtValorCompra;
        private TextBox txtNome;
        private Label label6;
        private Label label7;
        private TextBox txtCusto;
        private Label label8;
        private TextBox txtLucro;
        private Label label9;
        private ToolStripMenuItem venderProdutoToolStripMenuItem;
        private ToolStripMenuItem dREToolStripMenuItem;
    }
}