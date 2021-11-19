
namespace Projeto_Vendas_Fatec.br.com.projeto.view
{
    partial class Frmmenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmmenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_cadcliente = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_cadfunc = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.forncedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_cadforn = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_cadproduto = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_cadvenda = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_relatorio = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbllogado = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbldata = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblhora = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Aqua;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.funcionáriosToolStripMenuItem,
            this.forncedoresToolStripMenuItem,
            this.produtosToolStripMenuItem,
            this.vendasToolStripMenuItem,
            this.menu_relatorio});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_cadcliente,
            this.consultarToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // menu_cadcliente
            // 
            this.menu_cadcliente.Name = "menu_cadcliente";
            this.menu_cadcliente.Size = new System.Drawing.Size(180, 22);
            this.menu_cadcliente.Text = "Cadastrar";
            this.menu_cadcliente.Click += new System.EventHandler(this.menu_cadcliente_Click);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consultarToolStripMenuItem.Text = "Consultar";
            // 
            // funcionáriosToolStripMenuItem
            // 
            this.funcionáriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_cadfunc,
            this.consultarToolStripMenuItem1});
            this.funcionáriosToolStripMenuItem.Name = "funcionáriosToolStripMenuItem";
            this.funcionáriosToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.funcionáriosToolStripMenuItem.Text = "Funcionários";
            // 
            // menu_cadfunc
            // 
            this.menu_cadfunc.Name = "menu_cadfunc";
            this.menu_cadfunc.Size = new System.Drawing.Size(125, 22);
            this.menu_cadfunc.Text = "Cadastrar";
            this.menu_cadfunc.Click += new System.EventHandler(this.menu_cadfunc_Click);
            // 
            // consultarToolStripMenuItem1
            // 
            this.consultarToolStripMenuItem1.Name = "consultarToolStripMenuItem1";
            this.consultarToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.consultarToolStripMenuItem1.Text = "Consultar";
            // 
            // forncedoresToolStripMenuItem
            // 
            this.forncedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_cadforn,
            this.consultarToolStripMenuItem4});
            this.forncedoresToolStripMenuItem.Name = "forncedoresToolStripMenuItem";
            this.forncedoresToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.forncedoresToolStripMenuItem.Text = "Fornecedores";
            // 
            // menu_cadforn
            // 
            this.menu_cadforn.Name = "menu_cadforn";
            this.menu_cadforn.Size = new System.Drawing.Size(125, 22);
            this.menu_cadforn.Text = "Cadastrar";
            this.menu_cadforn.Click += new System.EventHandler(this.menu_cadforn_Click);
            // 
            // consultarToolStripMenuItem4
            // 
            this.consultarToolStripMenuItem4.Name = "consultarToolStripMenuItem4";
            this.consultarToolStripMenuItem4.Size = new System.Drawing.Size(125, 22);
            this.consultarToolStripMenuItem4.Text = "Consultar";
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_cadproduto,
            this.consultarToolStripMenuItem2});
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.produtosToolStripMenuItem.Text = "Produtos";
            // 
            // menu_cadproduto
            // 
            this.menu_cadproduto.Name = "menu_cadproduto";
            this.menu_cadproduto.Size = new System.Drawing.Size(125, 22);
            this.menu_cadproduto.Text = "Cadastrar";
            this.menu_cadproduto.Click += new System.EventHandler(this.menu_cadproduto_Click);
            // 
            // consultarToolStripMenuItem2
            // 
            this.consultarToolStripMenuItem2.Name = "consultarToolStripMenuItem2";
            this.consultarToolStripMenuItem2.Size = new System.Drawing.Size(125, 22);
            this.consultarToolStripMenuItem2.Text = "Consultar";
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_cadvenda,
            this.consultarToolStripMenuItem3});
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.vendasToolStripMenuItem.Text = "Vendas";
            // 
            // menu_cadvenda
            // 
            this.menu_cadvenda.Name = "menu_cadvenda";
            this.menu_cadvenda.Size = new System.Drawing.Size(124, 22);
            this.menu_cadvenda.Text = "Cadastrar";
            this.menu_cadvenda.Click += new System.EventHandler(this.menu_cadvenda_Click);
            // 
            // consultarToolStripMenuItem3
            // 
            this.consultarToolStripMenuItem3.Name = "consultarToolStripMenuItem3";
            this.consultarToolStripMenuItem3.Size = new System.Drawing.Size(124, 22);
            this.consultarToolStripMenuItem3.Text = "Histórico";
            this.consultarToolStripMenuItem3.Click += new System.EventHandler(this.consultarToolStripMenuItem3_Click);
            // 
            // menu_relatorio
            // 
            this.menu_relatorio.Name = "menu_relatorio";
            this.menu_relatorio.Size = new System.Drawing.Size(71, 20);
            this.menu_relatorio.Text = "Relátorios";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Aqua;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lbllogado,
            this.toolStripStatusLabel2,
            this.lbldata,
            this.toolStripStatusLabel3,
            this.lblhora});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "Usuario Logado";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(90, 17);
            this.toolStripStatusLabel1.Text = "Usuario logado:";
            // 
            // lbllogado
            // 
            this.lbllogado.Name = "lbllogado";
            this.lbllogado.Size = new System.Drawing.Size(12, 17);
            this.lbllogado.Text = "-";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(60, 17);
            this.toolStripStatusLabel2.Text = "Data (EN):";
            // 
            // lbldata
            // 
            this.lbldata.Name = "lbldata";
            this.lbldata.Size = new System.Drawing.Size(12, 17);
            this.lbldata.Text = "-";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(36, 17);
            this.toolStripStatusLabel3.Text = "Hora:";
            // 
            // lblhora
            // 
            this.lblhora.Name = "lblhora";
            this.lblhora.Size = new System.Drawing.Size(12, 17);
            this.lblhora.Text = "-";
            this.lblhora.Click += new System.EventHandler(this.lblhora_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Frmmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frmmenu";
            this.Text = "Menu Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frmmenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_cadvenda;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem forncedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem4;
        public System.Windows.Forms.ToolStripStatusLabel lbllogado;
        public System.Windows.Forms.ToolStripMenuItem menu_relatorio;
        public System.Windows.Forms.ToolStripMenuItem menu_cadproduto;
        public System.Windows.Forms.ToolStripMenuItem menu_cadcliente;
        public System.Windows.Forms.ToolStripMenuItem menu_cadfunc;
        public System.Windows.Forms.ToolStripMenuItem menu_cadforn;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel lbldata;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel lblhora;
    }
}