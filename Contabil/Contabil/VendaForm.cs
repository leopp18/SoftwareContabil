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
    public partial class VendaForm : Form
    {
        public VendaForm()
        {
            InitializeComponent();
            atualizarView();
        }

        private void atualizarView()
        {
            Contexto contexto = new Contexto();
            List<Produto> lista = (from Produto p in contexto.Produtos select p).ToList<Produto>();
            dgvProdutos.DataSource = lista;
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Tem certeza que deseja vender este produto?", "Venda",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                int id = int.Parse(dgvProdutos.CurrentRow.Cells[0].Value.ToString());
                string nome = dgvProdutos.CurrentRow.Cells[1].Value.ToString();
                decimal valorVenda = decimal.Parse(dgvProdutos.CurrentRow.Cells[3].Value.ToString());
                decimal icmsVenda = decimal.Parse(dgvProdutos.CurrentRow.Cells[7].Value.ToString());
                try
                {
                    Contexto contexto = new Contexto();
                    Produto p = contexto.Produtos.Find(id);
                    contexto.Produtos.Remove(p);
                    contexto.SaveChanges();
                    Console.WriteLine(nome + " vendido(a) com êxito!\n" + valorVenda + " foi vendido a prazo", "Sucesso!");
                    //balanco patrimonial = bens + direitos + caixa - obrigacoes
                    //venda a prazo entra como direito
                    Empresa empresa = contexto.Empresa.Find(1);
                    empresa.Direitos += valorVenda;
                    empresa.Obrigacoes += (valorVenda * icmsVenda / 100);
                    contexto.Empresa.Update(empresa);
                    contexto.SaveChanges();
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

        private void produtoFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProdutoForm pf = new ProdutoForm();
            this.Close();
            pf.Show();
        }

        private void consultarLucrocustoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CustoLucroForm clf = new CustoLucroForm();
            this.Close();
            clf.Show();
        }

        private void btnVenderVista_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Tem certeza que deseja vender este produto?", "Venda",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                int id = int.Parse(dgvProdutos.CurrentRow.Cells[0].Value.ToString());
                string nome = dgvProdutos.CurrentRow.Cells[1].Value.ToString();
                decimal valorVenda = decimal.Parse(dgvProdutos.CurrentRow.Cells[3].Value.ToString());
                decimal icmsVenda = decimal.Parse(dgvProdutos.CurrentRow.Cells[7].Value.ToString());
                try
                {
                    Contexto contexto = new Contexto();
                    Produto p = contexto.Produtos.Find(id);
                    contexto.Produtos.Remove(p);
                    contexto.SaveChanges();
                    Console.WriteLine(nome + " vendido(a) com êxito!\n" + valorVenda + " foi adicionado ao caixa", "Sucesso!");
                    //balanco patrimonial = bens + direitos + caixa - obrigacoes
                    //venda a vista entra como caixa
                    Empresa empresa = contexto.Empresa.Find(1);
                    empresa.Caixa += valorVenda;
                    empresa.Obrigacoes += (valorVenda * icmsVenda / 100);
                    contexto.Empresa.Update(empresa);
                    contexto.SaveChanges();
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

        private void dREToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DadosForm df = new DadosForm();
            this.Close();
            df.Show();
        }
    }
}
