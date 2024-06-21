using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Modelos
{
    public class Cliente
    {
        public long id { get; set; }
        public string Nombre { get; set; }
        public long DNI { get; set; }


        public Cliente(string nombre, long dni)
        {
            this.Nombre = nombre;
            this.DNI = dni;
        }


        public Cliente(long id, string nombre, long dni)
        {
            this.id = id;
            this.Nombre = nombre;
            this.DNI = dni;
        }

        public Cliente()
        {

        }

    }
}
