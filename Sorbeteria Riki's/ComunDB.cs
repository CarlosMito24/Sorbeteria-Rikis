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
        public int resultado;
        const string StringDeConexion = @"Data Source=CARLOSMITO; Initial Catalog=Sorbeteria; Integrated Security=True";
        public static SqlConnection ObtenerConexion()
        {
            SqlConnection _conexion = new SqlConnection(StringDeConexion);
            _conexion.Open();
            return _conexion;
        }

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
