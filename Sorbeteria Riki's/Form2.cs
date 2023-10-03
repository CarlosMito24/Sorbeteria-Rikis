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
        //Crea una variable que se conecta a la clase venta
        Ventas ventas = new Ventas();

        private void BotónFormulariodeVentas_Click(object sender, EventArgs e)
        {
           //Se instancia el formulario de ventas 
            FormulariodeCompra formulariodeCompra = new FormulariodeCompra();
            formulariodeCompra.Show();
            formulariodeCompra.BotónRegistroDeVentas.Visible = true;
            this.Hide();
        }

        private void BotónCerrar_Click(object sender, EventArgs e)
        {
            //Se instancia el formulario de iniciar sesión
            //Cierra el formulario actual para iniciar sesión
            FormularioInicioSesión3 formulariodeInicioSesion = new FormularioInicioSesión3();
            formulariodeInicioSesion.Show();
            this.Hide();
        }

        private void FormularioRegistroDeVentas_Load(object sender, EventArgs e)
        {
            //Se instancia el formulario de registro de ventas
            DataGridViewRegistro.DataSource = ventas.MostrarVentas();
        }
    }
}
