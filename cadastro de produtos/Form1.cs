using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cadastro_de_produtos
{
    public partial class Form1 : Form
    {
        List<Produto> produtos = new List<Produto>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bt_cadastrar_Click(object sender, EventArgs e)
        {
            
            Produto produto1 = new Produto();
            try
            {


                produto1.codigo = tx_codigo.Text;
                produto1.descricao = tx_descricao.Text;
                produto1.pAquisicao = Convert.ToDouble(tx_aquisicao.Text);
                produto1.lucro = Convert.ToDouble(tx_lucro.Text);

                produto1.valorVenda = produto1.pAquisicao + (produto1.pAquisicao * produto1.lucro / 100);
                tx_venda.Text = produto1.valorVenda.ToString();

                produtos.Add(produto1);

                dataGridView1.DataSource = null;
                dataGridView1.Refresh();
                dataGridView1.DataSource = produtos;
            }
            
            catch (FormatException ex)
            {
                MessageBox.Show("Não é permitido escrever letras");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro!");
            }
            

        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            produtos.RemoveAt(index);
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            dataGridView1.DataSource = produtos;
        }

        private void bt_novo_Click(object sender, EventArgs e)
        {
            tx_codigo.Clear();
            tx_descricao.Clear();
            tx_aquisicao.Clear();
            tx_lucro.Clear();
            tx_venda.Clear();
        }
    }
}
