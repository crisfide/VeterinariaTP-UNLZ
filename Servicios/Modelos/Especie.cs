using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Modelos
{
    public class Especie
    {
        public long id { get; set; }
        public string nombre { get; set; }
        public long EdadMadurez { get; set; }
        public decimal PesoPromedio { get; set; }

        public Especie(string nombre, long edadMadurez, decimal pesoPromedio)
        {
            this.nombre = nombre;
            this.EdadMadurez = edadMadurez;
            this.PesoPromedio = pesoPromedio;
        }

        public Especie(long id, string nombre, long edadMadurez, decimal pesoPromedio)
        {
            this.id = id;
            this.nombre = nombre;
            this.EdadMadurez = edadMadurez;
            this.PesoPromedio = pesoPromedio;
        }

        public Especie()
        {

        }
    }
}
