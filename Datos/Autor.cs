using MySqlConnector;
using System;
using System.Data; // Para usar el data table, es una tabla de tablos. un conjunto de registros 




namespace Datos
{
    public static class Autor
    {

        public static DataTable TraerTodos(string pFiltro) // filtro de autores ej nombre con n
        {
            DataTable dt = new DataTable();

            string strSQL = "Select * from profesores"; // trabajo con str y mysql 

            MySqlDataAdapter objtDataAdapterTraer = new MySqlDataAdapter(strSQL, Conexion.ConectorMySql());  //adaptador de mysql y que comando ejecutar 

            objtDataAdapterTraer.Fill(dt); // llena dentro del obj datatable todos los datos que devuela la consulta

            return dt;
        }

        public static void Agregar(Entidades.Autor objAutor) // ya estoy en la clase autor por eso no agrego se supone que ya se sabe 
        {
            // SQL CONNECTION .vamos agregar un autor
            // necesitamos un conecctor string 
            // vamos a neecesitar un obj comand que ejecuta una accion en la base de datos INSTRUCCION  INSERT // UPDTAE // DELETE
            // Eventualmente si nuestro comando requiere parametros agregarselos al comando para que los considere al momento de ejecutar


            MySqlConnection objConexion = new MySqlConnection(Conexion.ConectorMySql());

            /*
             INSERT INTO autores (Apellido, Nombre,FechaNacimiento , Nacionalidad)

                VALUES ('Pires', 'Roberto',21-10-1899,1 ) 
             
             */
            // Sentencia sql que voy  a ejecutar 
            string sqlString = @"INSERT INTO autores(Apellido, Nombre, FechaNacimiento , Nacionalidad)

                               VALUES(@apellido, @nombre, @FechaNacimiento, @Nacionalidad)"; // instruccion de arriba debo respetar el orden

            // CREAMOS EL OBJ QUE PERMITIRA EJECUTAR LA CONSULTA 

            MySqlCommand objMySqlCommand = new MySqlCommand(sqlString, objConexion); //vamos a utilizar un constructir . Vamos a pasar el string de la consulta y la conexion de la consulta

            // agregamos los paramtetros  necesarios  para comand

            objMySqlCommand.Parameters.AddWithValue("@apellido", objAutor.Apellido);
            objMySqlCommand.Parameters.AddWithValue("@nombre", objAutor.Nombre);
            objMySqlCommand.Parameters.AddWithValue("@Fechanacimiento", objAutor.FechaNacimiento);
            objMySqlCommand.Parameters.AddWithValue("@Nacionalidad", objAutor.Nacionalidad);

            // VAMOS ABRIR LA CONEXION con la base de datos

            objConexion.Open();

            objMySqlCommand.ExecuteNonQuery(); // ejecuta la consulta  con los parametros ya pasados y remplazados por lo qye viene del obj y no espero que devuelva nada solo ejecuta la consulta 

            // devuelve 1 o 0 si el insert to tiene otra agregación puede dar otro numero 

            objConexion.Close();// cerrar la conexión

        }


        public static Entidades.Autor TraerUno(int pID)
        {
            Entidades.Autor objAutor = new Entidades.Autor();

            MySqlConnection objConexion = new MySqlConnection(Conexion.ConectorMySql());

            string strMySQL = "Select * from autores where IdAutor =" + pID;

            MySqlCommand objTraerAutor = new MySqlCommand(strMySQL, objConexion);

            objTraerAutor.Parameters.AddWithValue("@IdAutor", pID);

            MySqlDataReader bAutor;

            objConexion.Open();

            bAutor = objTraerAutor.ExecuteReader();

            if (bAutor.Read())
            {
                // objAutor.IdPropio = Convert.ToInt32(drAutor["ID"]);

                objAutor.Apellido = bAutor["Apellido"].ToString();
                objAutor.Nombre = bAutor["Nombre"].ToString();
                objAutor.Nacionalidad = int.Parse(bAutor["Nacionalidad"].ToString());
                objAutor.FechaNacimiento = Convert.ToDateTime(bAutor["FechaNacimiento"]);
                   
                //objAutor.FechaNacimiento = DateTime.Parse(dtr["FechaNacimiento"].ToString());

            }

            bAutor.Close();

            objConexion.Close();

            return objAutor;


        }

        public static void Modificar(Entidades.Autor pAutor)
        {
            

            MySqlConnection objConexion = new MySqlConnection(Conexion.ConectorMySql()); // crear objeto de conexion

            
            string strProc = @"UPDATE autores SET Nombre= @nombre, Apellido= @apellido, FechaNacimiento= @fechanacimiento, Nacionalidad= @nacionalidad where IdAutor = @IdAutor";

            MySqlCommand objComModificar = new MySqlCommand(strProc, objConexion); 
          
          
         
            objComModificar.CommandType = CommandType.StoredProcedure;    // le indico que el strProc sea un Stored Procedure
            
            
            // parametros

            objComModificar.Parameters.AddWithValue("@IdAutor", pAutor.IdPropio);
            objComModificar.Parameters.AddWithValue("@Apellido", pAutor.Apellido);
            objComModificar.Parameters.AddWithValue("@Nombre", pAutor.Nombre);
            objComModificar.Parameters.AddWithValue("@FechaNacimiento", pAutor.FechaNacimiento);
            objComModificar.Parameters.AddWithValue("@Nacionalidad", pAutor.Nacionalidad.ToString());


            objConexion.Open();// abre la conexion
                              
            objComModificar.ExecuteNonQuery();  // ejecutar commad

        
            objConexion.Close();     // cierro la conexion

        }

        public static void Borrar(int pID)
        {
            // crear objeto de conexion
           
            MySqlConnection objConexion = new MySqlConnection(Conexion.ConectorMySql());

            // variable con el nombre del SP
            string strProc = "@delete from autores where IdAutor = @IdAutor";

            // crear objeto de la clase SQlCommand
            MySqlCommand objComBorrar = new MySqlCommand(strProc, objConexion);
            
            // le indico que el strProc sea un Stored Procedure
            objComBorrar.CommandType = CommandType.StoredProcedure;
            
            // parametros
            objComBorrar.Parameters.AddWithValue("@IdAutor", pID);

            objConexion.Open();// abre la conexion
                               
            objComBorrar.ExecuteNonQuery(); // ejecutar commad

            // cierro la conexion
            objConexion.Close();

        }


        public static DataTable BuscarAutor(string descr)
        {


            DataTable objDt = new DataTable();

            string strProc = @"SELECT IdAutor, Descripcion from autores WHERE Descripcion LIKE '%" + descr + "%'";

            MySqlDataAdapter objGeneroMySql = new MySqlDataAdapter(strProc, Conexion.ConectorMySql());


            objGeneroMySql.Fill(objDt);// abre la conexion

            return objDt;
        }


        public static DataTable BuscarAutor(int IdAutor)
        {


            DataTable objDt = new DataTable();

            string strProc = @"SELECT IdAutor, Apellido , Nombre, FechaNacimiento, Nacionalidad
            
            from Autores WHERE IdAutor =" + IdAutor;



            MySqlDataAdapter objGeneroMySql = new MySqlDataAdapter(strProc, Conexion.ConectorMySql());


            objGeneroMySql.Fill(objDt);// abre la conexion

            return objDt;
        }


    }



}
