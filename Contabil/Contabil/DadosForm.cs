using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contabil
{
    public partial class DadosForm : Form
    {
        public DadosForm()
        {
            InitializeComponent();
            pnlDados.Enabled = false;
            Contexto contexto = new Contexto();
            Empresa empresa = contexto.Empresa.Find(1);
            txtCaixa.Text = empresa.Caixa.Value.ToString();
            txtCustos.Text = empresa.Custo.Value.ToString();
            txtDespesas.Text = empresa.Despesa.Value.ToString();
            txtDireitos.Text = empresa.Direitos.Value.ToString();
            txtObrigacoes.Text = empresa.Obrigacoes.Value.ToString();
            txtDespesasFixas.Text = empresa.Despesa.Value.ToString();
        }

        private void Dados_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Contexto contexto = new Contexto();
            Empresa empresa = contexto.Empresa.Find(1);
            empresa.Despesa = decimal.Parse(txtDespesasFixas.Text);

            txtDespesas.Text = empresa.Despesa.Value.ToString();

            contexto.Empresa.Update(empresa);
            contexto.SaveChanges();
        }

        private void consultarCustoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustoLucroForm clf = new CustoLucroForm();
            this.Close();
            clf.Show();
        }

        private void venderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VendaForm vf = new VendaForm();
            this.Close();
            vf.Show();
        }
        private void produtoFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProdutoForm pf = new ProdutoForm();
            this.Close();
            pf.Show();
        }
    }
}
