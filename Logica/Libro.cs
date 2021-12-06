using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Logica
{
   public  class Libro
    {

        public DataTable TraerTodos(string pFiltro)
        {

            return Datos.Libro.TraerTodos(pFiltro); // devuelve data TABLEL

        }

        public void Agregar(Entidades.Libro objLibro) // le paso por parametro desde entidad un obj se trabaja desde la base de datos
        {
            Datos.Libro.Agregar(objLibro);
        }
  
    
    
    }
}
