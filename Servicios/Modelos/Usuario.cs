using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Modelos
{
    public class Usuario
    {
        public long id { get; set; }
        public string nombre { get; set; }
        public string clave { get; set; }

        public Usuario(string nombre, string clave)
        {
            this.nombre = nombre;
            this.clave = clave;
        }
        public Usuario(long id, string nombre, string clave)
        {
            this.id = id;
            this.nombre = nombre;
            this.clave = clave;
        }
        public Usuario()
        {

        }
    }
}
