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
    public partial class ProdutoForm : Form
    {
        public ProdutoForm()
        {
            InitializeComponent();
            atualizarView();
        }

        private void atualizarView()
        {
            Contexto contexto = new Contexto();
            List<Produto> lista = (from Produto p in contexto.Produtos select p).ToList<Produto>();
            dgvProdutos.DataSource = lista;
            txtId.Text = String.Empty;
            txtNome.Text = String.Empty;
            txtValorCompra.Text = String.Empty;
            txtValorVenda.Text = String.Empty;
            txtIcmsCompra.Text = String.Empty;
            txtIcmsVenda.Text = String.Empty;
            txtPisCompra.Text = String.Empty;
            txtPisVenda.Text = String.Empty;
            txtCofinsCompra.Text = String.Empty;
            txtCofinsVenda.Text = String.Empty;
            btnCadastrar.Enabled = true;
            btnEditar.Enabled = true;
            btnDeletar.Enabled = true;
            pnlDados.Enabled = false;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            pnlDados.Enabled = true;
            btnEditar.Enabled = false;
            btnDeletar.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgvProdutos.CurrentRow.Cells[0].Value.ToString());
            string nome = dgvProdutos.CurrentRow.Cells[1].Value.ToString();
            float valorCompra = float.Parse(dgvProdutos.CurrentRow.Cells[2].Value.ToString());
            float valorVenda = float.Parse(dgvProdutos.CurrentRow.Cells[3].Value.ToString());
            float icmsCompra = float.Parse(dgvProdutos.CurrentRow.Cells[4].Value.ToString());
            float pisCompra = float.Parse(dgvProdutos.CurrentRow.Cells[5].Value.ToString());
            float cofinsCompra = float.Parse(dgvProdutos.CurrentRow.Cells[6].Value.ToString());
            float icmsVenda = float.Parse(dgvProdutos.CurrentRow.Cells[7].Value.ToString());
            float pisVenda = float.Parse(dgvProdutos.CurrentRow.Cells[8].Value.ToString());
            float cofinsVenda = float.Parse(dgvProdutos.CurrentRow.Cells[9].Value.ToString());

            txtId.Text = id.ToString();
            txtNome.Text = nome;
            txtValorCompra.Text = valorCompra.ToString();
            txtValorVenda.Text = valorVenda.ToString();
            txtIcmsCompra.Text = icmsCompra.ToString();
            txtIcmsVenda.Text = icmsVenda.ToString();
            txtPisCompra.Text = pisCompra.ToString();
            txtPisVenda.Text = pisVenda.ToString();
            txtCofinsCompra.Text = cofinsCompra.ToString();
            txtCofinsVenda.Text = cofinsVenda.ToString();
            pnlDados.Enabled = true;
            btnCadastrar.Enabled = false;
            btnDeletar.Enabled = false;
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Tem certeza que deseja excluir este produto?", "Exclusão",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                int id = int.Parse(dgvProdutos.CurrentRow.Cells[0].Value.ToString());
                try
                {
                    Contexto contexto = new Contexto();
                    Produto p = contexto.Produtos.Find(id);
                    contexto.Produtos.Remove(p);
                    contexto.SaveChanges();
                    Console.WriteLine("Produto excluído com êxito!", "Sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message, "Erro");
                }
            }
            else
            {
                return;
            }
            atualizarView();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Contexto contexto = new Contexto();
            if (btnCadastrar.Enabled == true)
            {
                try
                {
                    Produto p = new Produto();
                    p.Nome = txtNome.Text;
                    p.Compra = decimal.Parse(txtValorCompra.Text);
                    p.Venda = decimal.Parse(txtValorVenda.Text);
                    p.IcmsCompra = decimal.Parse(txtIcmsCompra.Text);
                    p.IcmsVenda = decimal.Parse(txtIcmsVenda.Text);
                    p.PisCompra = decimal.Parse(txtPisCompra.Text);
                    p.PisVenda = decimal.Parse(txtPisVenda.Text);
                    p.CofinsCompra = decimal.Parse(txtCofinsCompra.Text);
                    p.CofinsVenda = decimal.Parse(txtCofinsVenda.Text);
                    contexto.Produtos.Add(p);
                    contexto.SaveChanges();
                    MessageBox.Show("Produto cadastrado com êxito!", "Sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message, "Erro!");
                }
            }
            else if (btnEditar.Enabled == true)
            {
                try
                {
                    int id = int.Parse(txtId.Text);
                    Produto p = contexto.Produtos.Find(id);
                    p.Nome = txtNome.Text;
                    p.Compra = decimal.Parse(txtValorCompra.Text);
                    p.Venda = decimal.Parse(txtValorVenda.Text);
                    p.IcmsCompra = decimal.Parse(txtIcmsCompra.Text);
                    p.IcmsVenda = decimal.Parse(txtIcmsVenda.Text);
                    p.PisCompra = decimal.Parse(txtPisCompra.Text);
                    p.PisVenda = decimal.Parse(txtPisVenda.Text);
                    p.CofinsCompra = decimal.Parse(txtCofinsCompra.Text);
                    p.CofinsVenda = decimal.Parse(txtCofinsVenda.Text);
                    contexto.Produtos.Update(p);
                    contexto.SaveChanges();
                    MessageBox.Show("Produto alterado com êxito!", "Sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message, "Erro!");
                }
            }
            else { }
            atualizarView();
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

        private void dREToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DadosForm df = new DadosForm();
            this.Close();
            df.Show();
        }
    }
}
