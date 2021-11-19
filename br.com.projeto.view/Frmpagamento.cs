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
    public partial class Frmpagamento : Form
    {

        //Criar os objetos para receber os dados
        Cliente cliente = new Cliente();
        DataTable carrinho = new DataTable();
        DateTime dataatual;


        public Frmpagamento(Cliente vcliente, DataTable vcarrinho, DateTime vdataatual)
        {
            //Recebendo os dados

            this.cliente = vcliente;
            this.carrinho = vcarrinho;
            this.dataatual = vdataatual;

            InitializeComponent();
        }

        private void Frmpagamento_Load(object sender, EventArgs e)
        {
            //Carregar a tela
            txttroco.Text = "0,00";
            txtavista.Text = "0,00";
            txtcartao.Text = "0,00";
        }

        private void btnfinalizar_Click(object sender, EventArgs e)
        {
            //Botão finalizar venda
            try
            {
                //1 Passo - Declarar as variaveis
                decimal v_avista, v_cartao, troco, totalpago, total;

                //2 Passo - Receber os valores nas variaveis
                v_avista = decimal.Parse(txtavista.Text);
                v_cartao = decimal.Parse(txtcartao.Text);
                total = decimal.Parse(txttotal.Text);

                //3 Passo - Calcular o total pago
                totalpago = v_avista + v_cartao;

                //4 Passo - Verificar o valor do total Pago 
                if(totalpago < total)
                {
                    MessageBox.Show("Total Pago é menor que o valor total da venda");
                }
                else
                {
                    //5 Passo - Salvar os dados no banco

                    //Calcular o troco
                    troco = totalpago - total;

                    //Montar o objeto Vendas
                    Vendas vendas = new Vendas();
                    vendas.cliente_id = cliente.id;
                    vendas.data_venda = dataatual;
                    vendas.total_venda = total;
                    vendas.obs = txtobs.Text;

                    VendasDAO vdao = new VendasDAO();
                    vdao.CadastrarVenda(vendas);

                    //MessageBox.Show("Venda Cadastrada com sucesso");
                    txttroco.Text = troco.ToString();

                    //Cadastrar os itens da venda
                    //Percorrer e fazer isso para todos os itens do carrinho
                    foreach (DataRow linha in carrinho.Rows) //Percorre todas as linhas do datagrid do carrinho
                    {
                        //Montar os itens do carrinho
                        ItemVenda item = new ItemVenda();
                        item.produto_id = int.Parse(linha["Código"].ToString());
                        item.qtd = int.Parse(linha["Quantidade"].ToString());
                        item.subtotal = decimal.Parse(linha["Subtotal"].ToString());

                        item.venda_id = vdao.RetornaIdUltimaVenda();

                        //Criar um objeto item venda DAO
                        ItemVendaDAO itemdao = new ItemVendaDAO();
                        itemdao.CadastrarItemVenda(item);
                    }

                    MessageBox.Show("Venda Cadastrada com sucesso");

                    
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
