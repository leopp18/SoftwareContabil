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
    public partial class CustoLucroForm : Form
    {
        public CustoLucroForm()
        {
            InitializeComponent();
            Contexto contexto = new Contexto();
            List<Produto> lista = (from Produto p in contexto.Produtos select p).ToList<Produto>();
            dgvProdutos.DataSource = lista;
        }

        private void cadastrarProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProdutoForm pf = new ProdutoForm();
            this.Close();
            pf.Show();
        }

        private void btnConsultar_Click_1(object sender, EventArgs e)
        {
            int id = int.Parse(dgvProdutos.CurrentRow.Cells[0].Value.ToString());
            string nome = dgvProdutos.CurrentRow.Cells[1].Value.ToString();
            float valorCompra = float.Parse(dgvProdutos.CurrentRow.Cells[2].Value.ToString());
            float valorVenda = float.Parse(dgvProdutos.CurrentRow.Cells[3].Value.ToString());
            float icmsCompra = float.Parse(dgvProdutos.CurrentRow.Cells[4].Value.ToString());
            float icmsVenda = float.Parse(dgvProdutos.CurrentRow.Cells[7].Value.ToString());
            txtId.Text = id.ToString();
            txtNome.Text = nome;
            txtValorCompra.Text = valorCompra.ToString();
            txtValorVenda.Text = valorVenda.ToString();
            txtIcmsCompra.Text = icmsCompra.ToString();
            txtIcmsVenda.Text = icmsVenda.ToString();

            txtCusto.Text = (valorCompra - (valorCompra * icmsCompra / 100)).ToString();
            txtLucro.Text = (valorVenda - (valorVenda * icmsVenda / 100) - float.Parse(txtCusto.Text)).ToString();
        }

        private void venderProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VendaForm vf = new VendaForm();
            this.Close();
            vf.Show();
        }

        private void dREToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DadosForm df = new DadosForm();
            this.Close();
            df.Show();
        }
    }
}
