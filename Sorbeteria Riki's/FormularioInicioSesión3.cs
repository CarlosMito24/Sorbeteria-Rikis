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
    public partial class FormularioInicioSesión3 : Form
    {
        public FormularioInicioSesión3()
        {
            InitializeComponent();
        }

        //Declaramos varables 

        private SqlConnection Cnn;
        private SqlDataReader Leer;

        public string x = ""; // almacena los permisos de los usuarios
        public string xclave;
        public string usuario;

        //Creamos el metodo o funcion LeerBD, para acceder a la BD
        public void LeerBD()
        {
            string CadenaConexion = @"Data Source=CARLOSMITO; Initial Catalog=Sorbeteria; Integrated Security=True";
            Cnn = new SqlConnection(CadenaConexion);
            Cnn.Open();

            string consulta = "SELECT * FROM Usuarios WHERE usuario LIKE @usu";
            SqlCommand comando3 = new SqlCommand(consulta, Cnn);
            comando3.Parameters.AddWithValue("@usu", txbU.Text);
            Leer = comando3.ExecuteReader();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            LeerBD();
            while (Leer.Read())
            {
                usuario = Convert.ToString(Leer["Usuario"]);
                xclave = Convert.ToString(Leer["Clave"]);
                x = Convert.ToString(Leer["Permiso"]);
            }

            if (usuario == txbU.Text && xclave == txbC.Text)
            {
                MessageBox.Show("Ingreso al programa");

                FormulariodeCompra formulariodeCompra = new FormulariodeCompra();
                formulariodeCompra.Show();
                this.Hide();

                switch (x)
                {
                    case "1":
                        break;
                    case "0":

                        break;
                }
            }
            else
            {
                MessageBox.Show("Intente Nuevamente");
                txbU.Text = string.Empty;
                txbC.Text = string.Empty;
            }
            Leer.Close();
            Cnn.Close();
        }
    }
}
