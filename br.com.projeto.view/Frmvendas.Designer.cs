
namespace Projeto_Vendas_Fatec.br.com.projeto.view
{
    partial class Frmvendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmvendas));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtdata = new System.Windows.Forms.TextBox();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.txtcpf = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtqtd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtdescricao = new System.Windows.Forms.TextBox();
            this.txtpreco = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnadicionar = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.dgProdutos = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnpagar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProdutos)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(969, 85);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(275, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(439, 77);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Vendas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtnome);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtdata);
            this.groupBox1.Controls.Add(this.lblcodigo);
            this.groupBox1.Controls.Add(this.txtcpf);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(12, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 137);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Cliente";
            // 
            // txtnome
            // 
            this.txtnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnome.Location = new System.Drawing.Point(71, 87);
            this.txtnome.Name = "txtnome";
            this.txtnome.ReadOnly = true;
            this.txtnome.Size = new System.Drawing.Size(293, 26);
            this.txtnome.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nome";
            // 
            // txtdata
            // 
            this.txtdata.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdata.Location = new System.Drawing.Point(71, 25);
            this.txtdata.Name = "txtdata";
            this.txtdata.ReadOnly = true;
            this.txtdata.Size = new System.Drawing.Size(111, 26);
            this.txtdata.TabIndex = 12;
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcodigo.Location = new System.Drawing.Point(6, 28);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(48, 20);
            this.lblcodigo.TabIndex = 11;
            this.lblcodigo.Text = "Data:";
            // 
            // txtcpf
            // 
            this.txtcpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcpf.Location = new System.Drawing.Point(71, 57);
            this.txtcpf.Mask = "###.###.###-##";
            this.txtcpf.Name = "txtcpf";
            this.txtcpf.Size = new System.Drawing.Size(149, 24);
            this.txtcpf.TabIndex = 9;
            this.txtcpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcpf_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "CPF:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtqtd);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtdescricao);
            this.groupBox2.Controls.Add(this.txtpreco);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtcodigo);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 251);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(375, 137);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados do Produto";
            // 
            // txtqtd
            // 
            this.txtqtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqtd.Location = new System.Drawing.Point(287, 90);
            this.txtqtd.Name = "txtqtd";
            this.txtqtd.Size = new System.Drawing.Size(77, 26);
            this.txtqtd.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(189, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Quantidade";
            // 
            // txtdescricao
            // 
            this.txtdescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescricao.Location = new System.Drawing.Point(92, 57);
            this.txtdescricao.Name = "txtdescricao";
            this.txtdescricao.ReadOnly = true;
            this.txtdescricao.Size = new System.Drawing.Size(272, 26);
            this.txtdescricao.TabIndex = 15;
            // 
            // txtpreco
            // 
            this.txtpreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpreco.Location = new System.Drawing.Point(92, 90);
            this.txtpreco.Name = "txtpreco";
            this.txtpreco.ReadOnly = true;
            this.txtpreco.Size = new System.Drawing.Size(77, 26);
            this.txtpreco.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Preço (R$)";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigo.Location = new System.Drawing.Point(92, 25);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(111, 26);
            this.txtcodigo.TabIndex = 12;
            this.txtcodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcodigo_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Código";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Descrição";
            // 
            // btnadicionar
            // 
            this.btnadicionar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadicionar.Image = ((System.Drawing.Image)(resources.GetObject("btnadicionar.Image")));
            this.btnadicionar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnadicionar.Location = new System.Drawing.Point(22, 394);
            this.btnadicionar.Name = "btnadicionar";
            this.btnadicionar.Size = new System.Drawing.Size(128, 37);
            this.btnadicionar.TabIndex = 5;
            this.btnadicionar.Text = "Adicionar Item";
            this.btnadicionar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnadicionar.UseVisualStyleBackColor = true;
            this.btnadicionar.Click += new System.EventHandler(this.btnadicionar_Click);
            // 
            // btnexcluir
            // 
            this.btnexcluir.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnexcluir.Image")));
            this.btnexcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnexcluir.Location = new System.Drawing.Point(248, 394);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(112, 37);
            this.btnexcluir.TabIndex = 6;
            this.btnexcluir.Text = "Excluir Item";
            this.btnexcluir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // dgProdutos
            // 
            this.dgProdutos.AllowUserToAddRows = false;
            this.dgProdutos.AllowUserToDeleteRows = false;
            this.dgProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProdutos.Location = new System.Drawing.Point(410, 91);
            this.dgProdutos.Name = "dgProdutos";
            this.dgProdutos.ReadOnly = true;
            this.dgProdutos.Size = new System.Drawing.Size(547, 243);
            this.dgProdutos.TabIndex = 7;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txttotal);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(410, 341);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(547, 83);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            // 
            // txttotal
            // 
            this.txttotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotal.Location = new System.Drawing.Point(224, 35);
            this.txttotal.Name = "txttotal";
            this.txttotal.ReadOnly = true;
            this.txttotal.Size = new System.Drawing.Size(223, 26);
            this.txttotal.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(113, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Total (R$)";
            // 
            // btncancelar
            // 
            this.btncancelar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.Image")));
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncancelar.Location = new System.Drawing.Point(769, 430);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(167, 47);
            this.btncancelar.TabIndex = 10;
            this.btncancelar.Text = "Cancelar Venda";
            this.btncancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncancelar.UseVisualStyleBackColor = true;
            // 
            // btnpagar
            // 
            this.btnpagar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpagar.Image = ((System.Drawing.Image)(resources.GetObject("btnpagar.Image")));
            this.btnpagar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnpagar.Location = new System.Drawing.Point(499, 430);
            this.btnpagar.Name = "btnpagar";
            this.btnpagar.Size = new System.Drawing.Size(133, 47);
            this.btnpagar.TabIndex = 9;
            this.btnpagar.Text = "Pagamento";
            this.btnpagar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnpagar.UseVisualStyleBackColor = true;
            this.btnpagar.Click += new System.EventHandler(this.btnpagar_Click);
            // 
            // Frmvendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 489);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnpagar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dgProdutos);
            this.Controls.Add(this.btnexcluir);
            this.Controls.Add(this.btnadicionar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Frmvendas";
            this.Text = "Tela de Vendas";
            this.Load += new System.EventHandler(this.Frmvendas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProdutos)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox txtcpf;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtdata;
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtqtd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtdescricao;
        private System.Windows.Forms.TextBox txtpreco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnadicionar;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.DataGridView dgProdutos;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnpagar;
    }
}