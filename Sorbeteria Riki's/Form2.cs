using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sorbeteria_Riki_s
{
    public partial class FormularioRegistroDeVentas : Form
    {        
        public FormularioRegistroDeVentas()
        {
            InitializeComponent();
        }

        private void BotónFormulariodeVentas_Click(object sender, EventArgs e)
        {
            FormulariodeCompra formulariodeCompra = new FormulariodeCompra();
            formulariodeCompra.Show();
            this.Hide();
        }
    }
}
