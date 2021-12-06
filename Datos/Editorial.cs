using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySqlConnector;

namespace Datos
{
  public  class Editorial
    {

        public static Entidades.Editorial MostrarEditorial (int id)
        {
            //Creamos entidad Genero
            Entidades.Editorial objEditorial = new Entidades.Editorial();

            //Creamos el obj conexion
            MySqlConnection objconexion = new MySqlConnection(Conexion.ConectorMySql());

            //Guardamos la consulta
            string strSQL = @"select Descripcion from editoriales where IdEditorial = @IdEditorial";

            //creamos el obj de la consulta y la conexion (Puente)
            MySqlCommand objMySqlcommand = new MySqlCommand(strSQL, objconexion);

            //asignamos el parametro de id
            objMySqlcommand.Parameters.AddWithValue("@IdEditorial", id);
            //abrimos conexion
            objconexion.Open();

            //Guardamos la consulta en un obj data reader (Ejecucion de consulta)
            MySqlDataReader dtr = objMySqlcommand.ExecuteReader();

            if (dtr.Read())
            {

                objEditorial.Descripcion = dtr["Descripcion"].ToString();

            }

            //cerramos conexion
            objconexion.Close();



            return objEditorial;
        }

        public static void ModificarEditorial(string descripcion, int id)
        {
            //Creamos el obj conexion
            MySqlConnection objconexion = new MySqlConnection(Conexion.ConectorMySql());

            //Guardamos la consulta en un string
            string sqlString = @"UPDATE editoriales SET Descripcion =@Descripcion where IdEditorial = @IdEditorial"; ;

            //Creamos el obj command para ejecutar la consulta
            MySqlCommand objMySqlcommand = new MySqlCommand(sqlString, objconexion);

            //Pasamos por parametro el valor que vendra del objeto
            objMySqlcommand.Parameters.AddWithValue("@Descripcion", descripcion);
            objMySqlcommand.Parameters.AddWithValue("@IdEditorial", id);

            //Abrimos la conexion
            objconexion.Open();

            //Ejecutamos la sentencia
            objMySqlcommand.ExecuteNonQuery();

            //Cerramos la conexion
            objconexion.Close();
        }

        public static DataTable TraerTodos()
        {
            DataTable dt = new DataTable();

            string strSQL = "Select * from editoriales";
            MySqlDataAdapter objDaTraer = new MySqlDataAdapter(strSQL, Conexion.ConectorMySql());
            objDaTraer.Fill(dt);

            return dt;
           
        }

        public static void Agregar(Entidades.Editorial pEditoriales) // AGREGO GENERO 
        {
            MySqlConnection objConexion = new MySqlConnection(Conexion.ConectorMySql());

            string sqlString = @"INSERT INTO editoriales(IdEditorial , Descripcion)

                               VALUES(@IdEditorial, @Descripcion)";

            MySqlCommand objMySqlCommand = new MySqlCommand(sqlString, objConexion);

            objMySqlCommand.Parameters.AddWithValue("@IdEditorial", pEditoriales.IdEditorial);
            objMySqlCommand.Parameters.AddWithValue("@Descripcion", pEditoriales.Descripcion);

            objConexion.Open();

            objMySqlCommand.ExecuteNonQueryAsync();

            objConexion.Close();
        }


        public static void Modificar(Entidades.Pais pPais)
        {


            MySqlConnection objConexion = new MySqlConnection(Conexion.ConectorMySql()); // crear objeto de conexion


            string strProc = @"UPDATE editoriales SET Descripcion= @Descripcion where IdEditorial = @IdEditorial"; ; // variable con el nombre del SP

            MySqlCommand objComModificar = new MySqlCommand(strProc, objConexion);



            objComModificar.CommandType = CommandType.StoredProcedure;    // le indico que el strProc sea un Stored Procedure


            // parametros

            objComModificar.Parameters.AddWithValue("@IdEditorial", pPais.IdPaises);
            objComModificar.Parameters.AddWithValue("@Descripcion", pPais.Nombre);



            objConexion.Open();// abre la conexion

            objComModificar.ExecuteNonQuery();  // ejecutar commad


            objConexion.Close();     // cierro la conexion

        }

        public static void Borrar(int pID)
        {
           
            MySqlConnection objConexion = new MySqlConnection(Conexion.ConectorMySql());    // crear objeto de conexion

            string strProc  = @"delete from editoriales where IdEditorial = @IdEditorial";


            MySqlCommand objComBorrar = new MySqlCommand(strProc, objConexion);

            objComBorrar.Parameters.AddWithValue("@IdEditorial", pID);

            objConexion.Open();// abre la conexion

            objComBorrar.ExecuteNonQuery(); // ejecutar commad

          
            objConexion.Close();   // cierro la conexion */
                                   // crear objeto de conexion

         
        }


        public static void Borrar(string pID)
        {

            MySqlConnection objConexion = new MySqlConnection(Conexion.ConectorMySql());    // crear objeto de conexion

            string strProc = "@delete from editoriales where Descripcion = @Descripcion";


            MySqlCommand objComBorrar = new MySqlCommand(strProc, objConexion);


            objComBorrar.CommandType = CommandType.StoredProcedure;  // le indico que el strProc sea un Stored Procedure

            objComBorrar.Parameters.AddWithValue("@Descripcion", pID);

            objConexion.Open();// abre la conexion

            objComBorrar.ExecuteNonQuery(); // ejecutar commad


            objConexion.Close();   // cierro la conexion

        }


        public static DataTable BuscarEditorial(string descr)
        {


            DataTable objDt = new DataTable();

            string strProc = @"SELECT IdEditorial, Descripcion from editoriales WHERE Descripcion LIKE '%" + descr + "%'";

            MySqlDataAdapter objGeneroMySql = new MySqlDataAdapter(strProc, Conexion.ConectorMySql());


            objGeneroMySql.Fill(objDt);// abre la conexion

            return objDt;
        }


        public static DataTable BuscarEditorial(int IdEditorial)
        {


            DataTable objDt = new DataTable();

            string strProc = @"SELECT IdEditorial, Descripcion from editoriales WHERE IdEditorial =" + IdEditorial;



            MySqlDataAdapter objGeneroMySql = new MySqlDataAdapter(strProc, Conexion.ConectorMySql());


            objGeneroMySql.Fill(objDt);// abre la conexion

            return objDt;
        }
    }
}
