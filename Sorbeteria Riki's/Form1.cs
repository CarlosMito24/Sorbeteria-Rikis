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
        double precio1 = 1.15;
        double precio2 = 1.50;
        double precio3 = 1.35;
        double precio4 = 1.75;

        public FormulariodeCompra()
        {
            InitializeComponent();
        }

        private void BotónRegistroDeVentas_Click(object sender, EventArgs e)
        {
            FormularioRegistroDeVentas formularioRegistroDeVentas = new FormularioRegistroDeVentas();
            formularioRegistroDeVentas.Show();
            this.Hide();
        }

       
        private void FormulariodeCompra_Load(object sender, EventArgs e)
        {

        }

        private void BotónCerrar_Click(object sender, EventArgs e)
        {
            FormularioInicioSesión3 formulariodeInicioSesion = new FormularioInicioSesión3();
            formulariodeInicioSesion.Show();
            this.Hide();
        }

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
        }
    }
}
