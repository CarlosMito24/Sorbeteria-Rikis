using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorbeteria_Riki_s
{
    public class ComunDB
    {
        /// <summary>
        /// Se crea la conexion a la base de datos 
        /// </summary>
        public int resultado;
        const string StringDeConexion = @"Data Source=DESKTOP-58B3GUL\SQLEXPRESS; Initial Catalog=Sorbeteria; Integrated Security=True";
        public static SqlConnection ObtenerConexion()
        {
            SqlConnection _conexion = new SqlConnection(StringDeConexion);
            _conexion.Open();
            return _conexion;
        }

        /// <summary>
        /// Abre la conexion a la base de datos y la cierra y regreasa el resultado
        /// </summary>
        /// <param name="pConsulta"></param>
        /// <returns></returns>
        public static int EjecutarComando (string pConsulta)
        {
           
            SqlConnection _conexion  = ObtenerConexion();
            SqlCommand _comando  = new SqlCommand(pConsulta, _conexion);
            int resultado = _comando.ExecuteNonQuery();
            _conexion.Close();
            return resultado;
        }
       
        public static SqlDataReader EjecutarComandoReader(string pConsulta)
        {
            SqlConnection _conexion = ObtenerConexion();
            SqlCommand _comando = new SqlCommand(pConsulta, _conexion);
            SqlDataReader _reader = _comando.ExecuteReader(CommandBehavior.CloseConnection);
            return _reader;
        }
    }
}
