
namespace Projeto
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.comercialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginParaClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginParaFuncionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.financeiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.históricoDeVendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comercialToolStripMenuItem,
            this.financeiroToolStripMenuItem,
            this.estoqueToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(802, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // comercialToolStripMenuItem
            // 
            this.comercialToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeClientesToolStripMenuItem,
            this.loginParaClientesToolStripMenuItem,
            this.loginParaFuncionáriosToolStripMenuItem});
            this.comercialToolStripMenuItem.ForeColor = System.Drawing.Color.Gray;
            this.comercialToolStripMenuItem.Name = "comercialToolStripMenuItem";
            this.comercialToolStripMenuItem.Size = new System.Drawing.Size(81, 23);
            this.comercialToolStripMenuItem.Text = "Comercial";
            // 
            // cadastroDeClientesToolStripMenuItem
            // 
            this.cadastroDeClientesToolStripMenuItem.Name = "cadastroDeClientesToolStripMenuItem";
            this.cadastroDeClientesToolStripMenuItem.Size = new System.Drawing.Size(233, 24);
            this.cadastroDeClientesToolStripMenuItem.Text = "Cadastro de Clientes";
            this.cadastroDeClientesToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeClientesToolStripMenuItem_Click);
            // 
            // loginParaClientesToolStripMenuItem
            // 
            this.loginParaClientesToolStripMenuItem.Name = "loginParaClientesToolStripMenuItem";
            this.loginParaClientesToolStripMenuItem.Size = new System.Drawing.Size(233, 24);
            this.loginParaClientesToolStripMenuItem.Text = "Login para Clientes";
            this.loginParaClientesToolStripMenuItem.Click += new System.EventHandler(this.loginParaClientesToolStripMenuItem_Click);
            // 
            // loginParaFuncionáriosToolStripMenuItem
            // 
            this.loginParaFuncionáriosToolStripMenuItem.Name = "loginParaFuncionáriosToolStripMenuItem";
            this.loginParaFuncionáriosToolStripMenuItem.Size = new System.Drawing.Size(233, 24);
            this.loginParaFuncionáriosToolStripMenuItem.Text = "Login para Funcionários";
            this.loginParaFuncionáriosToolStripMenuItem.Click += new System.EventHandler(this.loginParaFuncionáriosToolStripMenuItem_Click);
            // 
            // financeiroToolStripMenuItem
            // 
            this.financeiroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.históricoDeVendasToolStripMenuItem});
            this.financeiroToolStripMenuItem.ForeColor = System.Drawing.Color.Gray;
            this.financeiroToolStripMenuItem.Name = "financeiroToolStripMenuItem";
            this.financeiroToolStripMenuItem.Size = new System.Drawing.Size(83, 23);
            this.financeiroToolStripMenuItem.Text = "Financeiro";
            // 
            // históricoDeVendasToolStripMenuItem
            // 
            this.históricoDeVendasToolStripMenuItem.Name = "históricoDeVendasToolStripMenuItem";
            this.históricoDeVendasToolStripMenuItem.Size = new System.Drawing.Size(199, 24);
            this.históricoDeVendasToolStripMenuItem.Text = "Histórico de Vendas";
            // 
            // estoqueToolStripMenuItem
            // 
            this.estoqueToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verProdutosToolStripMenuItem,
            this.cadastrarProdutoToolStripMenuItem});
            this.estoqueToolStripMenuItem.ForeColor = System.Drawing.Color.Gray;
            this.estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            this.estoqueToolStripMenuItem.Size = new System.Drawing.Size(70, 23);
            this.estoqueToolStripMenuItem.Text = "Estoque";
            // 
            // verProdutosToolStripMenuItem
            // 
            this.verProdutosToolStripMenuItem.Name = "verProdutosToolStripMenuItem";
            this.verProdutosToolStripMenuItem.Size = new System.Drawing.Size(195, 24);
            this.verProdutosToolStripMenuItem.Text = "Visualizar Produtos";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.ForeColor = System.Drawing.Color.Gray;
            this.sairToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sairToolStripMenuItem.Image")));
            this.sairToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(59, 23);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // cadastrarProdutoToolStripMenuItem
            // 
            this.cadastrarProdutoToolStripMenuItem.Name = "cadastrarProdutoToolStripMenuItem";
            this.cadastrarProdutoToolStripMenuItem.Size = new System.Drawing.Size(195, 24);
            this.cadastrarProdutoToolStripMenuItem.Text = "Cadastrar Produto";
            this.cadastrarProdutoToolStripMenuItem.Click += new System.EventHandler(this.cadastrarProdutoToolStripMenuItem_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(802, 500);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "+Esportes";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem comercialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem financeiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginParaClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginParaFuncionáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem históricoDeVendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarProdutoToolStripMenuItem;
    }
}