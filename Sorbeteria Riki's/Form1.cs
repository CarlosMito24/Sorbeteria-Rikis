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
        double precio1 = 0;
        double precio2 = 0;
        double precio3 = 0;
        double precio4 = 0;

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
            this.Close();
        }

        private void ComboBoxTipos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipodecono = ComboBoxTipos.Text;

            if (tipodecono.Equals("Cono Simple")) precio1 = 1;
            if (tipodecono.Equals("Cono Simple - Doble Bola")) precio2 = 2;
            if (tipodecono.Equals("Cono Chocolate - Simple")) precio3 = 3;
            if (tipodecono.Equals("Cono Chocolate - Doble Bola")) precio4 = 4;
        }

        private void BotonEfectuarCompra_Click(object sender, EventArgs e)
        {
            if (TextBoxNombre.Text == "")
            {
                MessageBox.Show("Ingresa Un Nombre De Cliente");
            }
            else if (TextBoxCantidad.Text == "")
            {
                MessageBox.Show("Ingresa Una Cantidad Para Un Producto");
            }
            else if (ComboBoxTipos.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione Al Menos Un Producto");
            }
            else
            {
                int cantidad = Convert.ToInt32(TextBoxCantidad.Text);
                double total = (cantidad * precio1) + (cantidad * precio2) + (cantidad * precio3) + (cantidad * precio4);
                LabelTotal.Text = "$ " + total;
            }
        }

        private void BotonAgregar_Click(object sender, EventArgs e)
        {
            TextBoxCantidad.Text = string.Empty;
            ComboBoxTipos.Text = string.Empty;
        }

        private void BotónGrabar_Click(object sender, EventArgs e)
        {
            SqlConnection Conexion1 = ComunDB.ObtenerConexion();

            string Insertar = "INSERT INTO Ventas (NombreCliente, Total) VALUES (@NombreCliente, @Total)";
            SqlCommand comando2 = new SqlCommand(Insertar, Conexion1);
            comando2.Parameters.AddWithValue("@NombreCliente", TextBoxNombre.Text);
            comando2.Parameters.AddWithValue("@Total", TextBoxCantidad.Text);
            comando2.ExecuteNonQuery();
            MessageBox.Show("Venta grabada");
            Conexion1.Close();
            TextBoxNombre.Text = "";
        }
    }
}
