using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Logica
{
    public class Genero
    {
        public DataTable TraerTodos(string pFiltro)
        {

            return Datos.Genero.TraerTodos(); // devuelve data TABLEL

        }


        public Entidades.Genero TraerUno( int pGenero)
        {

            return Datos.Genero.TraerUno(pGenero);


        }

        public Entidades.Genero MostrarGenero(int id)
        {
            return Datos.Genero.MostrarGenero(id);
        }

        public void ModificarGenero(string descripcion, int id)
        {
            Datos.Genero.ModificarGenero(descripcion, id);
        }

        public void BorrarGenero(int id)
        {
            Datos.Genero.Borrar(id);
        }

        public void Agregar(Entidades.Genero objGenero)
        {
            Datos.Genero.Agregar(objGenero);
        }

        public void ConsultarGenero(string descripcion)
        {
            Datos.Genero.BuscarGenero(descripcion);
        }

        public DataTable BuscarGenero(string pFiltro)
        {

            return Datos.Genero.BuscarGenero(pFiltro); // devuelve data TABLEL

        }

        public DataTable BuscarGenero(int pFiltro)
        {

            return Datos.Genero.BuscarGenero(pFiltro); // devuelve data TABLEL

        }

    
    
    }
}

