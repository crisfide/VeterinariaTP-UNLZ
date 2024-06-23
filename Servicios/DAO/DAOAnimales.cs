using Servicios.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.DAO
{
    public class DAOAnimales : DAO
    {
        public List<Animal> GetAll()
        {
            IDbConnection conexion = this.PrepararConexion();
            IDbCommand comando = conexion.CreateCommand();
            comando.CommandText = "SELECT * FROM Animales";

            IDataReader lector = comando.ExecuteReader();
            List<Animal> lista = new List<Animal>();

            while (lector.Read())
            {
                lista.Add(new Animal(lector.GetInt32(0),
                                      lector.GetString(1),
                                      lector.GetInt32(2),
                                      lector.GetDecimal(3),
                                      lector.GetInt32(4),
                                      lector.GetInt32(5)
                                      ));
            }

            conexion.Close();
            return lista;
        }


        public bool Insert(Animal animal)
        {
            string query = $"INSERT INTO Animales " +
                $"(nombre, EDAD, PESO, CLIENTE_ID, ESPECIE_ID) VALUES " +
                $"('{animal.nombre}', '{animal.edad}', '{animal.peso}', '{animal.clienteId}', '{animal.especieId}' );";
            IDbConnection conexion = this.PrepararConexion();
            IDbCommand comando = conexion.CreateCommand();
            comando.CommandText = query;

            int filasAfectadas = comando.ExecuteNonQuery();

            conexion.Close();
            return filasAfectadas > 0;
        }

        public Animal GetByID(long id)
        {
            Animal animalEncontrado = null;

            string query = $"SELECT * FROM Animales WHERE ID = {id}";
            IDbConnection conexion = this.PrepararConexion();
            IDbCommand comando = conexion.CreateCommand();
            comando.CommandText = query;

            IDataReader lector = comando.ExecuteReader();
            if (lector.Read())
            {
                animalEncontrado = new Animal()
                {
                    id = lector.GetInt32(0),
                    nombre = lector.GetString(1),
                    edad= lector.GetInt32(2),
                    peso= lector.GetDecimal(3),
                    clienteId = lector.GetInt32(4),
                    especieId = lector.GetInt32(5),
                };
            }

            conexion.Close();
            return animalEncontrado;
        }

        public bool Update(long id, string nombre, long edad, decimal peso, long clienteID, long especieID)
        {
            string query = $"UPDATE Animales SET NOMBRE = '{nombre}', EDAD= '{edad}', PESO= '{peso}', CLIENTE_ID= '{clienteID}', ESPECIE_ID= '{especieID}' WHERE ID = {especieID}";

            IDbConnection conexion = this.PrepararConexion();
            IDbCommand comando = conexion.CreateCommand();
            comando.CommandText = query;

            int filas = comando.ExecuteNonQuery();

            conexion.Close();
            return filas > 0;

        }

        public bool Update(string nombreViejo, string nombreNuevo, long edad, decimal peso, long clienteID, long especieID)
        {
            string query = $"UPDATE Animales SET NOMBRE = '{nombreNuevo}', EDAD= '{edad}', PESO= '{peso}', CLIENTE_ID= '{clienteID}', ESPECIE_ID= '{especieID}' WHERE NOMBRE = '{nombreViejo}'";

            IDbConnection conexion = this.PrepararConexion();
            IDbCommand comando = conexion.CreateCommand();
            comando.CommandText = query;

            int filas = comando.ExecuteNonQuery();

            conexion.Close();
            return filas > 0;

        }


        public bool Delete(long id)
        {
            string query = $"DELETE FROM Animales WHERE ID = {id}";
            IDbConnection conexion = this.PrepararConexion();
            IDbCommand comando = conexion.CreateCommand();
            comando.CommandText = query;

            int filas = comando.ExecuteNonQuery();

            conexion.Close();
            return filas > 0;
        }

        public bool Delete(string nombre)
        {
            string query = $"DELETE FROM Animales WHERE NOMBRE = '{nombre}'";
            IDbConnection conexion = this.PrepararConexion();
            IDbCommand comando = conexion.CreateCommand();
            comando.CommandText = query;

            int filas = comando.ExecuteNonQuery();

            conexion.Close();
            return filas > 0;
        }
    }
}
