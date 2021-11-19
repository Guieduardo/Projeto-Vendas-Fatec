using Projeto_Vendas_Fatec.br.com.projeto.dao;
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
    public partial class Frmlogin : Form
    {
        public Frmlogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                //Botão entrar
                FuncionarioDAO dao = new FuncionarioDAO();
                string email; string senha;

                email = txtemail.Text;
                senha = txtsenha.Text;

                //esconder a tela de login
                this.Hide();
                dao.EfetuarLogin(email, senha);
            }
            catch (Exception)
            {

                MessageBox.Show("Preencha todos os campos!");
            }

        }
    }
}
