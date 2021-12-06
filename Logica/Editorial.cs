using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Logica
{
    public class Editorial
    {

        public DataTable TraerTodos(string pFiltro)
        {

            return Datos.Editorial.TraerTodos(); // devuelve data TABLEL
        }

        public Entidades.Editorial RetornarEditorial(int id)
        {

            return Datos.Editorial.MostrarEditorial(id);
        }

        public void ModificarEditorial(string editorial, int id)
        {
            Datos.Editorial.ModificarEditorial(editorial, id);
        }

        public void BorrarEditorial(int id)
        {
            Datos.Editorial.Borrar(id);
        }
        public void BorrarEditorial(string id)
        {
            Datos.Editorial.Borrar(id);
        }

        public void Agregar(Entidades.Editorial objeditorial)
        {
            Datos.Editorial.Agregar(objeditorial);
        }

        public DataTable BuscarEditorial(string pFiltro)
        {

            return Datos.Editorial.BuscarEditorial(pFiltro); // devuelve data TABLEL

        }

        public DataTable BuscarEditorial(int pFiltro)
        {

            return Datos.Editorial.BuscarEditorial(pFiltro); // devuelve data TABLEL

        }

    }
}
