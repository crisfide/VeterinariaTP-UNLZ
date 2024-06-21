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
            DAOUsuarios dao = new DAOUsuarios();

            var lista = dao.GetAll();
            //bool ok = dao.Insert(new Usuario("bb","000"));
            bool ok = dao.Update("zzz","www" ,"1234");
            bool borrado = dao.Delete(7);




            Console.ReadKey();
        }
    }
}
