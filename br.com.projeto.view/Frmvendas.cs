using Projeto_Vendas_Fatec.br.com.projeto.dao;
using Projeto_Vendas_Fatec.br.com.projeto.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Vendas_Fatec.br.com.projeto.view
{
    public partial class Frmvendas : Form
    {

        //Objetos
        Produtos produto = new Produtos();
        ProdutosDAO produtodao = new ProdutosDAO();

        Cliente cliente = new Cliente();
        ClienteDAO clientedao = new ClienteDAO();

        //Variaveis
        int qtd;
        decimal preco;
        decimal subtotal, total;

        //Carrinho
        DataTable carrinho = new DataTable();

        public Frmvendas()
        {

            
            InitializeComponent(); //Desenha o form na tela

            //Montar o datagridView
            carrinho.Columns.Add("Código", typeof(int));
            carrinho.Columns.Add("Produto", typeof(string));
            carrinho.Columns.Add("Quantidade", typeof(int));
            carrinho.Columns.Add("Preço", typeof(decimal));
            carrinho.Columns.Add("Subtotal", typeof(decimal));

            //Definir que o datagridview irá utilizar o datatable
            dgProdutos.DataSource = carrinho; 

        }

        private void Frmvendas_Load(object sender, EventArgs e)
        {
            //Pegando a data atual do sistema
            txtdata.Text = DateTime.Now.ToShortDateString();
        }

        private void txtcpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Consulta de cliente por CPF
            if (e.KeyChar == 13) //13 é referente ao enter do teclado
            {
                

                cliente = clientedao.RetornaClientePorCpf(txtcpf.Text);
                if(cliente != null)
                {
                    //Colocar o nome do cliente no campo de texto do cliente
                    txtnome.Text = cliente.nome;
                }
                else
                {
                    //limpar os campos
                    txtcpf.Clear();
                    txtnome.Clear();
                    txtcpf.Focus();
                }
            }
        }

        private void btnadicionar_Click(object sender, EventArgs e)
        {
            //Botao adicionar no carriinho
            try
            {
                //1 Passo - Receber os valores
                qtd = int.Parse(txtqtd.Text);
                preco = decimal.Parse(txtpreco.Text);

                //Calcular o subtotal
                subtotal = qtd * preco;

                //Calcular o total
                total = total + subtotal; //ou total += subtotal
                txttotal.Text = total.ToString();

                //2 Passo - Adicionar o produto no Carrinho
                carrinho.Rows.Add(int.Parse(txtcodigo.Text),txtdescricao.Text,qtd,preco,subtotal);


                //limpar os campos
                txtcodigo.Focus();
                txtcodigo.Clear();
                txtdescricao.Clear();
                txtpreco.Clear();
                txtqtd.Clear();
                txtqtd.BackColor = Color.White;

            }
            catch (Exception)
            {

                MessageBox.Show("Pesquise um Produto!");
            }
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            //Botão remover Item
            try
            {
                decimal subproduto = decimal.Parse(dgProdutos.CurrentRow.Cells[4].Value.ToString());

                //Excluir um item do carrinho
                int indice = dgProdutos.CurrentRow.Index;
                DataRow linha = carrinho.Rows[indice];

                //Remover a linha do Datatable do carrinho
                carrinho.Rows.Remove(linha);
                carrinho.AcceptChanges();

                //recalcular o total
                total -= subproduto; //ou total = total - subproduto

                //exibe o novo total
                txttotal.Text = total.ToString();
                MessageBox.Show("Item removido do carrinho com sucesso!");
            }
            catch (Exception)
            {

                MessageBox.Show("Selecione o item para excluir");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnpagar_Click(object sender, EventArgs e)
        {
            //botao pagamento
            Frmpagamento tela = new Frmpagamento(cliente, carrinho,DateTime.Parse(txtdata.Text));

            //Passando a variavel para o campo txt.total da tela pagamentos
            tela.txttotal.Text = total.ToString();

            tela.ShowDialog();
        }

        private void txtcodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Consulta do produto por codigo
            if (e.KeyChar == 13) //13 é referente ao enter do teclado
            {
               

                produto = produtodao.RetornaProdutoPorID(int.Parse(txtcodigo.Text));
                if (produto != null)
                {
                    //Colocar a descrição do produto no campo de texto descricao
                    //Colocar o preco do produto no campo de preco
                    txtdescricao.Text = produto.descricao;
                    txtpreco.Text = produto.preco.ToString();
                    txtqtd.Focus();
                    txtqtd.BackColor = Color.Yellow;

                }
                else
                {
                    //limpar os campos
                    txtcodigo.Focus();
                    txtcodigo.Clear();
                    txtdescricao.Clear();
                    txtpreco.Clear();
                    
                }
            }

        }
    }
}
