using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sorbeteria_Riki_s
{
    public partial class FormulariodeCompra : Form
    {
        /// <summary>
        /// Se declaran las variables 
        /// </summary>
        double precio1 = 1.15;
        double precio2 = 1.50;
        double precio3 = 1.35;
        double precio4 = 1.75;

        public FormulariodeCompra()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Se instancia el formulario de registro de ventas - Se muestra y se cierra el formulario actual 
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

        private void FormulariodeCompra_Load(object sender, EventArgs e)
        {

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
        /// Se evalua el campo nombre si es nulo - Realiza el procedimiento
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BotonEfectuarCompra_Click(object sender, EventArgs e)
        {
            double cantidad1 = Convert.ToDouble(numericUpDown1.Text);
            double cantidad2 = Convert.ToDouble(numericUpDown2.Text);
            double cantidad3 = Convert.ToDouble(numericUpDown3.Text);
            double cantidad4 = Convert.ToDouble(numericUpDown4.Text);

            if (TextBoxNombre.Text == string.Empty)
            {
                MessageBox.Show("Ingresa Un Nombre De Cliente");
            }
            else
            {
                double cantidadconosimple = cantidad1 * precio1;
                double cantidadconodoble = cantidad2 * precio2;
                double cantidadchocolate = cantidad3 * precio3;
                double cantidadchocolatedoble = cantidad4 * precio4;
                double total = (cantidadconosimple) + (cantidadconodoble) + (cantidadchocolate) + (cantidadchocolatedoble) ;
                LabelTotal.Text = "$ " + total;
            }
        }

        /// <summary>
        /// Se conecta a la base de datos para enviar los siguientes datos en los campos de la tabla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BotónGrabar_Click(object sender, EventArgs e)
        {
           
            SqlConnection Conexion1 = ComunDB.ObtenerConexion();

            string Insertar = "INSERT INTO Ventas (NombreCliente, " +
                            "CantidadConoSimple, PrecioProducto1, " +
                            "CantidadConoSimpleBolaDoble, PrecioProducto2, " +
                            "CantidadConoChocolateSimple, PrecioProducto3, " +
                            "CantidadConoChocolateBolaDoble, PrecioProducto4, " +
                            "Total) " +
                            "VALUES (@NombreCliente, " +
                            "@CantidadConoSimple, @PrecioProducto1, " +
                            "@CantidadConoSimpleBolaDoble, @PrecioProducto2, " +
                            "@CantidadConoChocolateSimple, @PrecioProducto3, " +
                            "@CantidadConoChocolateBolaDoble, @PrecioProducto4, " +
                            "@Total)";

            SqlCommand comando2 = new SqlCommand(Insertar, Conexion1);
            comando2.Parameters.AddWithValue("@NombreCliente", TextBoxNombre.Text);

            comando2.Parameters.AddWithValue("@CantidadConoSimple", numericUpDown1.Text);
            comando2.Parameters.AddWithValue("@PrecioProducto1", precio1);

            comando2.Parameters.AddWithValue("@CantidadConoSimpleBolaDoble", numericUpDown2.Text);
            comando2.Parameters.AddWithValue("@PrecioProducto2", precio2);

            comando2.Parameters.AddWithValue("@CantidadConoChocolateSimple", numericUpDown3.Text);
            comando2.Parameters.AddWithValue("@PrecioProducto3", precio3);

            comando2.Parameters.AddWithValue("@CantidadConoChocolateBolaDoble", numericUpDown4.Text);
            comando2.Parameters.AddWithValue("@PrecioProducto4", precio4);

            comando2.Parameters.AddWithValue("@Total", LabelTotal.Text);
            comando2.ExecuteNonQuery();
            MessageBox.Show("Venta grabada");
            Conexion1.Close();
            TextBoxNombre.Text = "";
            numericUpDown1.Text = "0";
            numericUpDown2.Text = "0";
            numericUpDown3.Text = "0";
            numericUpDown4.Text = "0";
        }

        /// <summary>
        /// Limpia todos los cuadros de texto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BotónLimpiar_Click(object sender, EventArgs e)
        {
            TextBoxNombre.Text = "";
            numericUpDown1.Text = "0";
            numericUpDown2.Text = "0";
            numericUpDown3.Text = "0";
            numericUpDown4.Text = "0";
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
