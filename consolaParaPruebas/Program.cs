using Servicios.DAO;
using Servicios.Modelos;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consolaParaPruebas
{
    internal class Program
    {
        //aplicacion SOLO utilizada para probar
        //para usar la veterinaria ejecutar el proyecto VeterinariaTP (windows form)
        static void Main(string[] args)
        {
            var daoU = new DAOUsuarios();
            var daoE = new DAOEspecies();
            var daoA = new DAOAnimales();

            //var lista = daoU.GetAll();
            //bool ok = daoU.Insert(new Usuario("user000","000"));
            //bool ok = daoU.Update("zzz","www" ,"1234");
            //bool borrado = daoU.Delete(7);

            //bool ok = daoE.Insert(new Especie("Caballo",10,(decimal)100.0));
            //bool ok = daoA.Insert(new Animal("aaa", 2, (decimal)10.0, 1, 2));

            bool ok=false;
            try
            {
                ok = daoA.Update("aaa", "bbb", 2, (decimal)20.0, 1, 32);
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine(ok);
            Console.ReadKey();
        }
    }
}
