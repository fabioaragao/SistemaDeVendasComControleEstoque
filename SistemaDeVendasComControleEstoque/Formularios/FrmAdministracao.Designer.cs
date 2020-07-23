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
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeUsuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exclusãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.balcaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarPedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirPedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirSistemaDeVendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inativarProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarFornecedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarFornecedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inativarFornecedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurarConexãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblBarraInferior = new System.Windows.Forms.Label();
            this.novaVendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msFrmAdminSistema.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // msFrmAdminSistema
            // 
            this.msFrmAdminSistema.BackColor = System.Drawing.SystemColors.ControlLight;
            this.msFrmAdminSistema.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioToolStripMenuItem,
            this.balcaoToolStripMenuItem,
            this.vendasToolStripMenuItem,
            this.estoqueToolStripMenuItem,
            this.fornecedorToolStripMenuItem,
            this.sistemaToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.msFrmAdminSistema.Location = new System.Drawing.Point(0, 0);
            this.msFrmAdminSistema.Name = "msFrmAdminSistema";
            this.msFrmAdminSistema.Size = new System.Drawing.Size(854, 24);
            this.msFrmAdminSistema.TabIndex = 0;
            this.msFrmAdminSistema.Text = "menuStrip1";
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeUsuáriosToolStripMenuItem,
            this.editarUsuárioToolStripMenuItem,
            this.exclusãoToolStripMenuItem,
            this.listarToolStripMenuItem});
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.usuarioToolStripMenuItem.Text = "Usuário";
            // 
            // cadastroDeUsuáriosToolStripMenuItem
            // 
            this.cadastroDeUsuáriosToolStripMenuItem.Name = "cadastroDeUsuáriosToolStripMenuItem";
            this.cadastroDeUsuáriosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cadastroDeUsuáriosToolStripMenuItem.Text = "Cadastrar";
            this.cadastroDeUsuáriosToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeUsuáriosToolStripMenuItem_Click);
            // 
            // editarUsuárioToolStripMenuItem
            // 
            this.editarUsuárioToolStripMenuItem.Name = "editarUsuárioToolStripMenuItem";
            this.editarUsuárioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editarUsuárioToolStripMenuItem.Text = "Alterar";
            // 
            // exclusãoToolStripMenuItem
            // 
            this.exclusãoToolStripMenuItem.Name = "exclusãoToolStripMenuItem";
            this.exclusãoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exclusãoToolStripMenuItem.Text = "Inativar";
            // 
            // listarToolStripMenuItem
            // 
            this.listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            this.listarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listarToolStripMenuItem.Text = "Listar ( Relatório )";
            // 
            // balcaoToolStripMenuItem
            // 
            this.balcaoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaVendaToolStripMenuItem,
            this.editarPedidoToolStripMenuItem,
            this.excluirPedidoToolStripMenuItem,
            this.relatórioToolStripMenuItem3});
            this.balcaoToolStripMenuItem.Name = "balcaoToolStripMenuItem";
            this.balcaoToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.balcaoToolStripMenuItem.Text = "Balcão";
            // 
            // editarPedidoToolStripMenuItem
            // 
            this.editarPedidoToolStripMenuItem.Name = "editarPedidoToolStripMenuItem";
            this.editarPedidoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editarPedidoToolStripMenuItem.Text = "Editar Venda";
            // 
            // excluirPedidoToolStripMenuItem
            // 
            this.excluirPedidoToolStripMenuItem.Name = "excluirPedidoToolStripMenuItem";
            this.excluirPedidoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.excluirPedidoToolStripMenuItem.Text = "Excluir Venda";
            // 
            // relatórioToolStripMenuItem3
            // 
            this.relatórioToolStripMenuItem3.Name = "relatórioToolStripMenuItem3";
            this.relatórioToolStripMenuItem3.Size = new System.Drawing.Size(148, 22);
            this.relatórioToolStripMenuItem3.Text = "Relatório";
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirSistemaDeVendasToolStripMenuItem,
            this.relatórioToolStripMenuItem,
            this.alterarToolStripMenuItem,
            this.excluirToolStripMenuItem});
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.vendasToolStripMenuItem.Text = "Caixa";
            // 
            // abrirSistemaDeVendasToolStripMenuItem
            // 
            this.abrirSistemaDeVendasToolStripMenuItem.Name = "abrirSistemaDeVendasToolStripMenuItem";
            this.abrirSistemaDeVendasToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.abrirSistemaDeVendasToolStripMenuItem.Text = "Abrir Sistema de Caixa";
            // 
            // relatórioToolStripMenuItem
            // 
            this.relatórioToolStripMenuItem.Name = "relatórioToolStripMenuItem";
            this.relatórioToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.relatórioToolStripMenuItem.Text = "Relatório";
            // 
            // alterarToolStripMenuItem
            // 
            this.alterarToolStripMenuItem.Name = "alterarToolStripMenuItem";
            this.alterarToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.alterarToolStripMenuItem.Text = "Alterar Registro";
            // 
            // excluirToolStripMenuItem
            // 
            this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            this.excluirToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.excluirToolStripMenuItem.Text = "Excluir Registro";
            // 
            // estoqueToolStripMenuItem
            // 
            this.estoqueToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeProdutosToolStripMenuItem,
            this.editarProdutosToolStripMenuItem,
            this.inativarProdutosToolStripMenuItem,
            this.relatórioToolStripMenuItem1});
            this.estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            this.estoqueToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.estoqueToolStripMenuItem.Text = "Estoque";
            // 
            // cadastroDeProdutosToolStripMenuItem
            // 
            this.cadastroDeProdutosToolStripMenuItem.Name = "cadastroDeProdutosToolStripMenuItem";
            this.cadastroDeProdutosToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.cadastroDeProdutosToolStripMenuItem.Text = "Cadastrar Produtos";
            // 
            // editarProdutosToolStripMenuItem
            // 
            this.editarProdutosToolStripMenuItem.Name = "editarProdutosToolStripMenuItem";
            this.editarProdutosToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.editarProdutosToolStripMenuItem.Text = "Editar Produtos";
            // 
            // inativarProdutosToolStripMenuItem
            // 
            this.inativarProdutosToolStripMenuItem.Name = "inativarProdutosToolStripMenuItem";
            this.inativarProdutosToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.inativarProdutosToolStripMenuItem.Text = "Inativar Produtos";
            // 
            // relatórioToolStripMenuItem1
            // 
            this.relatórioToolStripMenuItem1.Name = "relatórioToolStripMenuItem1";
            this.relatórioToolStripMenuItem1.Size = new System.Drawing.Size(175, 22);
            this.relatórioToolStripMenuItem1.Text = "Relatório";
            // 
            // fornecedorToolStripMenuItem
            // 
            this.fornecedorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarFornecedorToolStripMenuItem,
            this.editarFornecedorToolStripMenuItem,
            this.inativarFornecedorToolStripMenuItem,
            this.relatórioToolStripMenuItem2});
            this.fornecedorToolStripMenuItem.Name = "fornecedorToolStripMenuItem";
            this.fornecedorToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.fornecedorToolStripMenuItem.Text = "Fornecedor";
            // 
            // cadastrarFornecedorToolStripMenuItem
            // 
            this.cadastrarFornecedorToolStripMenuItem.Name = "cadastrarFornecedorToolStripMenuItem";
            this.cadastrarFornecedorToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.cadastrarFornecedorToolStripMenuItem.Text = "Cadastrar Fornecedor";
            // 
            // editarFornecedorToolStripMenuItem
            // 
            this.editarFornecedorToolStripMenuItem.Name = "editarFornecedorToolStripMenuItem";
            this.editarFornecedorToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.editarFornecedorToolStripMenuItem.Text = "Editar Fornecedor";
            // 
            // inativarFornecedorToolStripMenuItem
            // 
            this.inativarFornecedorToolStripMenuItem.Name = "inativarFornecedorToolStripMenuItem";
            this.inativarFornecedorToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.inativarFornecedorToolStripMenuItem.Text = "Inativar Fornecedor";
            // 
            // relatórioToolStripMenuItem2
            // 
            this.relatórioToolStripMenuItem2.Name = "relatórioToolStripMenuItem2";
            this.relatórioToolStripMenuItem2.Size = new System.Drawing.Size(187, 22);
            this.relatórioToolStripMenuItem2.Text = "Relatório";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backupToolStripMenuItem,
            this.suporteToolStripMenuItem,
            this.configurarConexãoToolStripMenuItem});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // backupToolStripMenuItem
            // 
            this.backupToolStripMenuItem.Name = "backupToolStripMenuItem";
            this.backupToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.backupToolStripMenuItem.Text = "Backup";
            // 
            // suporteToolStripMenuItem
            // 
            this.suporteToolStripMenuItem.Name = "suporteToolStripMenuItem";
            this.suporteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.suporteToolStripMenuItem.Text = "Suporte";
            // 
            // configurarConexãoToolStripMenuItem
            // 
            this.configurarConexãoToolStripMenuItem.Name = "configurarConexãoToolStripMenuItem";
            this.configurarConexãoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.configurarConexãoToolStripMenuItem.Text = "Configurar Conexão";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.lblBarraInferior);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 463);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(854, 28);
            this.panel1.TabIndex = 1;
            // 
            // lblBarraInferior
            // 
            this.lblBarraInferior.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBarraInferior.AutoSize = true;
            this.lblBarraInferior.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarraInferior.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBarraInferior.Location = new System.Drawing.Point(226, 4);
            this.lblBarraInferior.Name = "lblBarraInferior";
            this.lblBarraInferior.Size = new System.Drawing.Size(395, 20);
            this.lblBarraInferior.TabIndex = 0;
            this.lblBarraInferior.Text = "Desenvolvido por: FSolutions Soluções em Tecnologia.";
            // 
            // novaVendaToolStripMenuItem
            // 
            this.novaVendaToolStripMenuItem.Name = "novaVendaToolStripMenuItem";
            this.novaVendaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.novaVendaToolStripMenuItem.Text = "Nova Venda";
            // 
            // FrmAdministracao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 491);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.msFrmAdminSistema);
            this.IsMdiContainer = true;
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
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
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
        private System.Windows.Forms.ToolStripMenuItem cadastroDeProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inativarProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarFornecedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarFornecedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inativarFornecedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem relatórioToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem alterarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurarConexãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem balcaoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarPedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirPedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem novaVendaToolStripMenuItem;
    }
}

