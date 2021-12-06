using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySqlConnector;

namespace Datos
{
   public class Genero
    {
        public static DataTable TraerTodos()
        {
            DataTable dt = new DataTable();

            string strSQL = "select * from generos";
            MySqlDataAdapter objDaTraer = new MySqlDataAdapter (strSQL, Conexion.ConectorMySql());
            objDaTraer.Fill(dt);

            return dt;
        }
       
        public static Entidades.Genero TraerUno(int pId)
        {
            Entidades.Genero objGenero = new Entidades.Genero();

            MySqlConnection objConexion = new MySqlConnection(Conexion.ConectorMySql());

            string strSQL = "Select * from Generos where IdGenero =" + pId ;

            MySqlCommand objTraerGenero = new MySqlCommand(strSQL, objConexion);

        

            MySqlDataReader bGenero;

           
            bGenero = objTraerGenero.ExecuteReader();

            if (bGenero.Read())
            {
                objGenero.IdGenero = Convert.ToInt32(bGenero["IdGenero"]);
                objGenero.Descripcion = bGenero["Descripcion"].ToString();
            }

            bGenero.Close();

            objConexion.Close();

            return objGenero;

           
        }
        public static void Agregar (Entidades.Genero pGenero) // AGREGO GENERO 
        {
            MySqlConnection objConexion = new MySqlConnection(Conexion.ConectorMySql());

            string sqlString = @"INSERT INTO generos(IdGenero , Descripcion)

                               VALUES(@IdGenero, @Descripcion)";

            MySqlCommand objMySqlCommand = new MySqlCommand(sqlString, objConexion);

            objMySqlCommand.Parameters.AddWithValue("@IdGenero", pGenero.IdGenero);
            objMySqlCommand.Parameters.AddWithValue("@Descripcion", pGenero.Descripcion);

            objConexion.Open();

            objMySqlCommand.ExecuteNonQueryAsync();

            objConexion.Close();
        }

        public static void Modificar(Entidades.Genero pGenero)
        {


            MySqlConnection objConexion = new MySqlConnection(Conexion.ConectorMySql()); // crear objeto de conexion


            string strProc = @"UPDATE generos SET Nombre= @Nombre where IdGenero = @IdGenero";

            MySqlCommand objComModificar = new MySqlCommand(strProc, objConexion);



            objComModificar.CommandType = CommandType.StoredProcedure;    // le indico que el strProc sea un Stored Procedure


            // parametros

            objComModificar.Parameters.AddWithValue("@IdGenero", pGenero.IdGenero);
            objComModificar.Parameters.AddWithValue("@Descripcion", pGenero.Descripcion);



            objConexion.Open();// abre la conexion

            objComModificar.ExecuteNonQuery();  // ejecutar commad


            objConexion.Close();     // cierro la conexion

        }

        public static void Borrar(int pID)
        {

            MySqlConnection objConexion = new MySqlConnection(Conexion.ConectorMySql());    // crear objeto de conexion

            string strProc = @"delete from generos where IdGenero = @IdGenero";


            MySqlCommand objComBorrar = new MySqlCommand(strProc, objConexion);

            objComBorrar.Parameters.AddWithValue("@IdGenero", pID);

            objConexion.Open();// abre la conexion

            objComBorrar.ExecuteNonQuery(); // ejecutar commad

            // cierro la conexion
            objConexion.Close();

        }

        public static Entidades.Genero MostrarGenero(int id)
        {
            //Creamos entidad Genero
            Entidades.Genero objGen = new Entidades.Genero();

            //Creamos el obj conexion
            MySqlConnection objconexion = new MySqlConnection(Conexion.ConectorMySql());

            //Guardamos la consulta
            string strSQL = @"select Descripcion from generos where IdGenero = @IdGenero";

            //creamos el obj de la consulta y la conexion (Puente)
            MySqlCommand objMySqlcommand = new MySqlCommand(strSQL, objconexion);

            //asignamos el parametro de id
            objMySqlcommand.Parameters.AddWithValue("@IdGenero", id);
            //abrimos conexion
            objconexion.Open();

            //Guardamos la consulta en un obj data reader (Ejecucion de consulta)
            MySqlDataReader dtr = objMySqlcommand.ExecuteReader();

            if (dtr.Read())
            {

                objGen.Descripcion = dtr["Descripcion"].ToString();

            }

            //cerramos conexion
            objconexion.Close();



            return objGen;
        }

        public static void ModificarGenero(string descripcion, int id)
        {
            //Creamos el obj conexion
            MySqlConnection objconexion = new MySqlConnection(Conexion.ConectorMySql());

            //Guardamos la consulta en un string
            string sqlString = @"UPDATE generos SET Descripcion = @descripcion where IdGenero = @IdGenero"; 

            //Creamos el obj command para ejecutar la consulta
            MySqlCommand objMySqlcommand = new MySqlCommand(sqlString, objconexion);

            //Pasamos por parametro el valor que vendra del objeto
            objMySqlcommand.Parameters.AddWithValue("@Descripcion", descripcion);
            objMySqlcommand.Parameters.AddWithValue("@IdGenero", id);

            //Abrimos la conexion
            objconexion.Open();

            //Ejecutamos la sentencia
            objMySqlcommand.ExecuteNonQuery();

            //Cerramos la conexion
            objconexion.Close();
        }

        public static DataTable BuscarGenero ( string descr)
        {
           

            DataTable objDt = new DataTable();

            string strProc = @"SELECT IdGenero, Descripcion from generos WHERE Descripcion LIKE '%" +descr+ "%'";

            MySqlDataAdapter objGeneroMySql = new MySqlDataAdapter(strProc, Conexion.ConectorMySql());
            

            objGeneroMySql.Fill(objDt);// abre la conexion

            return objDt;
        }


        public static DataTable BuscarGenero(int IdGenero)
        {
           

            DataTable objDt = new DataTable();

            string strProc = @"SELECT IdGenero, Descripcion from generos WHERE IdGenero =" + IdGenero;

           

            MySqlDataAdapter objGeneroMySql = new MySqlDataAdapter(strProc, Conexion.ConectorMySql());


            objGeneroMySql.Fill(objDt);// abre la conexion

            return objDt;
        }


    }
}

