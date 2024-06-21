using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Servicios.Modelos;

namespace Servicios.DAO
{
    public class DAOUsuarios
    {
        private IDbConnection PrepararConexion()
        {
            //obtener nombre de PC para conectarse a la db
            string nombrePC = Environment.MachineName;
            string conexionStr = $"server={nombrePC}\\SQLEXPRESS;" +
                $"Database=veterinariaDB;Integrated Security=true;TrustServerCertificate=true";

            SqlConnection conexion = new SqlConnection(conexionStr);
            conexion.Open();
            return conexion;
        }

        public Usuario verificarUsuario(string nombre, string clave)
        {
            Usuario usuarioEncontrado = null;

            string query = $"SELECT * FROM USUARIOS WHERE NOMBRE='{nombre}' AND CLAVE='{clave}';";

            IDbConnection conexion = this.PrepararConexion();
            IDbCommand comando = conexion.CreateCommand();
            comando.CommandText = query;

            IDataReader lector = comando.ExecuteReader();
            if (lector.Read())
            {
                usuarioEncontrado = new Usuario()
                {
                    id = lector.GetInt32(0),
                    nombre = lector.GetString(1),
                    clave = lector.GetString(2),
                };
            }

            conexion.Close();
            return usuarioEncontrado;
        }

        public List<Usuario> GetAll()
        {
            IDbConnection conexion = this.PrepararConexion();
            IDbCommand comando = conexion.CreateCommand();
            comando.CommandText = "SELECT * FROM Usuarios";

            IDataReader lector = comando.ExecuteReader();
            List<Usuario> lista = new List<Usuario>();

            while (lector.Read())
            {
                lista.Add(new Usuario(lector.GetInt32(0),
                                      lector.GetString(1),
                                      lector.GetString(2)
                                      ));
            }

            conexion.Close();
            return lista;
        }


        public bool Insert(Usuario usuario)
        {
            string query = $"INSERT INTO Usuarios (nombre, clave) VALUES ('{usuario.nombre}', '{usuario.clave}');";
            IDbConnection conexion = this.PrepararConexion();
            IDbCommand comando = conexion.CreateCommand();
            comando.CommandText = query;

            int filasAfectadas = comando.ExecuteNonQuery();

            conexion.Close();
            return filasAfectadas > 0;
        }

        public Usuario GetByID(long id)
        {
            Usuario usuarioEncontrado = null;

            string query = $"SELECT * FROM Usuarios WHERE ID = {id}";
            IDbConnection conexion = this.PrepararConexion();
            IDbCommand comando = conexion.CreateCommand();
            comando.CommandText = query;
            
            IDataReader lector = comando.ExecuteReader();
            if (lector.Read())
            {
                usuarioEncontrado = new Usuario()
                {
                    id = lector.GetInt32(0),
                    nombre = lector.GetString(1),
                    clave = lector.GetString(2),
                };
            }

            conexion.Close();
            return usuarioEncontrado;
        }

        public bool Update(long id, string nombre, string clave)
        {
            string query = $"UPDATE Usuarios SET NOMBRE = '{nombre}', CLAVE = '{clave}' WHERE ID = {id}";

            IDbConnection conexion = this.PrepararConexion();
            IDbCommand comando = conexion.CreateCommand();
            comando.CommandText = query;

            int filas = comando.ExecuteNonQuery();

            conexion.Close();
            return filas > 0;

        }

        public bool Update(string nombreViejo, string nombreNuevo, string clave)
        {
            string query = $"UPDATE Usuarios SET NOMBRE = '{nombreNuevo}', CLAVE = '{clave}' WHERE NOMBRE = '{nombreViejo}'";

            IDbConnection conexion = this.PrepararConexion();
            IDbCommand comando = conexion.CreateCommand();
            comando.CommandText = query;

            int filas = comando.ExecuteNonQuery();

            conexion.Close();
            return filas > 0;

        }


        public bool Delete(long id)
        {
            string query = $"DELETE FROM Usuarios WHERE ID = {id}";
            IDbConnection conexion = this.PrepararConexion();
            IDbCommand comando = conexion.CreateCommand();
            comando.CommandText = query;

            int filas = comando.ExecuteNonQuery();

            conexion.Close();
            return filas > 0;
        }

        public bool Delete(string nombre)
        {
            string query = $"DELETE FROM Usuarios WHERE NOMBRE = '{nombre}'";
            IDbConnection conexion = this.PrepararConexion();
            IDbCommand comando = conexion.CreateCommand();
            comando.CommandText = query;

            int filas = comando.ExecuteNonQuery();

            conexion.Close();
            return filas > 0;
        }

    }
}
