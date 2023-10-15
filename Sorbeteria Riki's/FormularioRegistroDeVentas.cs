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
        private SqlConnection Cnn;

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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (textBoxNombreCliente.Text == string.Empty)
            {
                MessageBox.Show("Ingresa el nombre del cliente");
            }
            else
            {
                //button de buscar 
                string CadenaConexion = @"Data Source=CARLOSMITO; Initial Catalog=Sorbeteria; Integrated Security=True";
                Cnn = new SqlConnection(CadenaConexion);
                Cnn.Open();

                string consulta = "Select * from Ventas where NombreCliente = '" + textBoxNombreCliente.Text + "'";
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, Cnn);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                DataGridViewRegistro.DataSource = dt;
                SqlCommand comando = new SqlCommand(consulta, Cnn);
                SqlDataReader lector;
                lector = comando.ExecuteReader();
                Cnn.Close();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            FormulariodeCompra formulariodeCompra = new FormulariodeCompra();
            formulariodeCompra.Show();
            formulariodeCompra.BotónRegistroDeVentas.Visible = true;
            formulariodeCompra.label12.Visible = true;
            formulariodeCompra.textBox1.Visible = true;
            formulariodeCompra.btnModificar.Visible = true;
            formulariodeCompra.label4.Text = "Modificar registro";
            formulariodeCompra.label3.Text = "Ingresa nuevo nombre cliente";
            formulariodeCompra.BotonEfectuarCompra.Visible = false;
            formulariodeCompra.BotónGrabar.Visible = false;
            formulariodeCompra.BotónLimpiar.Visible = false;
            this.Hide();
        }
    }
}
