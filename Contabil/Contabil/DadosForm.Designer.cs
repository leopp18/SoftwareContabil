namespace Contabil
{
    partial class DadosForm
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
            txtObrigacoes = new TextBox();
            label3 = new Label();
            txtDireitos = new TextBox();
            label5 = new Label();
            txtDespesas = new TextBox();
            label1 = new Label();
            txtCustos = new TextBox();
            txtCaixa = new TextBox();
            label6 = new Label();
            label7 = new Label();
            txtDespesasFixas = new TextBox();
            label2 = new Label();
            btnSalvar = new Button();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            produtoFormToolStripMenuItem = new ToolStripMenuItem();
            venderToolStripMenuItem = new ToolStripMenuItem();
            consultarCustoToolStripMenuItem = new ToolStripMenuItem();
            pnlDados = new Panel();
            menuStrip1.SuspendLayout();
            pnlDados.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(253, 39);
            label4.Name = "label4";
            label4.Size = new Size(287, 37);
            label4.TabIndex = 55;
            label4.Text = "DADOS DA EMPRESA";
            // 
            // txtObrigacoes
            // 
            txtObrigacoes.Location = new Point(147, 157);
            txtObrigacoes.Margin = new Padding(3, 4, 3, 4);
            txtObrigacoes.Name = "txtObrigacoes";
            txtObrigacoes.Size = new Size(164, 27);
            txtObrigacoes.TabIndex = 64;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(19, 156);
            label3.Name = "label3";
            label3.Size = new Size(112, 25);
            label3.TabIndex = 65;
            label3.Text = "Obrigações:";
            // 
            // txtDireitos
            // 
            txtDireitos.Location = new Point(147, 122);
            txtDireitos.Margin = new Padding(3, 4, 3, 4);
            txtDireitos.Name = "txtDireitos";
            txtDireitos.Size = new Size(164, 27);
            txtDireitos.TabIndex = 62;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(50, 122);
            label5.Name = "label5";
            label5.Size = new Size(81, 25);
            label5.TabIndex = 63;
            label5.Text = "Direitos:";
            // 
            // txtDespesas
            // 
            txtDespesas.Location = new Point(147, 87);
            txtDespesas.Margin = new Padding(3, 4, 3, 4);
            txtDespesas.Name = "txtDespesas";
            txtDespesas.Size = new Size(164, 27);
            txtDespesas.TabIndex = 60;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(37, 87);
            label1.Name = "label1";
            label1.Size = new Size(94, 25);
            label1.TabIndex = 61;
            label1.Text = "Despesas:";
            // 
            // txtCustos
            // 
            txtCustos.Location = new Point(147, 52);
            txtCustos.Margin = new Padding(3, 4, 3, 4);
            txtCustos.Name = "txtCustos";
            txtCustos.Size = new Size(164, 27);
            txtCustos.TabIndex = 57;
            // 
            // txtCaixa
            // 
            txtCaixa.Location = new Point(147, 17);
            txtCaixa.Margin = new Padding(3, 4, 3, 4);
            txtCaixa.Name = "txtCaixa";
            txtCaixa.Size = new Size(164, 27);
            txtCaixa.TabIndex = 56;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(59, 54);
            label6.Name = "label6";
            label6.Size = new Size(72, 25);
            label6.TabIndex = 59;
            label6.Text = "Custos:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(69, 19);
            label7.Name = "label7";
            label7.Size = new Size(62, 25);
            label7.TabIndex = 58;
            label7.Text = "Caixa:";
            // 
            // txtDespesasFixas
            // 
            txtDespesasFixas.Location = new Point(179, 162);
            txtDespesasFixas.Margin = new Padding(3, 4, 3, 4);
            txtDespesasFixas.Name = "txtDespesasFixas";
            txtDespesasFixas.Size = new Size(164, 27);
            txtDespesasFixas.TabIndex = 66;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(36, 164);
            label2.Name = "label2";
            label2.Size = new Size(137, 25);
            label2.TabIndex = 67;
            label2.Text = "Despesas fixas:";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(249, 202);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(94, 29);
            btnSalvar.TabIndex = 68;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 69;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { produtoFormToolStripMenuItem, venderToolStripMenuItem, consultarCustoToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(135, 24);
            toolStripMenuItem1.Text = "Menu de Opções";
            // 
            // produtoFormToolStripMenuItem
            // 
            produtoFormToolStripMenuItem.Name = "produtoFormToolStripMenuItem";
            produtoFormToolStripMenuItem.Size = new Size(232, 26);
            produtoFormToolStripMenuItem.Text = "Cadastrar produto";
            produtoFormToolStripMenuItem.Click += produtoFormToolStripMenuItem_Click;
            // 
            // venderToolStripMenuItem
            // 
            venderToolStripMenuItem.Name = "venderToolStripMenuItem";
            venderToolStripMenuItem.Size = new Size(232, 26);
            venderToolStripMenuItem.Text = "Vender produto";
            venderToolStripMenuItem.Click += venderToolStripMenuItem_Click;
            // 
            // consultarCustoToolStripMenuItem
            // 
            consultarCustoToolStripMenuItem.Name = "consultarCustoToolStripMenuItem";
            consultarCustoToolStripMenuItem.Size = new Size(232, 26);
            consultarCustoToolStripMenuItem.Text = "Consultar lucro/custo";
            consultarCustoToolStripMenuItem.Click += consultarCustoToolStripMenuItem_Click;
            // 
            // pnlDados
            // 
            pnlDados.Controls.Add(txtObrigacoes);
            pnlDados.Controls.Add(label7);
            pnlDados.Controls.Add(label6);
            pnlDados.Controls.Add(txtCaixa);
            pnlDados.Controls.Add(txtCustos);
            pnlDados.Controls.Add(label3);
            pnlDados.Controls.Add(label1);
            pnlDados.Controls.Add(txtDireitos);
            pnlDados.Controls.Add(txtDespesas);
            pnlDados.Controls.Add(label5);
            pnlDados.Location = new Point(395, 136);
            pnlDados.Name = "pnlDados";
            pnlDados.Size = new Size(331, 206);
            pnlDados.TabIndex = 70;
            // 
            // DadosForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlDados);
            Controls.Add(btnSalvar);
            Controls.Add(txtDespesasFixas);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "DadosForm";
            Text = "Dados";
            Load += Dados_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            pnlDados.ResumeLayout(false);
            pnlDados.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private TextBox txtObrigacoes;
        private Label label3;
        private TextBox txtDireitos;
        private Label label5;
        private TextBox txtDespesas;
        private Label label1;
        private TextBox txtCustos;
        private TextBox txtCaixa;
        private Label label6;
        private Label label7;
        private TextBox txtDespesasFixas;
        private Label label2;
        private Button btnSalvar;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem produtoFormToolStripMenuItem;
        private ToolStripMenuItem venderToolStripMenuItem;
        private ToolStripMenuItem consultarCustoToolStripMenuItem;
        private Panel pnlDados;
    }
}