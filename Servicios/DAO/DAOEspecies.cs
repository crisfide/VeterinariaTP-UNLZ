using Servicios.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.DAO
{
    public class DAOEspecies : DAO
    {
        public List<Especie> GetAll()
        {
            IDbConnection conexion = this.PrepararConexion();
            IDbCommand comando = conexion.CreateCommand();
            comando.CommandText = "SELECT * FROM Especies";

            IDataReader lector = comando.ExecuteReader();
            List<Especie> lista = new List<Especie>();

            while (lector.Read())
            {
                lista.Add(new Especie(lector.GetInt32(0),
                                      lector.GetString(1),
                                      lector.GetInt32(2),
                                      lector.GetDecimal(3)
                                      ));
            }

            conexion.Close();
            return lista;
        }


        public bool Insert(Especie especie)
        {
            string query = $"INSERT INTO Especies " +
                $"(nombre, EDAD_MADUREZ, PESO_PROMEDIO) VALUES " +
                $"('{especie.nombre}', '{especie.EdadMadurez}', '{especie.PesoPromedio}' );";
            IDbConnection conexion = this.PrepararConexion();
            IDbCommand comando = conexion.CreateCommand();
            comando.CommandText = query;

            int filasAfectadas = comando.ExecuteNonQuery();

            conexion.Close();
            return filasAfectadas > 0;
        }

        public Especie GetByID(long id)
        {
            Especie especieEncontrada = null;

            string query = $"SELECT * FROM Especies WHERE ID = {id}";
            IDbConnection conexion = this.PrepararConexion();
            IDbCommand comando = conexion.CreateCommand();
            comando.CommandText = query;

            IDataReader lector = comando.ExecuteReader();
            if (lector.Read())
            {
                especieEncontrada = new Especie()
                {
                    id = lector.GetInt32(0),
                    nombre = lector.GetString(1),
                    EdadMadurez = lector.GetInt32(2),
                    PesoPromedio = lector.GetDecimal(3)
                };
            }

            conexion.Close();
            return especieEncontrada;
        }

        public bool Update(long id, string nombre, long edadMadurez, decimal pesoPromedio)
        {
            string query = $"UPDATE Especies SET NOMBRE = '{nombre}', EDAD_MADUREZ = '{edadMadurez}', PESO_PROMEDIO = '{pesoPromedio}' WHERE ID = {id}";

            IDbConnection conexion = this.PrepararConexion();
            IDbCommand comando = conexion.CreateCommand();
            comando.CommandText = query;

            int filas = comando.ExecuteNonQuery();

            conexion.Close();
            return filas > 0;

        }

        public bool Update(string nombreViejo, string nombreNuevo, long edadMadurez, decimal pesoPromedio)
        {
            string query = $"UPDATE Especies SET NOMBRE = '{nombreNuevo}', EDAD_MADUREZ = '{edadMadurez}', PESO_PROMEDIO = '{pesoPromedio}' WHERE NOMBRE = '{nombreViejo}'";

            IDbConnection conexion = this.PrepararConexion();
            IDbCommand comando = conexion.CreateCommand();
            comando.CommandText = query;

            int filas = comando.ExecuteNonQuery();

            conexion.Close();
            return filas > 0;

        }


        public bool Delete(long id)
        {
            string query = $"DELETE FROM Especies WHERE ID = {id}";
            IDbConnection conexion = this.PrepararConexion();
            IDbCommand comando = conexion.CreateCommand();
            comando.CommandText = query;

            int filas = comando.ExecuteNonQuery();

            conexion.Close();
            return filas > 0;
        }

        public bool Delete(string nombre)
        {
            string query = $"DELETE FROM Especies WHERE NOMBRE = '{nombre}'";
            IDbConnection conexion = this.PrepararConexion();
            IDbCommand comando = conexion.CreateCommand();
            comando.CommandText = query;

            int filas = comando.ExecuteNonQuery();

            conexion.Close();
            return filas > 0;
        }
    }
}
