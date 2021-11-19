using MySql.Data.MySqlClient;
using Projeto_Vendas_Fatec.br.com.projeto.con;
using Projeto_Vendas_Fatec.br.com.projeto.model;
using Projeto_Vendas_Fatec.br.com.projeto.view;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Vendas_Fatec.br.com.projeto.dao
{
    public class FuncionarioDAO
    {
        //Atributo da classe mysqlconncetion
        private MySqlConnection conexao;

        public FuncionarioDAO()
        {
            this.conexao = new ConnectionFactory().GetConnection();
        }

        #region Método que cadastra um funcionario
        public void CadastrarFuncionario(Funcionarios funcionario) //(Funcionarios (model)  funcionario (nova variavel)
        {
            try
            {
                // 1 Passo - Criar o comando SQL
                string sql = @"insert into tb_funcionarios (nome,rg, cpf,email, senha, cargo, nivel_acesso, telefone,celular,cep,endereco,numero,complemento,bairro,cidade,estado)
                                values(@nome, @rg, @cpf, @email, @senha, @cargo, @nivel, @telefone, @celular, @cep, @endereco, @numero, @comp, @bairro, @cidade, @estado)";

                //2 Passo - Organizar o comando SQL
                MySqlCommand executasql = new MySqlCommand(sql, conexao);
                executasql.Parameters.AddWithValue("@nome", funcionario.nome);
                executasql.Parameters.AddWithValue("@rg", funcionario.rg);
                executasql.Parameters.AddWithValue("@cpf", funcionario.cpf);
                executasql.Parameters.AddWithValue("@email", funcionario.email);
                executasql.Parameters.AddWithValue("@senha", funcionario.senha);
                executasql.Parameters.AddWithValue("@cargo", funcionario.cargo);
                executasql.Parameters.AddWithValue("@nivel", funcionario.nivel);
                executasql.Parameters.AddWithValue("@telefone", funcionario.telefone);
                executasql.Parameters.AddWithValue("@celular", funcionario.celular);
                executasql.Parameters.AddWithValue("@cep", funcionario.cep);
                executasql.Parameters.AddWithValue("@endereco", funcionario.endereco);
                executasql.Parameters.AddWithValue("@numero", funcionario.numero);
                executasql.Parameters.AddWithValue("@comp", funcionario.complemento);
                executasql.Parameters.AddWithValue("@bairro", funcionario.bairro);
                executasql.Parameters.AddWithValue("@cidade", funcionario.cidade);
                executasql.Parameters.AddWithValue("@estado", funcionario.uf);

                // 3 Passo - Abrir a conexão e executar o comando sql
                conexao.Open();
                executasql.ExecuteNonQuery();

                MessageBox.Show("Funcionario cadastrado com sucesso");

                // 4 Passo - Fechar a conexao
                conexao.Close();
            }

            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro" + erro);
            }
        }

        #endregion

        #region Método que altera um funcionario

        public void AlterarFuncionario(Funcionarios funcionario)
        {
            try
            {
                //1 passo - Criar o comando SQL
                string sql = @"update tb_funcionarios set nome = @nome, rg = @rg, cpf = @cpf , 
                                email = @email , senha = @senha, cargo = @cargo , nivel_acesso = @nivel ,
                                telefone = @telefone, celular = @celular,
                                cep = @cep, endereco = @endereco, numero = @numero, complemento = @comp,
                                bairro = @bairro, cidade = @cidade, estado = @estado where id = @id";


                //2 Passo - Organizar o comando SQL
                MySqlCommand executasql = new MySqlCommand(sql, conexao);
                executasql.Parameters.AddWithValue("@nome", funcionario.nome);
                executasql.Parameters.AddWithValue("@rg", funcionario.rg);
                executasql.Parameters.AddWithValue("@cpf", funcionario.cpf);
                executasql.Parameters.AddWithValue("@email", funcionario.email);
                executasql.Parameters.AddWithValue("@senha", funcionario.senha);
                executasql.Parameters.AddWithValue("@cargo", funcionario.cargo);
                executasql.Parameters.AddWithValue("@nivel", funcionario.nivel);
                executasql.Parameters.AddWithValue("@telefone", funcionario.telefone);
                executasql.Parameters.AddWithValue("@celular", funcionario.celular);
                executasql.Parameters.AddWithValue("@cep", funcionario.cep);
                executasql.Parameters.AddWithValue("@endereco", funcionario.endereco);
                executasql.Parameters.AddWithValue("@numero", funcionario.numero);
                executasql.Parameters.AddWithValue("@comp", funcionario.complemento);
                executasql.Parameters.AddWithValue("@bairro", funcionario.bairro);
                executasql.Parameters.AddWithValue("@cidade", funcionario.cidade);
                executasql.Parameters.AddWithValue("@estado", funcionario.uf);

                executasql.Parameters.AddWithValue("@id", funcionario.id);

                // 3 Passo - Abrir a conexão e executar o comando sql
                conexao.Open();
                executasql.ExecuteNonQuery();

                MessageBox.Show("Dados do funcionario alterados com sucesso");

                // 4 Passo - Fechar a conexao
                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro: " + erro);
            }
        }

        #endregion

        #region Método que exclui um funcionario

        public void ExcluirFuncionario(int idfuncionario)
        {
            try
            {

                //1 passo - Criar o comando SQL
                string sql = @"delete from tb_funcionarios where id = @id";

                //2 Passo - Organizar o comando SQL
                MySqlCommand executasql = new MySqlCommand(sql, conexao);
                executasql.Parameters.AddWithValue("@id", idfuncionario);

                // 3 Passo - Abrir a conexão e executar o comando sql
                conexao.Open();
                executasql.ExecuteNonQuery();

                MessageBox.Show("Funcionario excluido com sucesso");

                // 4 Passo - Fechar a conexao
                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro" + erro);
            }
        }

        #endregion

        #region Método que lista todos os funcionarios

        public DataTable ListarTodosFuncionarios()
        {
            try
            {
                // 1 Passo  - Criar o comando SQL e o nosso DataTable
                DataTable tabelaFuncionario = new DataTable();
                string sql = @"select * from tb_funcionarios";

                // 2 Passo - Organizar e executar o comando sql
                MySqlCommand executasql = new MySqlCommand(sql, conexao);

                // 3 Passo - Abrir a conexão e executar o comando sql
                conexao.Open();
                executasql.ExecuteNonQuery();

                // 4 Passo - Preencher o nosso DataTable com os dados do select
                MySqlDataAdapter adapter = new MySqlDataAdapter(executasql);
                adapter.Fill(tabelaFuncionario); // fill significa preencher
                return tabelaFuncionario;

            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: " + erro);
                return null;
            }
        }

        #endregion

        #region Método que busca um funcionario por nome
        public DataTable ConsultarFuncionarioPorNome(string nome)
        {
            try
            {
                // 1 Passo  - Criar o comando SQL e o nosso DataTable
                DataTable tabelafuncionario = new DataTable();
                string sql = @"select * from tb_funcionarios where nome = @nome";

                // 2 Passo - Organizar e executar o comando sql
                MySqlCommand executasql = new MySqlCommand(sql, conexao);
                executasql.Parameters.AddWithValue("@nome", nome);

                // 3 Passo - Abrir a conexão e executar o comando sql
                conexao.Open();
                executasql.ExecuteNonQuery();

                // 4 Passo - Preencher o nosso DataTable com os dados do select
                MySqlDataAdapter adapter = new MySqlDataAdapter(executasql);
                adapter.Fill(tabelafuncionario); // fill significa preencher

                conexao.Close();
                return tabelafuncionario;

            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro " + erro);
                return null;
            }
        }

        #endregion

        #region Método que busca um funcionario por CPF
        public DataTable ConsultarFuncionarioPorCpf(string cpf)
        {
            try
            {
                // 1 Passo  - Criar o comando SQL e o nosso DataTable
                DataTable tabelaFuncionario = new DataTable();
                string sql = @"select * from tb_funcionarios where cpf = @cpf";

                // 2 Passo - Organizar e executar o comando sql
                MySqlCommand executasql = new MySqlCommand(sql, conexao);
                executasql.Parameters.AddWithValue("@cpf", cpf);

                // 3 Passo - Abrir a conexão e executar o comando sql
                conexao.Open();
                executasql.ExecuteNonQuery();

                // 4 Passo - Preencher o nosso DataTable com os dados do select
                MySqlDataAdapter adapter = new MySqlDataAdapter(executasql);
                adapter.Fill(tabelaFuncionario); // fill significa preencher

                conexao.Close();

                return tabelaFuncionario;


            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro " + erro);
                return null;
            }
        }

        #endregion

        #region Método que efetua login
        public void EfetuarLogin(string email, string senha)
        {
            try
            {
                //1 Passo - Criar o comando SQL
                string sql = @"SELECT * FROM tb_funcionarios WHERE email = @email AND senha = @senha ";

                //2 Passo - Organizar o comando SQL
                MySqlCommand executasql = new MySqlCommand(sql, conexao);
                executasql.Parameters.AddWithValue("@email", email);
                executasql.Parameters.AddWithValue("@senha", senha);

                //Passo - Abrir a conexão e executar o comando SQL
                conexao.Open();
                MySqlDataReader rs = executasql.ExecuteReader();

                if (rs.Read())// se conseguiu ler os dados dentro do datareader
                {
                    //Fez login
                    //Descobrir o nivel de acesso deste usuario 
                    string nivel = rs.GetString("nivel_acesso");
                    string nome = rs.GetString("nome");

                    //Criando um objeto da tela de menu
                    Frmmenu telamenu = new Frmmenu();
                    telamenu.lbllogado.Text = nome;

                    //Restrições
                    if (nivel.Equals("Administrador"))
                    {
                        MessageBox.Show("Bem vindo ao sistema, " + nome);
                        //Abre a tela de menu
                        telamenu.ShowDialog();
                    }
                    else if (nivel.Equals("Usuario"))
                    {
                        MessageBox.Show("Bem vindo ao sistema, " + nome);
                        //Especificar as permissões
                        telamenu.menu_relatorio.Enabled = false;
                        telamenu.menu_cadproduto.Visible = false;

                        //Abre a tela de menu
                        telamenu.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Usuario ou Senha incorreto!");

                }

                //Fecha a conexão
                conexao.Close();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: " + erro);
            }



        }
        #endregion

    }
}
