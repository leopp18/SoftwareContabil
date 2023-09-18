namespace Contabil
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtSenha = new Label();
            textBoxSenha = new TextBox();
            textBoxLogin = new TextBox();
            txtLogin = new Label();
            btnEntrar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(81, 63);
            label1.Name = "label1";
            label1.Size = new Size(421, 37);
            label1.TabIndex = 23;
            label1.Text = "SOFTWARE DE CONTABILIDADE";
            // 
            // txtSenha
            // 
            txtSenha.AutoSize = true;
            txtSenha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSenha.Location = new Point(183, 234);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(69, 28);
            txtSenha.TabIndex = 22;
            txtSenha.Text = "Senha:";
            // 
            // textBoxSenha
            // 
            textBoxSenha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSenha.Location = new Point(183, 258);
            textBoxSenha.Name = "textBoxSenha";
            textBoxSenha.Size = new Size(174, 34);
            textBoxSenha.TabIndex = 19;
            // 
            // textBoxLogin
            // 
            textBoxLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLogin.Location = new Point(183, 165);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(174, 34);
            textBoxLogin.TabIndex = 18;
            textBoxLogin.TextChanged += textBoxLogin_TextChanged;
            // 
            // txtLogin
            // 
            txtLogin.AutoSize = true;
            txtLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtLogin.Location = new Point(183, 134);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(65, 28);
            txtLogin.TabIndex = 21;
            txtLogin.Text = "Login:";
            // 
            // btnEntrar
            // 
            btnEntrar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEntrar.Location = new Point(216, 341);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(102, 34);
            btnEntrar.TabIndex = 20;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(590, 465);
            Controls.Add(label1);
            Controls.Add(txtSenha);
            Controls.Add(textBoxSenha);
            Controls.Add(textBoxLogin);
            Controls.Add(txtLogin);
            Controls.Add(btnEntrar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label txtSenha;
        private TextBox textBoxSenha;
        private TextBox textBoxLogin;
        private Label txtLogin;
        private Button btnEntrar;
    }
}