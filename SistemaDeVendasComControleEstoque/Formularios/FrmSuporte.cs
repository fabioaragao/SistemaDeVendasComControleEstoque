using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeVendasComControleEstoque.Formularios
{
    public partial class FrmSuporte : Form
    {
        public FrmSuporte()
        {
            InitializeComponent();
            rtbSuporte.SelectAll();
            rtbSuporte.SelectionAlignment = HorizontalAlignment.Center;
            rtbSuporte.DeselectAll();
        }

        private void rtbSuporte_TextChanged(object sender, EventArgs e)
        {
            // Para centralizar o componente, configurei na subida do form
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
