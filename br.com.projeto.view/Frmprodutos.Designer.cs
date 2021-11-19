
namespace Projeto_Vendas_Fatec.br.com.projeto.view
{
    partial class Frmprodutos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmprodutos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cbfornecedor = new System.Windows.Forms.ComboBox();
            this.txtestoque = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtpreco = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdesc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Cbfiltros = new System.Windows.Forms.ComboBox();
            this.dgprodutos = new System.Windows.Forms.DataGridView();
            this.Btnconsultar = new System.Windows.Forms.Button();
            this.txtconsulta = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.Btneditar = new System.Windows.Forms.Button();
            this.Btnexcluir = new System.Windows.Forms.Button();
            this.Btncadastrar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgprodutos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 85);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(171, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(475, 77);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Produtos";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 91);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 360);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cbfornecedor);
            this.tabPage1.Controls.Add(this.txtestoque);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txtpreco);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtdesc);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtcodigo);
            this.tabPage1.Controls.Add(this.lblcodigo);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 334);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dados do Produto";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // cbfornecedor
            // 
            this.cbfornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbfornecedor.FormattingEnabled = true;
            this.cbfornecedor.Location = new System.Drawing.Point(163, 231);
            this.cbfornecedor.Name = "cbfornecedor";
            this.cbfornecedor.Size = new System.Drawing.Size(445, 28);
            this.cbfornecedor.TabIndex = 19;
            // 
            // txtestoque
            // 
            this.txtestoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtestoque.Location = new System.Drawing.Point(163, 192);
            this.txtestoque.Name = "txtestoque";
            this.txtestoque.Size = new System.Drawing.Size(158, 26);
            this.txtestoque.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(44, 233);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 20);
            this.label10.TabIndex = 17;
            this.label10.Text = "Fornecedor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Qtde. Estoque";
            // 
            // txtpreco
            // 
            this.txtpreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpreco.Location = new System.Drawing.Point(163, 147);
            this.txtpreco.Name = "txtpreco";
            this.txtpreco.Size = new System.Drawing.Size(158, 26);
            this.txtpreco.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(85, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Preço";
            // 
            // txtdesc
            // 
            this.txtdesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdesc.Location = new System.Drawing.Point(163, 106);
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.Size = new System.Drawing.Size(593, 26);
            this.txtdesc.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descrição";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigo.Location = new System.Drawing.Point(163, 66);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(63, 26);
            this.txtcodigo.TabIndex = 1;
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcodigo.Location = new System.Drawing.Point(72, 69);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(63, 20);
            this.lblcodigo.TabIndex = 0;
            this.lblcodigo.Text = "Código:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Cbfiltros);
            this.tabPage2.Controls.Add(this.dgprodutos);
            this.tabPage2.Controls.Add(this.Btnconsultar);
            this.tabPage2.Controls.Add(this.txtconsulta);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 334);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consulta de Produtos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Cbfiltros
            // 
            this.Cbfiltros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbfiltros.FormattingEnabled = true;
            this.Cbfiltros.Items.AddRange(new object[] {
            "Nome "});
            this.Cbfiltros.Location = new System.Drawing.Point(533, 13);
            this.Cbfiltros.Name = "Cbfiltros";
            this.Cbfiltros.Size = new System.Drawing.Size(121, 28);
            this.Cbfiltros.TabIndex = 19;
            // 
            // dgprodutos
            // 
            this.dgprodutos.AllowUserToAddRows = false;
            this.dgprodutos.AllowUserToDeleteRows = false;
            this.dgprodutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgprodutos.Location = new System.Drawing.Point(24, 61);
            this.dgprodutos.Name = "dgprodutos";
            this.dgprodutos.ReadOnly = true;
            this.dgprodutos.Size = new System.Drawing.Size(760, 267);
            this.dgprodutos.TabIndex = 18;
            this.dgprodutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgprodutos_CellClick);
            // 
            // Btnconsultar
            // 
            this.Btnconsultar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnconsultar.Image = ((System.Drawing.Image)(resources.GetObject("Btnconsultar.Image")));
            this.Btnconsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btnconsultar.Location = new System.Drawing.Point(677, 16);
            this.Btnconsultar.Name = "Btnconsultar";
            this.Btnconsultar.Size = new System.Drawing.Size(95, 28);
            this.Btnconsultar.TabIndex = 3;
            this.Btnconsultar.Text = "Consultar";
            this.Btnconsultar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btnconsultar.UseVisualStyleBackColor = true;
            // 
            // txtconsulta
            // 
            this.txtconsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtconsulta.Location = new System.Drawing.Point(81, 15);
            this.txtconsulta.Name = "txtconsulta";
            this.txtconsulta.Size = new System.Drawing.Size(432, 26);
            this.txtconsulta.TabIndex = 2;
            this.txtconsulta.TextChanged += new System.EventHandler(this.txtconsulta_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(20, 19);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 20);
            this.label16.TabIndex = 4;
            this.label16.Text = "Dados";
            // 
            // Btneditar
            // 
            this.Btneditar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btneditar.Image = ((System.Drawing.Image)(resources.GetObject("Btneditar.Image")));
            this.Btneditar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btneditar.Location = new System.Drawing.Point(585, 452);
            this.Btneditar.Name = "Btneditar";
            this.Btneditar.Size = new System.Drawing.Size(106, 41);
            this.Btneditar.TabIndex = 22;
            this.Btneditar.Text = "Editar";
            this.Btneditar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btneditar.UseVisualStyleBackColor = true;
            this.Btneditar.Click += new System.EventHandler(this.Btneditar_Click);
            // 
            // Btnexcluir
            // 
            this.Btnexcluir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnexcluir.Image = ((System.Drawing.Image)(resources.GetObject("Btnexcluir.Image")));
            this.Btnexcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btnexcluir.Location = new System.Drawing.Point(342, 452);
            this.Btnexcluir.Name = "Btnexcluir";
            this.Btnexcluir.Size = new System.Drawing.Size(111, 41);
            this.Btnexcluir.TabIndex = 21;
            this.Btnexcluir.Text = "Excluir";
            this.Btnexcluir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btnexcluir.UseVisualStyleBackColor = true;
            this.Btnexcluir.Click += new System.EventHandler(this.Btnexcluir_Click);
            // 
            // Btncadastrar
            // 
            this.Btncadastrar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btncadastrar.Image = ((System.Drawing.Image)(resources.GetObject("Btncadastrar.Image")));
            this.Btncadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btncadastrar.Location = new System.Drawing.Point(90, 452);
            this.Btncadastrar.Name = "Btncadastrar";
            this.Btncadastrar.Size = new System.Drawing.Size(120, 41);
            this.Btncadastrar.TabIndex = 20;
            this.Btncadastrar.Text = "Cadastrar";
            this.Btncadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btncadastrar.UseVisualStyleBackColor = true;
            this.Btncadastrar.Click += new System.EventHandler(this.Btncadastrar_Click);
            // 
            // Frmprodutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 503);
            this.Controls.Add(this.Btneditar);
            this.Controls.Add(this.Btnexcluir);
            this.Controls.Add(this.Btncadastrar);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "Frmprodutos";
            this.Text = "Cadastro de Produtos";
            this.Load += new System.EventHandler(this.Frmprodutos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgprodutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtpreco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdesc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox Cbfiltros;
        private System.Windows.Forms.DataGridView dgprodutos;
        private System.Windows.Forms.Button Btnconsultar;
        private System.Windows.Forms.TextBox txtconsulta;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtestoque;
        private System.Windows.Forms.Button Btneditar;
        private System.Windows.Forms.Button Btnexcluir;
        private System.Windows.Forms.Button Btncadastrar;
        private System.Windows.Forms.ComboBox cbfornecedor;
    }
}