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
    public class FornecedorDAO
    {
        //Atributo da classe mysqlconncetion
        private MySqlConnection conexao;

        //Construtor
        public FornecedorDAO()
        {
            this.conexao = new ConnectionFactory().GetConnection();
        }

        #region Método que cadastra um fornecedor

        public void CadastrarFornecedor(Fornecedores fornecedor)
        {
            try
            {
                // 1 Passo - Criar o comando SQL
                string sql = @"insert into tb_fornecedores(nome,cnpj,email,telefone,celular,cep,endereco,numero,complemento,bairro,cidade,estado)
                                values(@nome, @cnpj, @email, @telefone, @celular, @cep, @endereco, @numero, @comp, @bairro, @cidade, @estado)";

                //2 Passo - Organizar o comando SQL
                MySqlCommand executasql = new MySqlCommand(sql, conexao);
                executasql.Parameters.AddWithValue("@nome", fornecedor.nome);
                executasql.Parameters.AddWithValue("@cnpj", fornecedor.cnpj);
                executasql.Parameters.AddWithValue("@email", fornecedor.email);
                executasql.Parameters.AddWithValue("@telefone", fornecedor.telefone);
                executasql.Parameters.AddWithValue("@celular", fornecedor.celular);
                executasql.Parameters.AddWithValue("@cep", fornecedor.cep);
                executasql.Parameters.AddWithValue("@endereco", fornecedor.endereco);
                executasql.Parameters.AddWithValue("@numero", fornecedor.numero);
                executasql.Parameters.AddWithValue("@comp", fornecedor.complemento);
                executasql.Parameters.AddWithValue("@bairro", fornecedor.bairro);
                executasql.Parameters.AddWithValue("@cidade", fornecedor.cidade);
                executasql.Parameters.AddWithValue("@estado", fornecedor.uf);

                // 3 Passo - Abrir a conexão e executar o comando sql
                conexao.Open();
                executasql.ExecuteNonQuery();

                MessageBox.Show("Fornecedor cadastrado com sucesso");

                // 4 Passo - Fechar a conexao
                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro" + erro);
            }
        }

        #endregion

        #region Método que altera um fornecedor

        public void AlterarFornecedor(Fornecedores fornecedor)
        {
            try
            {
                //1 passo - Criar o comando SQL
                string sql = @"update tb_fornecedores set nome = @nome, cnpj = @cnpj , 
                                email = @email , telefone = @telefone, celular = @celular,
                                cep = @cep, endereco = @endereco, numero = @numero, complemento = @comp,
                                bairro = @bairro, cidade = @cidade, estado = @estado where id = @id";

                //2 Passo - Organizar o comando SQL
                MySqlCommand executasql = new MySqlCommand(sql, conexao);
                executasql.Parameters.AddWithValue("@nome", fornecedor.nome);
                executasql.Parameters.AddWithValue("@cnpj", fornecedor.cnpj);
                executasql.Parameters.AddWithValue("@email", fornecedor.email);
                executasql.Parameters.AddWithValue("@telefone", fornecedor.telefone);
                executasql.Parameters.AddWithValue("@celular", fornecedor.celular);
                executasql.Parameters.AddWithValue("@cep", fornecedor.cep);
                executasql.Parameters.AddWithValue("@endereco", fornecedor.endereco);
                executasql.Parameters.AddWithValue("@numero", fornecedor.numero);
                executasql.Parameters.AddWithValue("@comp", fornecedor.complemento);
                executasql.Parameters.AddWithValue("@bairro", fornecedor.bairro);
                executasql.Parameters.AddWithValue("@cidade", fornecedor.cidade);
                executasql.Parameters.AddWithValue("@estado", fornecedor.uf);
                executasql.Parameters.AddWithValue("@id", fornecedor.id);

                // 3 Passo - Abrir a conexão e executar o comando sql
                conexao.Open();
                executasql.ExecuteNonQuery();

                MessageBox.Show("Dados do fornecedor alterados com sucesso");

                // 4 Passo - Fechar a conexao
                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro" + erro);
            }

        }

        #endregion

        #region Método que exclui um fornecedor

        public void ExcluirFornecedor(int idfornecedor)
        {
            try
            {
                //1 passo - Criar o comando SQL
                string sql = @"delete from tb_fornecedores where id = @id";

                //2 Passo - Organizar o comando SQL
                MySqlCommand executasql = new MySqlCommand(sql, conexao);
                executasql.Parameters.AddWithValue("@id", idfornecedor);

                // 3 Passo - Abrir a conexão e executar o comando sql
                conexao.Open();
                executasql.ExecuteNonQuery();

                MessageBox.Show("Fornecedor excluido com sucesso");

                // 4 Passo - Fechar a conexao
                conexao.Close();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: " + erro);
            }
        }

        #endregion

        #region Método que lista todos os fornecedores

        public DataTable ListarTodosFornecedores()
        {
            try
            {
                // 1 Passo  - Criar o comando SQL e o nosso DataTable
                DataTable tabelaFornecedor = new DataTable();
                string sql = @"select * from tb_fornecedores";

                // 2 Passo - Organizar e executar o comando sql
                MySqlCommand executasql = new MySqlCommand(sql, conexao);

                // 3 Passo - Abrir a conexão e executar o comando sql
                conexao.Open();
                executasql.ExecuteNonQuery();

                // 4 Passo - Preencher o nosso DataTable com os dados do select
                MySqlDataAdapter adapter = new MySqlDataAdapter(executasql);
                adapter.Fill(tabelaFornecedor); // fill significa preencher
                return tabelaFornecedor;
            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: " + erro);
                return null;
            }


        }

        #endregion

        #region Método que consulta um fornecedor por nome

        public DataTable ConsultarFornedorPorNome(string nome)
        {
            try
            {
                // 1 Passo  - Criar o comando SQL e o nosso DataTable
                DataTable tabelaFornecedor = new DataTable();
                string sql = @"select * from tb_fornecedores where nome = @nome";

                // 2 Passo - Organizar e executar o comando sql
                MySqlCommand executasql = new MySqlCommand(sql, conexao);
                executasql.Parameters.AddWithValue("@nome", nome);

                // 3 Passo - Abrir a conexão e executar o comando sql
                conexao.Open();
                executasql.ExecuteNonQuery();

                // 4 Passo - Preencher o nosso DataTable com os dados do select
                MySqlDataAdapter adapter = new MySqlDataAdapter(executasql);
                adapter.Fill(tabelaFornecedor); // fill significa preencher

                conexao.Close();
                return tabelaFornecedor;

            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro " + erro);
                return null;
            }
        }

        #endregion

        #region Método que consulta um Fornecedor por CNPJ

        public DataTable ConsultarFornecedorPorCnpj(string cnpj)
        {
            try
            {
                // 1 Passo  - Criar o comando SQL e o nosso DataTable
                DataTable tabelaFornecedor = new DataTable();
                string sql = @"select * from tb_fornecedores where cnpj = @cnpj";

                // 2 Passo - Organizar e executar o comando sql
                MySqlCommand executasql = new MySqlCommand(sql, conexao);
                executasql.Parameters.AddWithValue("@cnpj", cnpj);

                // 3 Passo - Abrir a conexão e executar o comando sql
                conexao.Open();
                executasql.ExecuteNonQuery();

                // 4 Passo - Preencher o nosso DataTable com os dados do select
                MySqlDataAdapter adapter = new MySqlDataAdapter(executasql);
                adapter.Fill(tabelaFornecedor); // fill significa preencher

                conexao.Close();

                return tabelaFornecedor;


            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro " + erro);
                return null;
            }
        }
        #endregion


    }
}
