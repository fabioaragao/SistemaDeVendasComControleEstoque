using SistemaDeVendasComControleEstoque.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeVendasComControleEstoque
{
    public partial class FrmAdministracao : Form
    {
        public FrmAdministracao()
        {
            InitializeComponent();
        }

        private void cadastroDeUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroUsuario frmcadastrousuarios = new FrmCadastroUsuario();
            {
                frmcadastrousuarios.MdiParent = this;
                frmcadastrousuarios.Show();
            }
        }
    }
}
