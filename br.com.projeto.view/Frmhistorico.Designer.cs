
namespace Projeto_Vendas_Fatec.br.com.projeto.view
{
    partial class Frmhistorico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmhistorico));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnpesquisar = new System.Windows.Forms.Button();
            this.txtdatafim = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdatainicio = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dgHistorico = new System.Windows.Forms.DataGridView();
            this.btnexportar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgHistorico)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(647, 85);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(112, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(438, 77);
            this.label1.TabIndex = 0;
            this.label1.Text = "Histórico de vendas";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnpesquisar);
            this.groupBox1.Controls.Add(this.txtdatafim);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtdatainicio);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(623, 72);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consulta";
            // 
            // btnpesquisar
            // 
            this.btnpesquisar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnpesquisar.Image")));
            this.btnpesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnpesquisar.Location = new System.Drawing.Point(483, 25);
            this.btnpesquisar.Name = "btnpesquisar";
            this.btnpesquisar.Size = new System.Drawing.Size(117, 34);
            this.btnpesquisar.TabIndex = 4;
            this.btnpesquisar.Text = "Pesquisar";
            this.btnpesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnpesquisar.UseVisualStyleBackColor = true;
            this.btnpesquisar.Click += new System.EventHandler(this.btnpesquisar_Click);
            // 
            // txtdatafim
            // 
            this.txtdatafim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdatafim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtdatafim.Location = new System.Drawing.Point(347, 27);
            this.txtdatafim.Name = "txtdatafim";
            this.txtdatafim.Size = new System.Drawing.Size(117, 26);
            this.txtdatafim.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(260, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data fim:";
            // 
            // txtdatainicio
            // 
            this.txtdatainicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdatainicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtdatainicio.Location = new System.Drawing.Point(113, 27);
            this.txtdatainicio.Name = "txtdatainicio";
            this.txtdatainicio.Size = new System.Drawing.Size(119, 26);
            this.txtdatainicio.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Data início:";
            // 
            // dgHistorico
            // 
            this.dgHistorico.AllowUserToAddRows = false;
            this.dgHistorico.AllowUserToDeleteRows = false;
            this.dgHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgHistorico.Location = new System.Drawing.Point(12, 169);
            this.dgHistorico.Name = "dgHistorico";
            this.dgHistorico.ReadOnly = true;
            this.dgHistorico.Size = new System.Drawing.Size(623, 315);
            this.dgHistorico.TabIndex = 3;
            this.dgHistorico.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgHistorico_CellClick);
            // 
            // btnexportar
            // 
            this.btnexportar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexportar.Image = ((System.Drawing.Image)(resources.GetObject("btnexportar.Image")));
            this.btnexportar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnexportar.Location = new System.Drawing.Point(97, 495);
            this.btnexportar.Name = "btnexportar";
            this.btnexportar.Size = new System.Drawing.Size(147, 47);
            this.btnexportar.TabIndex = 10;
            this.btnexportar.Text = "Exportar Excel";
            this.btnexportar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnexportar.UseVisualStyleBackColor = true;
            this.btnexportar.Click += new System.EventHandler(this.btnexportar_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(359, 495);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 47);
            this.button1.TabIndex = 11;
            this.button1.Text = "Exportar CSV";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Frmhistorico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnexportar);
            this.Controls.Add(this.dgHistorico);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Frmhistorico";
            this.Text = "histórico de vendas";
            this.Load += new System.EventHandler(this.Frmhistorico_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgHistorico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnpesquisar;
        private System.Windows.Forms.DateTimePicker txtdatafim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker txtdatainicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgHistorico;
        private System.Windows.Forms.Button btnexportar;
        private System.Windows.Forms.Button button1;
    }
}