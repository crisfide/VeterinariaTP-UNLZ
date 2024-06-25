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
        public string conexionStr()
        {
            //obtener nombre de PC para conectarse a la db
            string nombrePC = Environment.MachineName;

            return $"server={nombrePC}\\SQLEXPRESS;" +
                $"Database=veterinariaDB;Integrated Security=true;TrustServerCertificate=true";

        }

        public IDbConnection PrepararConexion()
        {
            SqlConnection conexion = new SqlConnection(this.conexionStr());
            conexion.Open();

            return conexion;            
        }
    }
}
