using Servicios.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.DAO
{
    public class DAOClientes : DAO
    {
        public List<Cliente> GetAll()
        {
            IDbConnection conexion = this.PrepararConexion();
            IDbCommand comando = conexion.CreateCommand();
            comando.CommandText = "SELECT * FROM Clientes";

            IDataReader lector = comando.ExecuteReader();
            List<Cliente> lista = new List<Cliente>();

            while (lector.Read())
            {
                lista.Add(new Cliente(lector.GetInt32(0),
                                      lector.GetString(1),
                                      lector.GetInt32(2)
                                      ));
            }

            conexion.Close();
            return lista;
        }


        public bool Insert(Cliente cliente)
        {
            string query = $"INSERT INTO Clientes (nombre, dni) VALUES ('{cliente.nombre}', '{cliente.DNI}');";
            IDbConnection conexion = this.PrepararConexion();
            IDbCommand comando = conexion.CreateCommand();
            comando.CommandText = query;

            int filasAfectadas = comando.ExecuteNonQuery();

            conexion.Close();
            return filasAfectadas > 0;
        }

        public Cliente GetByID(long id)
        {
            Cliente clienteEncontrado = null;

            string query = $"SELECT * FROM Clientes WHERE ID = {id}";
            IDbConnection conexion = this.PrepararConexion();
            IDbCommand comando = conexion.CreateCommand();
            comando.CommandText = query;

            IDataReader lector = comando.ExecuteReader();
            if (lector.Read())
            {
                clienteEncontrado = new Cliente()
                {
                    id = lector.GetInt32(0),
                    nombre = lector.GetString(1),
                    DNI = lector.GetInt32(2),
                };
            }

            conexion.Close();
            return clienteEncontrado;
        }

        public bool Update(long id, string nombre, long dni)
        {
            string query = $"UPDATE Clientes SET NOMBRE = '{nombre}', DNI = '{dni}' WHERE ID = {id}";

            IDbConnection conexion = this.PrepararConexion();
            IDbCommand comando = conexion.CreateCommand();
            comando.CommandText = query;

            int filas = comando.ExecuteNonQuery();

            conexion.Close();
            return filas > 0;

        }

        public bool Update(string nombreViejo, string nombreNuevo, long dni)
        {
            string query = $"UPDATE Clientes SET NOMBRE = '{nombreNuevo}', DNI = '{dni}' WHERE NOMBRE = '{nombreViejo}'";

            IDbConnection conexion = this.PrepararConexion();
            IDbCommand comando = conexion.CreateCommand();
            comando.CommandText = query;

            int filas = comando.ExecuteNonQuery();

            conexion.Close();
            return filas > 0;

        }


        public bool Delete(long id)
        {
            string query = $"DELETE FROM Clientes WHERE ID = {id}";
            IDbConnection conexion = this.PrepararConexion();
            IDbCommand comando = conexion.CreateCommand();
            comando.CommandText = query;

            int filas = comando.ExecuteNonQuery();

            conexion.Close();
            return filas > 0;
        }

        public bool Delete(string nombre)
        {
            string query = $"DELETE FROM Clientes WHERE NOMBRE = '{nombre}'";
            IDbConnection conexion = this.PrepararConexion();
            IDbCommand comando = conexion.CreateCommand();
            comando.CommandText = query;

            int filas = comando.ExecuteNonQuery();

            conexion.Close();
            return filas > 0;
        }
    }
}
