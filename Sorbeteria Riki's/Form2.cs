using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Sorbeteria_Riki_s
{
    public partial class FormularioRegistroDeVentas : Form
    {        
        public FormularioRegistroDeVentas()
        {
            InitializeComponent();
        }

        Ventas ventas = new Ventas();

        private void BotónFormulariodeVentas_Click(object sender, EventArgs e)
        {
            FormulariodeCompra formulariodeCompra = new FormulariodeCompra();
            formulariodeCompra.Show();
            this.Hide();
        }

        private void BotónCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormularioRegistroDeVentas_Load(object sender, EventArgs e)
        {
            DataGridViewRegistro.DataSource = ventas.MostrarVentas();
        }
    }
}
