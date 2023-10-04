using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Sorbeteria_Riki_s
{
    public class Ventas
    {
        /// <summary>
        /// Procedimiento almacenado para poder mostrar la tabla de ventas en el formulario
        /// </summary>
        Conexion cn = new Conexion();
        public DataTable MostrarVentas()
        {
            SqlDataAdapter da = new SqlDataAdapter("MostrarTabla", cn.LeerCadena());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
