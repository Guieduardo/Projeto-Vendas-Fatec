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
    public class ItemVendaDAO
    {
        //Atributo da classe mysqlconncetion
        private MySqlConnection conexao;

        //Construtor
        public ItemVendaDAO()
        {
            this.conexao = new ConnectionFactory().GetConnection();
        }

        #region Método que cadastra um item

        public void CadastrarItemVenda(ItemVenda item) //(Cliente cliente é de acordo com a model
        {
            try
            {
                // 1 Passo - Criar o comando SQL
                string sql = @"insert into tb_itensvendas (venda_id, produto_id, qtd, subtotal)
                                values(@venda_id, @produto_id, @qtd, @subtotal)";

                //2 Passo - Organizar o comando SQL
                MySqlCommand executasql = new MySqlCommand(sql, conexao);
                executasql.Parameters.AddWithValue("@venda_id", item.venda_id);
                executasql.Parameters.AddWithValue("@produto_id", item.produto_id);
                executasql.Parameters.AddWithValue("@qtd", item.qtd);
                executasql.Parameters.AddWithValue("@subtotal", item.subtotal);


                // 3 Passo - Abrir a conexão e executar o comando sql
                conexao.Open();
                executasql.ExecuteNonQuery();

                MessageBox.Show("Item cadastrado com sucesso");

                // 4 Passo - Fechar a conexao
                conexao.Close();
            }

            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro" + erro);
            }
        }

        #endregion

        #region Método que lista os itens de uma venda
        public DataTable ListarItensPorVenda(int venda_id)
        {
         
            try  
            {

                DataTable TabelaItens = new DataTable();
                //1 - Criar o comando SQL
                string sql = @"SELECT p.descricao as 'Descrição',
                                
                                i.qtd as 'Qtd',
                                p.preco as 'Preço',
                                i.subtotal as 'SubTotal' from tb_itensvendas as i
                                inner join tb_produtos as p on(i.produto_id = p.id) where i.venda_id = @venda_id";

                //2 Passo - organizar o comando SQL
                MySqlCommand executasql = new MySqlCommand(sql, conexao);
                executasql.Parameters.AddWithValue("@venda_id", venda_id);

                //3 Passo - abrir a conexão e executa o comando sql
                conexao.Open();
                executasql.ExecuteNonQuery();

                //
                MySqlDataAdapter adapter = new MySqlDataAdapter(executasql);
                adapter.Fill(TabelaItens);

                return TabelaItens;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro: " + erro);
                return null;
            }
        }

        #endregion
    }
}
