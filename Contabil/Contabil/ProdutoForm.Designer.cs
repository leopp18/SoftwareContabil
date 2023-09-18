namespace Contabil
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
            label4 = new Label();
            dgvProdutos = new DataGridView();
            pnlDados = new Panel();
            txtCofinsVenda = new TextBox();
            label10 = new Label();
            txtCofinsCompra = new TextBox();
            label11 = new Label();
            txtPisVenda = new TextBox();
            label8 = new Label();
            txtPisCompra = new TextBox();
            label9 = new Label();
            txtIcmsVenda = new TextBox();
            label3 = new Label();
            txtIcmsCompra = new TextBox();
            label5 = new Label();
            txtValorVenda = new TextBox();
            label1 = new Label();
            txtId = new TextBox();
            label2 = new Label();
            btnSalvar = new Button();
            txtValorCompra = new TextBox();
            txtNome = new TextBox();
            label6 = new Label();
            label7 = new Label();
            btnDeletar = new Button();
            btnEditar = new Button();
            btnCadastrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            pnlDados.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(288, 28);
            label4.Name = "label4";
            label4.Size = new Size(162, 37);
            label4.TabIndex = 54;
            label4.Text = "PRODUTOS";
            // 
            // dgvProdutos
            // 
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Location = new Point(66, 88);
            dgvProdutos.Margin = new Padding(3, 4, 3, 4);
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.RowHeadersWidth = 60;
            dgvProdutos.RowTemplate.Height = 25;
            dgvProdutos.Size = new Size(608, 277);
            dgvProdutos.TabIndex = 53;
            // 
            // pnlDados
            // 
            pnlDados.Controls.Add(txtCofinsVenda);
            pnlDados.Controls.Add(label10);
            pnlDados.Controls.Add(txtCofinsCompra);
            pnlDados.Controls.Add(label11);
            pnlDados.Controls.Add(txtPisVenda);
            pnlDados.Controls.Add(label8);
            pnlDados.Controls.Add(txtPisCompra);
            pnlDados.Controls.Add(label9);
            pnlDados.Controls.Add(txtIcmsVenda);
            pnlDados.Controls.Add(label3);
            pnlDados.Controls.Add(txtIcmsCompra);
            pnlDados.Controls.Add(label5);
            pnlDados.Controls.Add(txtValorVenda);
            pnlDados.Controls.Add(label1);
            pnlDados.Controls.Add(txtId);
            pnlDados.Controls.Add(label2);
            pnlDados.Controls.Add(btnSalvar);
            pnlDados.Controls.Add(txtValorCompra);
            pnlDados.Controls.Add(txtNome);
            pnlDados.Controls.Add(label6);
            pnlDados.Controls.Add(label7);
            pnlDados.Enabled = false;
            pnlDados.Location = new Point(66, 460);
            pnlDados.Margin = new Padding(3, 4, 3, 4);
            pnlDados.Name = "pnlDados";
            pnlDados.Size = new Size(742, 288);
            pnlDados.TabIndex = 52;
            // 
            // txtCofinsVenda
            // 
            txtCofinsVenda.Location = new Point(550, 133);
            txtCofinsVenda.Margin = new Padding(3, 4, 3, 4);
            txtCofinsVenda.Name = "txtCofinsVenda";
            txtCofinsVenda.Size = new Size(164, 27);
            txtCofinsVenda.TabIndex = 44;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(369, 132);
            label10.Name = "label10";
            label10.Size = new Size(161, 25);
            label10.TabIndex = 45;
            label10.Text = "COFINS de venda:";
            // 
            // txtCofinsCompra
            // 
            txtCofinsCompra.Location = new Point(550, 98);
            txtCofinsCompra.Margin = new Padding(3, 4, 3, 4);
            txtCofinsCompra.Name = "txtCofinsCompra";
            txtCofinsCompra.Size = new Size(164, 27);
            txtCofinsCompra.TabIndex = 42;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(369, 97);
            label11.Name = "label11";
            label11.Size = new Size(174, 25);
            label11.TabIndex = 43;
            label11.Text = "COFINS de compra:";
            // 
            // txtPisVenda
            // 
            txtPisVenda.Location = new Point(550, 66);
            txtPisVenda.Margin = new Padding(3, 4, 3, 4);
            txtPisVenda.Name = "txtPisVenda";
            txtPisVenda.Size = new Size(164, 27);
            txtPisVenda.TabIndex = 40;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(420, 65);
            label8.Name = "label8";
            label8.Size = new Size(124, 25);
            label8.TabIndex = 41;
            label8.Text = "PIS de venda:";
            // 
            // txtPisCompra
            // 
            txtPisCompra.Location = new Point(550, 31);
            txtPisCompra.Margin = new Padding(3, 4, 3, 4);
            txtPisCompra.Name = "txtPisCompra";
            txtPisCompra.Size = new Size(164, 27);
            txtPisCompra.TabIndex = 38;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(407, 33);
            label9.Name = "label9";
            label9.Size = new Size(137, 25);
            label9.TabIndex = 39;
            label9.Text = "PIS de compra:";
            // 
            // txtIcmsVenda
            // 
            txtIcmsVenda.Location = new Point(181, 218);
            txtIcmsVenda.Margin = new Padding(3, 4, 3, 4);
            txtIcmsVenda.Name = "txtIcmsVenda";
            txtIcmsVenda.Size = new Size(164, 27);
            txtIcmsVenda.TabIndex = 36;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(33, 220);
            label3.Name = "label3";
            label3.Size = new Size(142, 25);
            label3.TabIndex = 37;
            label3.Text = "ICMS de venda:";
            // 
            // txtIcmsCompra
            // 
            txtIcmsCompra.Location = new Point(181, 183);
            txtIcmsCompra.Margin = new Padding(3, 4, 3, 4);
            txtIcmsCompra.Name = "txtIcmsCompra";
            txtIcmsCompra.Size = new Size(164, 27);
            txtIcmsCompra.TabIndex = 34;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(20, 182);
            label5.Name = "label5";
            label5.Size = new Size(155, 25);
            label5.TabIndex = 35;
            label5.Text = "ICMS de compra:";
            // 
            // txtValorVenda
            // 
            txtValorVenda.Location = new Point(181, 148);
            txtValorVenda.Margin = new Padding(3, 4, 3, 4);
            txtValorVenda.Name = "txtValorVenda";
            txtValorVenda.Size = new Size(164, 27);
            txtValorVenda.TabIndex = 32;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(33, 147);
            label1.Name = "label1";
            label1.Size = new Size(142, 25);
            label1.TabIndex = 33;
            label1.Text = "Valor de venda:";
            // 
            // txtId
            // 
            txtId.Location = new Point(181, 29);
            txtId.Margin = new Padding(3, 4, 3, 4);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(164, 27);
            txtId.TabIndex = 31;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(93, 33);
            label2.Name = "label2";
            label2.Size = new Size(77, 25);
            label2.TabIndex = 30;
            label2.Text = "Código:";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(533, 212);
            btnSalvar.Margin = new Padding(3, 4, 3, 4);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(112, 31);
            btnSalvar.TabIndex = 2;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // txtValorCompra
            // 
            txtValorCompra.Location = new Point(181, 113);
            txtValorCompra.Margin = new Padding(3, 4, 3, 4);
            txtValorCompra.Name = "txtValorCompra";
            txtValorCompra.Size = new Size(164, 27);
            txtValorCompra.TabIndex = 1;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(181, 71);
            txtNome.Margin = new Padding(3, 4, 3, 4);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(164, 27);
            txtNome.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(20, 113);
            label6.Name = "label6";
            label6.Size = new Size(155, 25);
            label6.TabIndex = 14;
            label6.Text = "Valor de compra:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(103, 73);
            label7.Name = "label7";
            label7.Size = new Size(67, 25);
            label7.TabIndex = 13;
            label7.Text = "Nome:";
            // 
            // btnDeletar
            // 
            btnDeletar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDeletar.Location = new Point(571, 402);
            btnDeletar.Margin = new Padding(3, 4, 3, 4);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(103, 37);
            btnDeletar.TabIndex = 51;
            btnDeletar.Text = "Deletar";
            btnDeletar.UseVisualStyleBackColor = true;
            btnDeletar.Click += btnDeletar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEditar.Location = new Point(318, 402);
            btnEditar.Margin = new Padding(3, 4, 3, 4);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(103, 37);
            btnEditar.TabIndex = 50;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCadastrar.Location = new Point(66, 402);
            btnCadastrar.Margin = new Padding(3, 4, 3, 4);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(105, 37);
            btnCadastrar.TabIndex = 49;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // ProdutoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(846, 761);
            Controls.Add(label4);
            Controls.Add(dgvProdutos);
            Controls.Add(pnlDados);
            Controls.Add(btnDeletar);
            Controls.Add(btnEditar);
            Controls.Add(btnCadastrar);
            Name = "ProdutoForm";
            Text = "ProdutoForm";
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            pnlDados.ResumeLayout(false);
            pnlDados.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private DataGridView dgvProdutos;
        private Panel pnlDados;
        private TextBox txtCofinsVenda;
        private Label label10;
        private TextBox txtCofinsCompra;
        private Label label11;
        private TextBox txtPisVenda;
        private Label label8;
        private TextBox txtPisCompra;
        private Label label9;
        private TextBox txtIcmsVenda;
        private Label label3;
        private TextBox txtIcmsCompra;
        private Label label5;
        private TextBox txtValorVenda;
        private Label label1;
        private TextBox txtId;
        private Label label2;
        private Button btnSalvar;
        private TextBox txtValorCompra;
        private TextBox txtNome;
        private Label label6;
        private Label label7;
        private Button btnDeletar;
        private Button btnEditar;
        private Button btnCadastrar;
    }
}