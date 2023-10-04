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

        /// <summary>
        /// Crea una variable que se conecta a la clase venta
        /// </summary>
        Ventas ventas = new Ventas();

        /// <summary>
        /// Se instancia el formulario de ventas 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BotónFormulariodeVentas_Click(object sender, EventArgs e)
        {
            FormulariodeCompra formulariodeCompra = new FormulariodeCompra();
            formulariodeCompra.Show();
            formulariodeCompra.BotónRegistroDeVentas.Visible = true;
            this.Hide();
        }

        /// <summary>
        /// Se instancia el formulario de iniciar sesión - Cierra el formulario actual para iniciar sesión
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BotónCerrar_Click(object sender, EventArgs e)
        {
            FormularioInicioSesión formulariodeInicioSesion = new FormularioInicioSesión();
            formulariodeInicioSesion.Show();
            this.Hide();
        }

        /// <summary>
        /// Se instancia el formulario de registro de ventas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormularioRegistroDeVentas_Load(object sender, EventArgs e)
        {
            DataGridViewRegistro.DataSource = ventas.MostrarVentas();
        }

        /// <summary>
        /// Cierra el formulario actual, y muestra el formulario de menú 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            FormularioDeMenú formularioDeMenú = new FormularioDeMenú();
            formularioDeMenú.Show();
            formularioDeMenú.BotónRegistroDeVentas.Visible = true;
            this.Hide();
        }
    }
}
