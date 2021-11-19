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
    public partial class Frmfuncionarios : Form
    {
        public Frmfuncionarios()
        {
            InitializeComponent();
        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            //Botão que consulta o CEP
            try
            {
                // 1 Passo - Receber o CEP
                string cep = txtcep.Text;
                string xml = "https://viacep.com.br/ws/" + cep + "/xml";

                DataSet dados = new DataSet();
                dados.ReadXml(xml);

                //Exibir os dados no campo de texto
                txtendereco.Text = dados.Tables[0].Rows[0]["logradouro"].ToString();
                txtbairro.Text = dados.Tables[0].Rows[0]["bairro"].ToString();
                txtcidade.Text = dados.Tables[0].Rows[0]["localidade"].ToString();
                txtcomplemento.Text = dados.Tables[0].Rows[0]["complemento"].ToString();
                cbuf.Text = dados.Tables[0].Rows[0]["uf"].ToString();

            }
            catch (Exception)
            {

                MessageBox.Show("Endereço não encontrado, por favor digite manualmente");

            }
        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            //Botão cadastrar
            //1 passo - Receber os dados em um objeto model do funcionario
            Funcionarios funcionario = new Funcionarios();

            funcionario.nome = txtnome.Text;
            funcionario.rg = txtrg.Text;
            funcionario.cpf = txtcpf.Text;
            funcionario.email = txtemail.Text;
            funcionario.cargo = txtcargo.Text;
            funcionario.telefone = txttelefone.Text;
            funcionario.celular = txtcelular.Text;
            funcionario.cep = txtcep.Text;
            funcionario.endereco = txtendereco.Text;
            funcionario.numero = int.Parse(txtnumero.Text);
            funcionario.complemento = txtcomplemento.Text;
            funcionario.bairro = txtbairro.Text;
            funcionario.cidade = txtcidade.Text;
            funcionario.uf = cbuf.Text;
            funcionario.nivel = cbacesso.Text;
            funcionario.senha = txtsenha.Text;

            //2 passo Criar o objeto FuncionarioDAO para chamar o método CadastrarFuncionario
            FuncionarioDAO dao = new FuncionarioDAO();
            dao.CadastrarFuncionario(funcionario);

            //Recarregar o datagridview
            dgfuncionarios.DataSource = dao.ListarTodosFuncionarios();
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            //Botão excluir
            FuncionarioDAO dao = new FuncionarioDAO();
            dao.ExcluirFuncionario(int.Parse(txtcodigo.Text));

            //Recarregar o datagridview
            dgfuncionarios.DataSource = dao.ListarTodosFuncionarios();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            //botão editar
            //1 passo - Receber os dados em um objeto model do funcionario
            Funcionarios funcionario = new Funcionarios();

            funcionario.nome = txtnome.Text;
            funcionario.rg = txtrg.Text;
            funcionario.cpf = txtcpf.Text;
            funcionario.email = txtemail.Text;
            funcionario.cargo = txtcargo.Text;
            funcionario.telefone = txttelefone.Text;
            funcionario.celular = txtcelular.Text;
            funcionario.cep = txtcep.Text;
            funcionario.endereco = txtendereco.Text;
            funcionario.numero = int.Parse(txtnumero.Text);
            funcionario.complemento = txtcomplemento.Text;
            funcionario.bairro = txtbairro.Text;
            funcionario.cidade = txtcidade.Text;
            funcionario.uf = cbuf.Text;
            funcionario.nivel = cbacesso.Text;
            funcionario.senha = txtsenha.Text;

            //2 Receber o id do funcionario
            funcionario.id = int.Parse(txtcodigo.Text);

            //3 passo Criar o objeto FuncionarioDAO para chamar o método alterar o funcionario
            FuncionarioDAO dao = new FuncionarioDAO();
            dao.AlterarFuncionario(funcionario);

            //Recarregar o datagridview
            dgfuncionarios.DataSource = dao.ListarTodosFuncionarios();

        }

        private void Frmfuncionarios_Load(object sender, EventArgs e)
        {
            //Carrega a tela 
             FuncionarioDAO dao = new FuncionarioDAO();
            //Exibe todos os funcionarios dentro do data gride view
            dgfuncionarios.DataSource = dao.ListarTodosFuncionarios();
        }

        private void dgfuncionarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Pegando os dados da linha selecionada
            txtcodigo.Text = dgfuncionarios.CurrentRow.Cells[0].Value.ToString();
            txtnome.Text = dgfuncionarios.CurrentRow.Cells[1].Value.ToString();
            txtrg.Text = dgfuncionarios.CurrentRow.Cells[2].Value.ToString();
            txtcpf.Text = dgfuncionarios.CurrentRow.Cells[3].Value.ToString();
            txtemail.Text = dgfuncionarios.CurrentRow.Cells[4].Value.ToString();
            txtsenha.Text = dgfuncionarios.CurrentRow.Cells[5].Value.ToString();
            txtcargo.Text = dgfuncionarios.CurrentRow.Cells[6].Value.ToString();
            cbacesso.Text = dgfuncionarios.CurrentRow.Cells[7].Value.ToString();
            txttelefone.Text = dgfuncionarios.CurrentRow.Cells[8].Value.ToString();
            txtcelular.Text = dgfuncionarios.CurrentRow.Cells[9].Value.ToString();
            txtcep.Text = dgfuncionarios.CurrentRow.Cells[10].Value.ToString();
            txtendereco.Text = dgfuncionarios.CurrentRow.Cells[11].Value.ToString();
            txtnumero.Text = dgfuncionarios.CurrentRow.Cells[12].Value.ToString();
            txtcomplemento.Text = dgfuncionarios.CurrentRow.Cells[13].Value.ToString();
            txtbairro.Text = dgfuncionarios.CurrentRow.Cells[14].Value.ToString();
            txtcidade.Text = dgfuncionarios.CurrentRow.Cells[15].Value.ToString();
            cbuf.Text = dgfuncionarios.CurrentRow.Cells[16].Value.ToString();

            //Alterar para a guia de dados pessoais
            tabControl1.SelectedTab = tabPage1;
        }

        private void Btnconsultar_Click(object sender, EventArgs e)
        {
            //Botão consultar Funcionario
            string dados = txtconsulta.Text;
            FuncionarioDAO dao = new FuncionarioDAO();

            //Verificar qual a opção escolhida na opção combobox filtro
            if (Cbfiltros.SelectedIndex == 0)
            {
                MessageBox.Show("Consulta por nome");
                dgfuncionarios.DataSource = dao.ConsultarFuncionarioPorNome(dados);

            }
            else if (Cbfiltros.SelectedIndex == 1)
            {
                MessageBox.Show("Consulta por CPF");
                dgfuncionarios.DataSource = dao.ConsultarFuncionarioPorCpf(dados);
            }

            if (dgfuncionarios.Rows.Count == 0)
            {
                MessageBox.Show("Funcionario não encontrado!");
                dgfuncionarios.DataSource = dao.ListarTodosFuncionarios();
            }
        }
    }
}
