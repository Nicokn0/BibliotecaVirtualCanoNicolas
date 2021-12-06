using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace Logica
{
   public  class Pais
    {
        
        public DataTable TraerTodos(string pFiltro)
        {

            return Datos.Pais.TraerTodos(); // devuelve data TABLEL

        }

        public void Modificar(Entidades.Pais pPais)
        {
            Datos.Pais.Modificar(pPais);

        }

        public void Borrar(int pID)
        {
            Datos.Pais.Borrar(pID);
        }

        public void Agregar(Entidades.Pais objPais) // le paso por parametro desde entidad un obj se trabaja desde la base de datos
        {
            Datos.Pais.Agregar(objPais);
        }

        public Entidades.Pais RetornarPais(int id)
        {

            return Datos.Pais.MostrarPais(id);
        }


        public DataTable BuscarPais(string pFiltro)
        {

            return Datos.Pais.BuscarPais(pFiltro); // devuelve data TABLEL

        }

        public DataTable BuscarPais(int pFiltro)
        {

            return Datos.Pais.BuscarPais(pFiltro); // devuelve data TABLEL

        }
    }
}
