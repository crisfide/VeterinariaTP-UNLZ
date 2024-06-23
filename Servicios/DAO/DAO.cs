using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.DAO
{
    public abstract class DAO
    {
        public IDbConnection PrepararConexion()
        {
            //obtener nombre de PC para conectarse a la db
            string nombrePC = Environment.MachineName;

            string conexionStr = $"server={nombrePC}\\SQLEXPRESS;" +
                $"Database=veterinariaDB;Integrated Security=true;TrustServerCertificate=true";

            SqlConnection conexion = new SqlConnection(conexionStr);
            conexion.Open();

            return conexion;            
        }
    }
}
