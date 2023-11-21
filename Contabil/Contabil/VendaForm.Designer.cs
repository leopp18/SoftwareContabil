namespace Contabil
{
    partial class VendaForm
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
            btnVenderPrazo = new Button();
            menuStrip1 = new MenuStrip();
            menuDeOpçõesToolStripMenuItem = new ToolStripMenuItem();
            produtoFormToolStripMenuItem = new ToolStripMenuItem();
            consultarLucrocustoToolStripMenuItem1 = new ToolStripMenuItem();
            btnVenderVista = new Button();
            dREToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(283, 57);
            label4.Name = "label4";
            label4.Size = new Size(162, 37);
            label4.TabIndex = 58;
            label4.Text = "PRODUTOS";
            // 
            // dgvProdutos
            // 
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Location = new Point(67, 117);
            dgvProdutos.Margin = new Padding(3, 4, 3, 4);
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.RowHeadersWidth = 60;
            dgvProdutos.RowTemplate.Height = 25;
            dgvProdutos.Size = new Size(666, 277);
            dgvProdutos.TabIndex = 57;
            // 
            // btnVenderPrazo
            // 
            btnVenderPrazo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnVenderPrazo.Location = new Point(537, 411);
            btnVenderPrazo.Margin = new Padding(3, 4, 3, 4);
            btnVenderPrazo.Name = "btnVenderPrazo";
            btnVenderPrazo.Size = new Size(196, 37);
            btnVenderPrazo.TabIndex = 60;
            btnVenderPrazo.Text = "Vender a prazo";
            btnVenderPrazo.UseVisualStyleBackColor = true;
            btnVenderPrazo.Click += btnVender_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuDeOpçõesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 61;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuDeOpçõesToolStripMenuItem
            // 
            menuDeOpçõesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { produtoFormToolStripMenuItem, consultarLucrocustoToolStripMenuItem1, dREToolStripMenuItem });
            menuDeOpçõesToolStripMenuItem.Name = "menuDeOpçõesToolStripMenuItem";
            menuDeOpçõesToolStripMenuItem.Size = new Size(135, 24);
            menuDeOpçõesToolStripMenuItem.Text = "Menu de Opções";
            // 
            // produtoFormToolStripMenuItem
            // 
            produtoFormToolStripMenuItem.Name = "produtoFormToolStripMenuItem";
            produtoFormToolStripMenuItem.Size = new Size(232, 26);
            produtoFormToolStripMenuItem.Text = "Cadastrar produto";
            produtoFormToolStripMenuItem.Click += produtoFormToolStripMenuItem_Click;
            // 
            // consultarLucrocustoToolStripMenuItem1
            // 
            consultarLucrocustoToolStripMenuItem1.Name = "consultarLucrocustoToolStripMenuItem1";
            consultarLucrocustoToolStripMenuItem1.Size = new Size(232, 26);
            consultarLucrocustoToolStripMenuItem1.Text = "Consultar lucro/custo";
            consultarLucrocustoToolStripMenuItem1.Click += consultarLucrocustoToolStripMenuItem1_Click;
            // 
            // btnVenderVista
            // 
            btnVenderVista.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnVenderVista.Location = new Point(67, 411);
            btnVenderVista.Margin = new Padding(3, 4, 3, 4);
            btnVenderVista.Name = "btnVenderVista";
            btnVenderVista.Size = new Size(196, 37);
            btnVenderVista.TabIndex = 62;
            btnVenderVista.Text = "Vender a vista";
            btnVenderVista.UseVisualStyleBackColor = true;
            btnVenderVista.Click += btnVenderVista_Click;
            // 
            // dREToolStripMenuItem
            // 
            dREToolStripMenuItem.Name = "dREToolStripMenuItem";
            dREToolStripMenuItem.Size = new Size(232, 26);
            dREToolStripMenuItem.Text = "DRE";
            dREToolStripMenuItem.Click += dREToolStripMenuItem_Click;
            // 
            // VendaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 460);
            Controls.Add(btnVenderVista);
            Controls.Add(btnVenderPrazo);
            Controls.Add(label4);
            Controls.Add(dgvProdutos);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "VendaForm";
            Text = "VendaForm";
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private DataGridView dgvProdutos;
        private Button btnVenderPrazo;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuDeOpçõesToolStripMenuItem;
        private ToolStripMenuItem produtoFormToolStripMenuItem;
        private ToolStripMenuItem consultarLucrocustoToolStripMenuItem1;
        private Button btnVenderVista;
        private ToolStripMenuItem dREToolStripMenuItem;
    }
}