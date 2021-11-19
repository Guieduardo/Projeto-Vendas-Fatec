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
    public partial class Frmclientes : Form
    {
        public Frmclientes()
        {
            InitializeComponent();
        }

        private void Frmclientes_Load(object sender, EventArgs e)
        {
            //Carrega a tela 
            ClienteDAO dao = new ClienteDAO();
            //Exibe todos os clientes dentro do data gride view
            dgclientes.DataSource = dao.ListarTodosClientes();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

     

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtcodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
             
        }

        private void Btncadastrar_Click(object sender, EventArgs e)
        {
            //Botão cadastrar
            //1 passo - Receber os dados em um objeto model do cliente
            Cliente cliente = new Cliente();

            cliente.nome = txtnome.Text;
            cliente.rg = txtrg.Text;
            cliente.cpf = txtcpf.Text;
            cliente.email = txtemail.Text;
            cliente.telefone = txttelefone.Text;
            cliente.celular = txtcelular.Text;
            cliente.cep = txtcep.Text;
            cliente.endereco = txtendereco.Text;
            cliente.numero = int.Parse(txtnumero.Text);
            cliente.complemento = txtcomplemento.Text;
            cliente.bairro = txtbairro.Text;
            cliente.cidade = txtcidade.Text;
            cliente.uf = cbuf.Text;

            //2 passo Criar o objeto ClienteDAO para chamar o método CadastrarCliente
            ClienteDAO dao = new ClienteDAO();
            dao.CadastrarCliente(cliente);

            //Recarregar o datagridview
            dgclientes.DataSource = dao.ListarTodosClientes();
        }

        private void txtnumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgclientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Pegando os dados da linha selecionada
            txtcodigo.Text = dgclientes.CurrentRow.Cells[0].Value.ToString();
            txtnome.Text = dgclientes.CurrentRow.Cells[1].Value.ToString();
            txtrg.Text = dgclientes.CurrentRow.Cells[2].Value.ToString();
            txtcpf.Text = dgclientes.CurrentRow.Cells[3].Value.ToString();
            txtemail.Text = dgclientes.CurrentRow.Cells[4].Value.ToString();
            txttelefone.Text = dgclientes.CurrentRow.Cells[5].Value.ToString();
            txtcelular.Text = dgclientes.CurrentRow.Cells[6].Value.ToString();
            txtcep.Text = dgclientes.CurrentRow.Cells[7].Value.ToString();
            txtendereco.Text = dgclientes.CurrentRow.Cells[8].Value.ToString();
            txtnumero.Text = dgclientes.CurrentRow.Cells[9].Value.ToString();
            txtcomplemento.Text = dgclientes.CurrentRow.Cells[10].Value.ToString();
            txtbairro.Text = dgclientes.CurrentRow.Cells[11].Value.ToString();
            txtcidade.Text = dgclientes.CurrentRow.Cells[12].Value.ToString();
            cbuf.Text = dgclientes.CurrentRow.Cells[13].Value.ToString();

            //Alterar para a guia de dados pessoais
            tabControl1.SelectedTab = tabPage1;
        }

        private void Btneditar_Click(object sender, EventArgs e)
        {
            //botão editar
            //1 passo - Receber os dados em um objeto model do cliente
            Cliente cliente = new Cliente();

            cliente.nome = txtnome.Text;
            cliente.rg = txtrg.Text;
            cliente.cpf = txtcpf.Text;
            cliente.email = txtemail.Text;
            cliente.telefone = txttelefone.Text;
            cliente.celular = txtcelular.Text;
            cliente.cep = txtcep.Text;
            cliente.endereco = txtendereco.Text;
            cliente.numero = int.Parse(txtnumero.Text);
            cliente.complemento = txtcomplemento.Text;
            cliente.bairro = txtbairro.Text;
            cliente.cidade = txtcidade.Text;
            cliente.uf = cbuf.Text;

            //2 Receber o id do cliente
            cliente.id = int.Parse(txtcodigo.Text);

            //3 passo Criar o objeto ClienteDAO para chamar o método CadastrarCliente
            ClienteDAO dao = new ClienteDAO();
            dao.AlterarCliente(cliente);

            //Recarregar o datagridview
            dgclientes.DataSource = dao.ListarTodosClientes();

        }

        private void Btnexcluir_Click(object sender, EventArgs e)
        {
            //Botão excluir
            ClienteDAO dao = new ClienteDAO();
            dao.ExcluirCliente(int.Parse(txtcodigo.Text));

            //Recarregar o datagridview
            dgclientes.DataSource = dao.ListarTodosClientes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Botão que consulta o CEP
            try
            {
                // 1 Passo - Receber o CEP
                string cep = txtcep.Text;
                string xml = "https://viacep.com.br/ws/"+cep+"/xml";

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

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void txtconsulta_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Btnconsultar_Click(object sender, EventArgs e)
        {
            //Botão consultar cliente
            string dados = txtconsulta.Text;
            ClienteDAO dao = new ClienteDAO();

            //Verificar qual a opção escolhida na opção combobox filtro
            if(Cbfiltros.SelectedIndex == 0)
            {
                MessageBox.Show("Consulta por nome");
                dgclientes.DataSource = dao.ConsultarClientePorNome(dados);

            }
            else if(Cbfiltros.SelectedIndex == 1)
            {
                MessageBox.Show("Consulta por CPF");
                dgclientes.DataSource = dao.ConsultarClientePorCpf(dados);
            }

            if (dgclientes.Rows.Count == 0)
            {
                MessageBox.Show("Cliente não encontrado!");
                dgclientes.DataSource = dao.ListarTodosClientes();
            }


        }
    }
}
