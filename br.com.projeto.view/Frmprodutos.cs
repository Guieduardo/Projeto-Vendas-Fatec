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
    public partial class Frmprodutos : Form
    {
        public Frmprodutos()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Frmprodutos_Load(object sender, EventArgs e)
        {
            //Carregar tela

            //Como carregar e configurar o combobox
            FornecedorDAO dao = new FornecedorDAO();
            cbfornecedor.DataSource = dao.ListarTodosFornecedores();
            cbfornecedor.DisplayMember = "nome"; //Para mostrar o nome no combobox
            cbfornecedor.ValueMember = "id"; //Para manipular o valor referente ao nome escolhido no combobox

            //Carregar o datagridview de produto
            ProdutosDAO dao_produto = new ProdutosDAO();
            dgprodutos.DataSource = dao_produto.ListarTodosProduto();
        }

        private void Btncadastrar_Click(object sender, EventArgs e)
        {
            try
            {

                //Botão Cadastrar produto
                Produtos produto = new Produtos();

                //1 passo - Receber dados
                produto.descricao = txtdesc.Text;
                produto.preco = decimal.Parse(txtpreco.Text);
                produto.qtd_estoque = int.Parse(txtestoque.Text);
                produto.for_id =int.Parse(cbfornecedor.SelectedValue.ToString());

                //2 passo - Cadastrar no banco
                ProdutosDAO dao = new ProdutosDAO();
                dao.CadastrarProduto(produto);

                //Recarregar o datagrid
                dgprodutos.DataSource = dao.ListarTodosProduto();

            }
            catch (Exception)
            {

                MessageBox.Show("Preencha todos os campos");
            } 
           
        }

        private void Btnexcluir_Click(object sender, EventArgs e)
        {
            try
            {

                //Botão excluir produto
                Produtos produto = new Produtos();

                //1 passo - Receber dados
                produto.id = int.Parse(txtcodigo.Text);
              
                //2 passo - Cadastrar no banco
                ProdutosDAO dao = new ProdutosDAO();
                dao.ExcluirProduto(produto);

                //Recarregar o datagrid
                dgprodutos.DataSource = dao.ListarTodosProduto();

            }
            catch (Exception)
            {

                MessageBox.Show("Preencha todos os campos");
            }
        }

        private void dgprodutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Pegar os dados de um produto selecionado
            txtcodigo.Text = dgprodutos.CurrentRow.Cells[0].Value.ToString();
            txtdesc.Text = dgprodutos.CurrentRow.Cells[1].Value.ToString();
            txtpreco.Text = dgprodutos.CurrentRow.Cells[2].Value.ToString();
            txtestoque.Text = dgprodutos.CurrentRow.Cells[3].Value.ToString();
            cbfornecedor.Text = dgprodutos.CurrentRow.Cells[4].Value.ToString();

            //Troca de aba
            tabControl1.SelectedTab = tabPage1;

        }

        private void Btneditar_Click(object sender, EventArgs e)
        {
            try
            {

                //Botão alterar produto
                Produtos produto = new Produtos();

                //1 passo - Receber dados

                produto.descricao = txtdesc.Text;
                produto.preco = decimal.Parse(txtpreco.Text);
                produto.qtd_estoque = int.Parse(txtestoque.Text);
                produto.for_id = int.Parse(cbfornecedor.SelectedValue.ToString());
                produto.id = int.Parse(txtcodigo.Text);

                //2 passo - Cadastrar no banco
                ProdutosDAO dao = new ProdutosDAO();
                dao.AlterarProduto(produto);

                //Recarregar o datagrid
                dgprodutos.DataSource = dao.ListarTodosProduto();

            }
            catch (Exception)
            {

                MessageBox.Show("Preencha todos os campos");
            }
        }

        private void txtconsulta_TextChanged(object sender, EventArgs e)
        {
            //Listar produtos por descrição(nome)
            string nome = "%" + txtconsulta.Text + "%";
            ProdutosDAO dao = new ProdutosDAO();
            dgprodutos.DataSource = dao.ListarTodosProdutosPorNome(nome);
        }
    }
}
