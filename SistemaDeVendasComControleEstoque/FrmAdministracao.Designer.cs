namespace SistemaDeVendasComControleEstoque
{
    partial class FrmAdministracao
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.msFrmAdminSistema = new System.Windows.Forms.MenuStrip();
            this.usuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeUsuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exclusãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirSistemaDeVendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblBarraInferior = new System.Windows.Forms.Label();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msFrmAdminSistema.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // msFrmAdminSistema
            // 
            this.msFrmAdminSistema.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuárioToolStripMenuItem,
            this.vendasToolStripMenuItem,
            this.estoqueToolStripMenuItem,
            this.sistemaToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.msFrmAdminSistema.Location = new System.Drawing.Point(0, 0);
            this.msFrmAdminSistema.Name = "msFrmAdminSistema";
            this.msFrmAdminSistema.Size = new System.Drawing.Size(800, 24);
            this.msFrmAdminSistema.TabIndex = 0;
            this.msFrmAdminSistema.Text = "menuStrip1";
            // 
            // usuárioToolStripMenuItem
            // 
            this.usuárioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeUsuáriosToolStripMenuItem,
            this.editarUsuárioToolStripMenuItem,
            this.exclusãoToolStripMenuItem});
            this.usuárioToolStripMenuItem.Name = "usuárioToolStripMenuItem";
            this.usuárioToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.usuárioToolStripMenuItem.Text = "Usuário";
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirSistemaDeVendasToolStripMenuItem});
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.vendasToolStripMenuItem.Text = "Vendas";
            // 
            // estoqueToolStripMenuItem
            // 
            this.estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            this.estoqueToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.estoqueToolStripMenuItem.Text = "Estoque";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // cadastroDeUsuáriosToolStripMenuItem
            // 
            this.cadastroDeUsuáriosToolStripMenuItem.Name = "cadastroDeUsuáriosToolStripMenuItem";
            this.cadastroDeUsuáriosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cadastroDeUsuáriosToolStripMenuItem.Text = "Cadastro";
            // 
            // editarUsuárioToolStripMenuItem
            // 
            this.editarUsuárioToolStripMenuItem.Name = "editarUsuárioToolStripMenuItem";
            this.editarUsuárioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editarUsuárioToolStripMenuItem.Text = "Alteração";
            // 
            // exclusãoToolStripMenuItem
            // 
            this.exclusãoToolStripMenuItem.Name = "exclusãoToolStripMenuItem";
            this.exclusãoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exclusãoToolStripMenuItem.Text = "Exclusão";
            // 
            // abrirSistemaDeVendasToolStripMenuItem
            // 
            this.abrirSistemaDeVendasToolStripMenuItem.Name = "abrirSistemaDeVendasToolStripMenuItem";
            this.abrirSistemaDeVendasToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.abrirSistemaDeVendasToolStripMenuItem.Text = "Abrir Sistema de Vendas";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.lblBarraInferior);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 422);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 28);
            this.panel1.TabIndex = 1;
            // 
            // lblBarraInferior
            // 
            this.lblBarraInferior.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBarraInferior.AutoSize = true;
            this.lblBarraInferior.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarraInferior.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBarraInferior.Location = new System.Drawing.Point(199, 0);
            this.lblBarraInferior.Name = "lblBarraInferior";
            this.lblBarraInferior.Size = new System.Drawing.Size(395, 20);
            this.lblBarraInferior.TabIndex = 0;
            this.lblBarraInferior.Text = "Desenvolvido por: FSolutions Soluções em Tecnologia.";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // FrmAdministracao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.msFrmAdminSistema);
            this.MainMenuStrip = this.msFrmAdminSistema;
            this.Name = "FrmAdministracao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administração do Sistema:";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.msFrmAdminSistema.ResumeLayout(false);
            this.msFrmAdminSistema.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msFrmAdminSistema;
        private System.Windows.Forms.ToolStripMenuItem usuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeUsuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exclusãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirSistemaDeVendasToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblBarraInferior;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}

