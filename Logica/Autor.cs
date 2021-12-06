using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Logica
{
    public class Autor
    {
        // Agregar  un autor a una lista de autores 

        // metodos

        public void Agregar(List<Entidades.Autor> pListaAutor, Entidades.Autor pAutor) // lo que va a recibir por paramtetro 
        {
            // Deberia agregar el autor en una colección de autores 
            pListaAutor.Add(pAutor);
        }

        public void Agregar(Entidades.Autor objAutor) // le paso por parametro desde entidad un obj se trabaja desde la base de datos
        {
            Datos.Autor.Agregar(objAutor); 
        }

        // Crear un metodo para traer la  cantidad total de autores  // estan en el cuadernillo
         public int TraerCantidad (List<Entidades.Autor> pListaAutor)
        {
            int intCantidad;

            intCantidad = pListaAutor.Count;

            return intCantidad;
        }

        // Filtrar por pais a los autores /*Recibe una lista por autor  y un filtro  de pais */

        public List <Entidades.Autor> FiltrarPorPais(List<Entidades.Autor> pListaAutor , string pPais)
        {
            // tengo que fitrar los autores por pais que falta pasar por parametro 
            List<Entidades.Autor> listaAutores = new List<Entidades.Autor>();

            foreach (var item in pListaAutor)
            {
                /*if (item.Nacionalidad == pPais)
                {
                    listaAutores.Add(item);
                } */
                // Lo que esta dentro de lo verde es porque lo agregue yo 
            }
            
            return pListaAutor; // Va a devolver una lista 
        }
        
        public Entidades.Autor FiltrarIDAutor (List<Entidades.Autor> listAutores, int pId)
        {
            
            Entidades.Autor AutorId = new Entidades.Autor();


            foreach (Entidades.Autor item in listAutores)
            {
                if (item.IdPropio == pId)
                {
                    AutorId = item;
                }
            }

            return AutorId;
        }
        
        public void Modificar(List<Entidades.Autor> lista, Entidades.Autor obj, int id)
        {
            lista.RemoveAt(id);

            lista.Insert(id, obj);
        }

        public void Borrar(List<Entidades.Autor> lista, int id)
        {

            lista.RemoveAt(id);
        
            
        }

        public DataTable TraerTodos (string p)
        {

           return Datos.Autor.TraerTodos(""); // devuelve data TABLEL
        }


        public Entidades.Autor TraerUno(int pID)
        {
            return Datos.Autor.TraerUno(pID);

        }


           // MODIFICAR Y BORRAR DESDE LA BASE DE DATOS


        public void Modificar(Entidades.Autor pAutor)
        {
            Datos.Autor.Modificar(pAutor);

        }

        public void Borrar(int pID)
        {
            Datos.Autor.Borrar(pID);
        }


        public DataTable BuscarAutor(string pFiltro)
        {

            return Datos.Autor.BuscarAutor(pFiltro); // devuelve data TABLEL

        }

        public DataTable BuscarAutor(int pFiltro)
        {

            return Datos.Autor.BuscarAutor(pFiltro); // devuelve data TABLEL

        }
    }
}
