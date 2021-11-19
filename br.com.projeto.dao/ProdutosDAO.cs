using MySql.Data.MySqlClient;
using Projeto_Vendas_Fatec.br.com.projeto.con;
using Projeto_Vendas_Fatec.br.com.projeto.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Vendas_Fatec.br.com.projeto.dao
{
    public class ProdutosDAO
    {
        //Atributo da classe mysqlconncetion
        private MySqlConnection conexao;

        //Construtor
        public ProdutosDAO()
        {
            this.conexao = new ConnectionFactory().GetConnection();
        }

        #region Método que cadastra um produto
        public void CadastrarProduto(Produtos produto) //(Cliente cliente é de acordo com a model
        {
            try
            {
                // 1 Passo - Criar o comando SQL
                string sql = @"insert into tb_produtos (descricao, preco, qtd_estoque, for_id)
                                values(@descricao, @preco, @qtd_estoque, @for_id)";

                //2 Passo - Organizar o comando SQL
                MySqlCommand executasql = new MySqlCommand(sql, conexao);
                executasql.Parameters.AddWithValue("@descricao", produto.descricao);
                executasql.Parameters.AddWithValue("@preco", produto.preco);
                executasql.Parameters.AddWithValue("@qtd_estoque", produto.qtd_estoque);
                executasql.Parameters.AddWithValue("@for_id", produto.for_id);
                

                // 3 Passo - Abrir a conexão e executar o comando sql
                conexao.Open();
                executasql.ExecuteNonQuery();

                MessageBox.Show("Produto cadastrado com sucesso");

                // 4 Passo - Fechar a conexao
                conexao.Close();
            }

            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro" + erro);
            }
        }

        #endregion

        #region Método que altera um produto
        public void AlterarProduto(Produtos produto) //(Cliente cliente é de acordo com a model
        {
            try
            {
                // 1 Passo - Criar o comando SQL
                string sql = @"update tb_produtos set descricao = @descricao, preco = @preco,
                                qtd_estoque = @qtd_estoque, for_id = @for_id where id = @id";
                                

                //2 Passo - Organizar o comando SQL
                MySqlCommand executasql = new MySqlCommand(sql, conexao);
                executasql.Parameters.AddWithValue("@descricao", produto.descricao);
                executasql.Parameters.AddWithValue("@preco", produto.preco);
                executasql.Parameters.AddWithValue("@qtd_estoque", produto.qtd_estoque);
                executasql.Parameters.AddWithValue("@for_id", produto.for_id);

                executasql.Parameters.AddWithValue("@id", produto.id);


                // 3 Passo - Abrir a conexão e executar o comando sql
                conexao.Open();
                executasql.ExecuteNonQuery();

                MessageBox.Show("Produto alterado com sucesso");

                // 4 Passo - Fechar a conexao
                conexao.Close();
            }

            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro" + erro);
            }
        }
        #endregion

        #region Método que exclui um produto
        public void ExcluirProduto(Produtos produto)
        {
            try
            {
                //1 passo - Criar o comando SQL
                string sql = @"delete from tb_produtos where id = @id";

                //2 passo - Organizar o comando SQL
                MySqlCommand executasql = new MySqlCommand(sql, conexao);

                executasql.Parameters.AddWithValue("@id", produto.id);

                // 3 passo - Abrir a conexao e executa o comando sql
                conexao.Open();
                executasql.ExecuteNonQuery();
                MessageBox.Show("Produto excluido com sucesso");

                //fechar a conexao
                conexao.Close();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: " + erro);

            }
        }

        #endregion

        #region Método que lista todos os produtos
        public DataTable ListarTodosProduto()
        {
            try
            {
                // 1 Passo  - Criar o comando SQL e o nosso DataTable
                DataTable tabelaProduto = new DataTable();
                string sql = @"select p.id as 'Código', 
	                            p.descricao as 'Descrição', 
                                p.preco as 'Preço', 
                                p.qtd_estoque as 'Quantidade', 
                                f.nome as 'Fornecedor' from tb_produtos as p
                             join tb_fornecedores as f on (p.for_id = f.id)"; 

                // 2 Passo - Organizar e executar o comando sql
                MySqlCommand executasql = new MySqlCommand(sql, conexao);

                // 3 Passo - Abrir a conexão e executar o comando sql
                conexao.Open();
                executasql.ExecuteNonQuery();

                // 4 Passo - Preencher o nosso DataTable com os dados do select
                MySqlDataAdapter adapter = new MySqlDataAdapter(executasql);
                adapter.Fill(tabelaProduto); // fill significa preencher
                return tabelaProduto;

            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: " + erro);
                return null;
            }
        }
        #endregion

        #region Método que lista todos os produtos por nome
        public DataTable ListarTodosProdutosPorNome(string nome)
        {
            try
            {
                //1 Passo - Criar o comando SQL e o nosso DataTable
                DataTable tabelProduto = new DataTable();
                string sql = @"SELECT p.id as 'Código',
                                p.descricao as 'Descrição',
                                p.preco as 'Preço',
                                p.qtd_estoque as 'Qtd',
                                f.nome as 'Fornecedor' FROM tb_produtos as p
                                join tb_fornecedores as f on (p.for_id = f.id)
                                WHERE p.descricao like @nome;";



                //2 Passo - Organizar e executar o comando sql
                MySqlCommand executasql = new MySqlCommand(sql, conexao);
                executasql.Parameters.AddWithValue("@nome", nome);



                //3 passo - Abrir a conexao e executa o comando sql
                conexao.Open();
                executasql.ExecuteNonQuery();



                //4 Passo - Preencher o nosso DataTable com os dados do select
                MySqlDataAdapter adapter = new MySqlDataAdapter(executasql);
                adapter.Fill(tabelProduto);
                conexao.Close();



                return tabelProduto;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro: " + erro);
                return null;
            }
        }
        #endregion

        #region Método que retorna um objeto produto por codigo
        public Produtos RetornaProdutoPorID(int id)
        {
            try
            {
                //1 Passo - Criar o comando sql e o objeto Cliente
                Produtos produto = new Produtos();
                string sql = @"select * from tb_produtos where id = @id";

                //2 Passo - Organizar o comando SQL
                MySqlCommand executasql = new MySqlCommand(sql, conexao);
                executasql.Parameters.AddWithValue("@id", id);

                // 3 Passo - Abrir a conexão e executar o comando sql
                conexao.Open();

                //4 Passo - Montar o objeto produto para ser retornado
                MySqlDataReader rs = executasql.ExecuteReader();
                if (rs.Read())//se conseguir encontrar algum produto com o ID
                {
                    //Monte o objeto
                    produto.id = rs.GetInt32("id");//dentro do rs ele pega a coluna do id
                    produto.descricao = rs.GetString("descricao");
                    produto.preco = rs.GetDecimal("preco");
                    conexao.Close();
                    return produto;
                }
                else
                {
                    conexao.Close();
                    MessageBox.Show("Produto não encontrado no banco de dados");
                }
                return produto;
            }
            catch (Exception erro)
            {
                conexao.Close();
                MessageBox.Show("Aconteceu o erro " + erro);
                
                return null;
            }
        }

        #endregion
    }
}
