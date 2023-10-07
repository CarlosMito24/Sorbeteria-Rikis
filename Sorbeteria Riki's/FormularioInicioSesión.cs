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
    public partial class FormularioInicioSesión : Form
    {
        public FormularioInicioSesión()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Declaramos varables 
        /// </summary>
        private SqlConnection Cnn;
        private SqlDataReader Leer;

        /// <summary>
        /// almacena los permisos de los usuarios
        /// </summary>
        public string x = "";
        public string xclave;
        public string usuario;

        /// <summary>
        /// Creamos el metodo o funcion LeerBD, para acceder a la BD
        /// </summary>
        public void LeerBD()
        {
            string CadenaConexion = @"Data Source=DESKTOP-58B3GUL\SQLEXPRESS; Initial Catalog=SorbeteriaX; Integrated Security=True";
            Cnn = new SqlConnection(CadenaConexion);
            Cnn.Open();

            string consulta = "SELECT * FROM Usuarios WHERE usuario LIKE @Usuario";
            SqlCommand comando3 = new SqlCommand(consulta, Cnn);
            comando3.Parameters.AddWithValue("@Usuario", txbU.Text);
            Leer = comando3.ExecuteReader();
        }

        /// <summary>
        /// Leemos la base de datos y obtenemos datos en variables
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
             LeerBD();
              while (Leer.Read())
              {
                  usuario = Convert.ToString(Leer["Usuario"]);
                  xclave = Convert.ToString(Leer["Clave"]);
                  x = Convert.ToString(Leer["Acceso"]);
              }

              //Preguntamos si los datos coinciden 
            if (usuario == txbU.Text && xclave == txbC.Text)
            {

                MessageBox.Show("Ingreso al programa");
                
                //Se crea instancia para mostrar nuevo formulario
                FormulariodeCompra formulariodeCompra = new FormulariodeCompra();
                formulariodeCompra.Show();
                //Se oculta el formulario presente 
                this.Hide();

                //Se evalua si tiene permisos de administrador 
                switch (x)
                {
                    case "1":
                        formulariodeCompra.BotónRegistroDeVentas.Visible = true;
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
            //Se cierra conexion 
            Leer.Close();
            Cnn.Close();
        }

        /// <summary>
        /// Cierra la app completamente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
