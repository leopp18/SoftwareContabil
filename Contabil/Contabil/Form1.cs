namespace Contabil
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBoxSenha.PasswordChar = '*';
        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text.Equals("usuario") && textBoxSenha.Text.Equals("senha"))
            {
                MessageBox.Show("Login efetuado com sucesso!", "Usuário autenticado");
                ProdutoForm pf = new ProdutoForm();
                this.Hide();
                pf.Show();
            }
            else
            {
                MessageBox.Show("Login e/ou senha incorreto", "ERRO!");
            }
        }

        private void btnEntrar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnEntrar_Click(sender, e);
            }
        }

        private void textBoxSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnEntrar_Click(sender, e);
            }
        }
    }
}