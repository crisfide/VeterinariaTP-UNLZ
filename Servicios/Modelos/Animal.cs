using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Modelos
{
    public class Animal
    {
        public long id { get; set; }
        public string nombre { get; set; }
        public long edad { get; set; }
        public decimal peso { get; set; }
        public long clienteId { get; set; }
        public long especieId { get; set; }

        public Animal(long id, string nombre, long edad, decimal peso, long clienteId, long especieId)
        {
            this.id = id;
            this.nombre = nombre;
            this.edad = edad;
            this.peso = peso;
            this.clienteId = clienteId;
            this.especieId = especieId;
        }
        public Animal(string nombre, long edad, decimal peso, long clienteId, long especieId)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.peso = peso;
            this.clienteId = clienteId;
            this.especieId = especieId;
        }


        public Animal()
        {

        }
    }
}
