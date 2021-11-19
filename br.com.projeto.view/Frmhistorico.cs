using Projeto_Vendas_Fatec.br.com.projeto.dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Vendas_Fatec.br.com.projeto.view
{
    public partial class Frmhistorico : Form
    {
        public Frmhistorico()
        {
            InitializeComponent();
        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            //Botão Pesquisar
            try
            {
                DateTime dtinicio, dtfim;

                //Pega a primeira data
                dtinicio = txtdatainicio.Value;

                //Pega a segunda data
                dtfim = txtdatafim.Value;

                VendasDAO dao = new VendasDAO();
                dgHistorico.DataSource = dao.ListarVendasPorPeriodo(dtinicio, dtfim);


            }
            catch (Exception)
            {

                MessageBox.Show("Não foram encontradas vendas neste periodo!");
            }
        }

        private void Frmhistorico_Load(object sender, EventArgs e)
        {
            //Chamando o metodo que lista todas as vendas
            VendasDAO dao = new VendasDAO();
            dgHistorico.DataSource = dao.ListarVendas();
        }

        private void dgHistorico_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Clicando em uma venda

            //1° Passo - Criar os objetos e declaração de variavel
            ItemVendaDAO itemdao= new ItemVendaDAO();
            int venda_id;

            //2° Passo - Pegar o Id de uma venda
            venda_id = int.Parse(dgHistorico.CurrentRow.Cells[0].Value.ToString());

            //3° Passo - Passor os dados para a outra tela
            Frmdetalhe tela = new Frmdetalhe();
            tela.txtdata.Text = dgHistorico.CurrentRow.Cells[1].Value.ToString();
            tela.txttotalvenda.Text = dgHistorico.CurrentRow.Cells[2].Value.ToString();
            tela.txtcliente.Text = dgHistorico.CurrentRow.Cells[3].Value.ToString();
            tela.txtobs.Text = dgHistorico.CurrentRow.Cells[4].Value.ToString();

            tela.dgItens.DataSource = itemdao.ListarItensPorVenda(venda_id);

            //4° Passo - Chamar a tela de detalhes.
            tela.ShowDialog();

        }

        private void btnexportar_Click(object sender, EventArgs e)
        {

            //Comandos para exportar para Excel
            Microsoft.Office.Interop.Excel.Application Excel = new Microsoft.Office.Interop.Excel.Application();

            if (dgHistorico.Rows.Count > 0)
            {
                try
                {
                    Excel.Application.Workbooks.Add(Type.Missing);
                    for (int i = 1; i < dgHistorico.Columns.Count + 1; i++)
                    {
                        Excel.Cells[1, i] = dgHistorico.Columns[i - 1].HeaderText;
                    }
                    //
                    for (int i = 0; i <= dgHistorico.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < dgHistorico.Columns.Count; j++)
                        {
                            Excel.Cells[i + 2, j + 1] = dgHistorico.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                    //
                    Excel.Columns.AutoFit();
                    //
                    Excel.Visible = true;
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro : " + erro.Message);
                    Excel.Quit();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Comandos para exportar para CSV

            string filename = "";
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV (*.csv)|*.csv";
            sfd.FileName = "Output.csv";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Os dados estão sendo exportados.");
                if (File.Exists(filename))
                {
                    try
                    {
                        File.Delete(filename);
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show("Não foi possível gravar os dados" + ex.Message);
                    }
                }
                int columnCount = dgHistorico.ColumnCount;
                string columnNames = "";
                string[] output = new string[dgHistorico.RowCount + 1];
                for (int i = 0; i < columnCount; i++)
                {
                    columnNames += dgHistorico.Columns[i].Name.ToString() + ",";
                }
                output[0] += columnNames;
                for (int i = 1; (i - 1) < dgHistorico.RowCount; i++)
                {
                    for (int j = 0; j < columnCount; j++)
                    {
                        output[i] += dgHistorico.Rows[i - 1].Cells[j].Value.ToString() + ",";
                    }
                }
                System.IO.File.WriteAllLines(sfd.FileName, output, System.Text.Encoding.UTF8);
                MessageBox.Show("Os dados foram exportados com sucesso. Procure o arquivo onde escolheu para salvar");
            }
        }
    }
}
