using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySqlConnector;

namespace Datos
{
    public class Libro
    {

        public static DataTable TraerTodos(string pFiltro) // filtro de autores ej nombre con n
        {
            DataTable dt = new DataTable();

            string strSQL = "Select * from libros"; // trabajo con str y mysql 

            MySqlDataAdapter objtDataAdapterTraer = new MySqlDataAdapter(strSQL, Conexion.ConectorMySql());  //adaptador de mysql y que comando ejecutar 

            objtDataAdapterTraer.Fill(dt); // llena dentro del obj datatable todos los datos que devuela la consulta

            return dt;
        }

        public static void Agregar(Entidades.Libro objLibro) // ya estoy en la clase autor por eso no agrego se supone que ya se sabe 
        {
        

            MySqlConnection objConexion = new MySqlConnection(Conexion.ConectorMySql());

          
            string sqlString = @"INSERT INTO libros (ISBN, Titulo, Edicion , IdGenero, IdEditorial)

                               VALUES(@isbn, @Titulo, @Edicion, @IdGenero , @IgEditorial)"; // instruccion de arriba debo respetar el orden

            // CREAMOS EL OBJ QUE PERMITIRA EJECUTAR LA CONSULTA 

            MySqlCommand objMySqlCommand = new MySqlCommand(sqlString, objConexion); //vamos a utilizar un constructir . Vamos a pasar el string de la consulta y la conexion de la consulta

            // agregamos los paramtetros  necesarios  para comand

            objMySqlCommand.Parameters.AddWithValue("@isbn", objLibro.isbn);
            objMySqlCommand.Parameters.AddWithValue("@Titulo", objLibro.Titulo);
            objMySqlCommand.Parameters.AddWithValue("@Edicion", objLibro.Edicion);
            objMySqlCommand.Parameters.AddWithValue("@IdGenero", objLibro.IdGenero);

            // VAMOS ABRIR LA CONEXION con la base de datos

            objConexion.Open();

            objMySqlCommand.ExecuteNonQuery(); // ejecuta la consulta  con los parametros ya pasados y remplazados por lo qye viene del obj y no espero que devuelva nada solo ejecuta la consulta 

            // devuelve 1 o 0 si el insert to tiene otra agregación puede dar otro numero 

            objConexion.Close();// cerrar la conexión

        }
    }
}
