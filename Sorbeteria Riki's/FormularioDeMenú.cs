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
    public partial class FormularioDeMenú : Form
    {
        public FormularioDeMenú()
        {
            InitializeComponent();
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
        /// Cierra el formulario actual, y muestra el formulario de Ventas 
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
        /// Cierra el formulario de menú, y abre el formulario de Registro de ventas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BotónRegistroDeVentas_Click(object sender, EventArgs e)
        {
            FormularioRegistroDeVentas formularioRegistroDeVentas = new FormularioRegistroDeVentas();
            formularioRegistroDeVentas.Show();
            formularioRegistroDeVentas.BotónRegistroDeVentas.Visible = true;
            this.Hide();
        }
    }
}
