
namespace Projeto_Vendas_Fatec.br.com.projeto.view
{
    partial class Frmdetalhe
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtdata = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtobs = new System.Windows.Forms.TextBox();
            this.txttotalvenda = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.txtcliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgItens = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgItens)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(791, 85);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(196, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 77);
            this.label1.TabIndex = 0;
            this.label1.Text = "Detalhe da Venda";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.txtdata);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtobs);
            this.groupBox1.Controls.Add(this.txttotalvenda);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblcodigo);
            this.groupBox1.Controls.Add(this.txtcliente);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(767, 178);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados da venda";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtdata
            // 
            this.txtdata.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdata.Location = new System.Drawing.Point(84, 74);
            this.txtdata.Name = "txtdata";
            this.txtdata.ReadOnly = true;
            this.txtdata.Size = new System.Drawing.Size(144, 26);
            this.txtdata.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Data:";
            // 
            // txtobs
            // 
            this.txtobs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtobs.Location = new System.Drawing.Point(131, 116);
            this.txtobs.Multiline = true;
            this.txtobs.Name = "txtobs";
            this.txtobs.ReadOnly = true;
            this.txtobs.Size = new System.Drawing.Size(611, 56);
            this.txtobs.TabIndex = 9;
            // 
            // txttotalvenda
            // 
            this.txttotalvenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotalvenda.Location = new System.Drawing.Point(539, 32);
            this.txttotalvenda.Name = "txttotalvenda";
            this.txttotalvenda.ReadOnly = true;
            this.txttotalvenda.Size = new System.Drawing.Size(203, 26);
            this.txttotalvenda.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Observações:";
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcodigo.Location = new System.Drawing.Point(19, 35);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(62, 20);
            this.lblcodigo.TabIndex = 5;
            this.lblcodigo.Text = "Cliente:";
            // 
            // txtcliente
            // 
            this.txtcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcliente.Location = new System.Drawing.Point(84, 32);
            this.txtcliente.Name = "txtcliente";
            this.txtcliente.ReadOnly = true;
            this.txtcliente.Size = new System.Drawing.Size(307, 26);
            this.txtcliente.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(416, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Total da venda:";
            // 
            // dgItens
            // 
            this.dgItens.AllowUserToAddRows = false;
            this.dgItens.AllowUserToDeleteRows = false;
            this.dgItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgItens.Location = new System.Drawing.Point(13, 276);
            this.dgItens.Name = "dgItens";
            this.dgItens.ReadOnly = true;
            this.dgItens.Size = new System.Drawing.Size(766, 222);
            this.dgItens.TabIndex = 3;
            // 
            // Frmdetalhe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 510);
            this.Controls.Add(this.dgItens);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Frmdetalhe";
            this.Text = "Detalhes das Vendas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgItens)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtobs;
        public System.Windows.Forms.TextBox txttotalvenda;
        public System.Windows.Forms.TextBox txtcliente;
        public System.Windows.Forms.DataGridView dgItens;
        public System.Windows.Forms.TextBox txtdata;
    }
}