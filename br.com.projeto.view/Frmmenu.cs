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
    public partial class Frmmenu : Form
    {
        public Frmmenu()
        {
            InitializeComponent();
        }

        private void menu_cadcliente_Click(object sender, EventArgs e)
        {
            Frmclientes tela = new Frmclientes();
            //tela.Show(); Abre a tela, mas pode abrir varias vezes
            tela.ShowDialog(); // Abre só uma tela por vez
        }

        private void menu_cadfunc_Click(object sender, EventArgs e)
        {
            Frmfuncionarios tela = new Frmfuncionarios();
            tela.ShowDialog();
        }

        private void menu_cadforn_Click(object sender, EventArgs e)
        {
            Frmfornecedores tela = new Frmfornecedores();
            tela.ShowDialog();
        }

        private void menu_cadproduto_Click(object sender, EventArgs e)
        {
            Frmprodutos tela = new Frmprodutos();
            tela.ShowDialog();
        }

        private void menu_cadvenda_Click(object sender, EventArgs e)
        {
            Frmvendas tela = new Frmvendas();
            tela.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Capturar a data e hora
            lblhora.Text = DateTime.Now.ToLongTimeString();

        }

        private void lblhora_Click(object sender, EventArgs e)
        {
            
        }

        private void Frmmenu_Load(object sender, EventArgs e)
        {
            //Capturar a data e hora
            lbldata.Text = DateTime.Now.ToShortDateString();
            timer1.Start();
        }

        private void consultarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Frmhistorico tela = new Frmhistorico();
            tela.ShowDialog();
        }
    }
}
