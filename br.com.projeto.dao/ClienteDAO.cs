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
    public class ClienteDAO
    {
        //Atributo da classe mysqlconncetion
        private MySqlConnection conexao;

        //Construtor
        public ClienteDAO()
        {
            this.conexao = new ConnectionFactory().GetConnection();
        }

        #region Método que cadastra um cliente
        public void CadastrarCliente(Cliente cliente) //(Cliente cliente é de acordo com a model
        {
            try
            {
                // 1 Passo - Criar o comando SQL
                string sql = @"insert into tb_clientes (nome,rg, cpf,email,telefone,celular,cep,endereco,numero,complemento,bairro,cidade,estado)
                                values(@nome, @rg, @cpf, @email, @telefone, @celular, @cep, @endereco, @numero, @comp, @bairro, @cidade, @estado)";

                //2 Passo - Organizar o comando SQL
                MySqlCommand executasql = new MySqlCommand(sql,conexao);
                executasql.Parameters.AddWithValue("@nome", cliente.nome);
                executasql.Parameters.AddWithValue("@rg", cliente.rg);
                executasql.Parameters.AddWithValue("@cpf", cliente.cpf);
                executasql.Parameters.AddWithValue("@email", cliente.email);
                executasql.Parameters.AddWithValue("@telefone", cliente.telefone);
                executasql.Parameters.AddWithValue("@celular", cliente.celular);
                executasql.Parameters.AddWithValue("@cep", cliente.cep);
                executasql.Parameters.AddWithValue("@endereco", cliente.endereco);
                executasql.Parameters.AddWithValue("@numero", cliente.numero);
                executasql.Parameters.AddWithValue("@comp", cliente.complemento);
                executasql.Parameters.AddWithValue("@bairro", cliente.bairro);
                executasql.Parameters.AddWithValue("@cidade", cliente.cidade);
                executasql.Parameters.AddWithValue("@estado", cliente.uf);

                // 3 Passo - Abrir a conexão e executar o comando sql
                conexao.Open();
                executasql.ExecuteNonQuery();

                MessageBox.Show("Cliente cadastrado com sucesso");

                // 4 Passo - Fechar a conexao
                conexao.Close();
            }

            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro" + erro);
            }
        }

        #endregion

        #region Método que altera um cliente
        public void AlterarCliente(Cliente cliente)
        {
            try
            {
                //1 passo - Criar o comando SQL
                string sql = @"update tb_clientes set nome = @nome, rg = @rg, cpf = @cpf , 
                                email = @email , telefone = @telefone, celular = @celular,
                                cep = @cep, endereco = @endereco, numero = @numero, complemento = @comp,
                                bairro = @bairro, cidade = @cidade, estado = @estado where id = @id";


                //2 Passo - Organizar o comando SQL
                MySqlCommand executasql = new MySqlCommand(sql, conexao);
                executasql.Parameters.AddWithValue("@nome", cliente.nome);
                executasql.Parameters.AddWithValue("@rg", cliente.rg);
                executasql.Parameters.AddWithValue("@cpf", cliente.cpf);
                executasql.Parameters.AddWithValue("@email", cliente.email);
                executasql.Parameters.AddWithValue("@telefone", cliente.telefone);
                executasql.Parameters.AddWithValue("@celular", cliente.celular);
                executasql.Parameters.AddWithValue("@cep", cliente.cep);
                executasql.Parameters.AddWithValue("@endereco", cliente.endereco);
                executasql.Parameters.AddWithValue("@numero", cliente.numero);
                executasql.Parameters.AddWithValue("@comp", cliente.complemento);
                executasql.Parameters.AddWithValue("@bairro", cliente.bairro);
                executasql.Parameters.AddWithValue("@cidade", cliente.cidade);
                executasql.Parameters.AddWithValue("@estado", cliente.uf);

                executasql.Parameters.AddWithValue("@id", cliente.id);

                // 3 Passo - Abrir a conexão e executar o comando sql
                conexao.Open();
                executasql.ExecuteNonQuery();

                MessageBox.Show("Dados do cliente alterados com sucesso");

                // 4 Passo - Fechar a conexao
                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro: " + erro);
            }
        }

        #endregion

        #region Método que exclui um cliente

        public void ExcluirCliente(int idcliente)
        {
            try
            {

                //1 passo - Criar o comando SQL
                string sql = @"delete from tb_clientes where id = @id";

                //2 Passo - Organizar o comando SQL
                MySqlCommand executasql = new MySqlCommand(sql, conexao);
                executasql.Parameters.AddWithValue("@id", idcliente);

                // 3 Passo - Abrir a conexão e executar o comando sql
                conexao.Open();
                executasql.ExecuteNonQuery();

                MessageBox.Show("Cliente excluido com sucesso");

                // 4 Passo - Fechar a conexao
                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro" + erro);
            }
        }

        #endregion

        #region Método que lista todos os clientes
        public DataTable ListarTodosClientes()
        {
            try
            {
                // 1 Passo  - Criar o comando SQL e o nosso DataTable
                DataTable tabelaCliente = new DataTable();
                string sql = @"select * from tb_clientes";

                // 2 Passo - Organizar e executar o comando sql
                MySqlCommand executasql = new MySqlCommand(sql, conexao);

                // 3 Passo - Abrir a conexão e executar o comando sql
                conexao.Open();
                executasql.ExecuteNonQuery();

                // 4 Passo - Preencher o nosso DataTable com os dados do select
                MySqlDataAdapter adapter = new MySqlDataAdapter(executasql);
                adapter.Fill(tabelaCliente); // fill significa preencher
                return tabelaCliente;

            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: " + erro);
                return null;
            }
        }

        #endregion

        #region Método que consulta um cliente por nome

        public DataTable ConsultarClientePorNome(string nome)
        {
            try
            {
                // 1 Passo  - Criar o comando SQL e o nosso DataTable
                DataTable tabelaCliente = new DataTable();
                string sql = @"select * from tb_clientes where nome = @nome";

                // 2 Passo - Organizar e executar o comando sql
                MySqlCommand executasql = new MySqlCommand(sql, conexao);
                executasql.Parameters.AddWithValue("@nome", nome);

                // 3 Passo - Abrir a conexão e executar o comando sql
                conexao.Open();
                executasql.ExecuteNonQuery();

                // 4 Passo - Preencher o nosso DataTable com os dados do select
                MySqlDataAdapter adapter = new MySqlDataAdapter(executasql);
                adapter.Fill(tabelaCliente); // fill significa preencher

                conexao.Close();
                return tabelaCliente;

            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro " + erro);
                return null;
            }
        }

        #endregion

        #region Método que consulta um cliente por CPF

        public DataTable ConsultarClientePorCpf(string cpf)
        {
            try
            {
                // 1 Passo  - Criar o comando SQL e o nosso DataTable
                DataTable tabelaCliente = new DataTable();
                string sql = @"select * from tb_clientes where cpf = @cpf";

                // 2 Passo - Organizar e executar o comando sql
                MySqlCommand executasql = new MySqlCommand(sql, conexao);
                executasql.Parameters.AddWithValue("@cpf",cpf);

                // 3 Passo - Abrir a conexão e executar o comando sql
                conexao.Open();
                executasql.ExecuteNonQuery();

                // 4 Passo - Preencher o nosso DataTable com os dados do select
                MySqlDataAdapter adapter = new MySqlDataAdapter(executasql);
                adapter.Fill(tabelaCliente); // fill significa preencher

                conexao.Close();

                return tabelaCliente;


            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro " + erro);
                return null;
            }
        }
        #endregion

        #region Método que retorna um objeto do tipo Cliente por CPF
        public Cliente RetornaClientePorCpf(string cpf)
        {
            try
            {
                //1 Passo - Criar o comando sql e o objeto Cliente
                Cliente cliente = new Cliente();
                string sql = @"select * from tb_clientes where cpf = @cpf";

                //2 Passo - Organizar o comando SQL
                MySqlCommand executasql = new MySqlCommand(sql, conexao);
                executasql.Parameters.AddWithValue("@cpf", cpf);

                // 3 Passo - Abrir a conexão e executar o comando sql
                conexao.Open();

                //4 Passo - Montar o objeto Cliente para ser retornado
                MySqlDataReader rs = executasql.ExecuteReader();
                if (rs.Read())//se conseguir encontrar algum cliente com o cpf
                {
                    //Monte o objeto
                    cliente.id = rs.GetInt32("id");//dentro do rs ele pega a coluna do id
                    cliente.nome = rs.GetString("nome");
                    conexao.Close();
                    return cliente;
                }
                else
                {
                    //Não encontrou ninguem
                    conexao.Close();
                    MessageBox.Show("Cliente não encontrado no banco de dados");
                    return null;
                }

                return cliente;
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
