using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySqlConnector;

namespace Datos
{
  public  class Pais
    {

        public static DataTable TraerTodos()
        {
            DataTable dt = new DataTable();

            string strSQL = "select * from paises";
            MySqlDataAdapter objDaTraer = new MySqlDataAdapter(strSQL, Conexion.ConectorMySql());
            objDaTraer.Fill(dt);

            return dt;

           
        }

        public static void Agregar(Entidades.Pais pPais) // AGREGO GENERO 
        {
            MySqlConnection objConexion = new MySqlConnection(Conexion.ConectorMySql());

            string sqlString = @"INSERT INTO paises(IdPaises , Nombre)

                               VALUES(@IdPaises, @Nombre)";

            MySqlCommand objMySqlCommand = new MySqlCommand(sqlString, objConexion);

            objMySqlCommand.Parameters.AddWithValue("@IdPaises", pPais.IdPaises);
            objMySqlCommand.Parameters.AddWithValue("@Nombre", pPais.Nombre);

            objConexion.Open();

            objMySqlCommand.ExecuteNonQueryAsync();

            objConexion.Close();
        }

        public static void Modificar(Entidades.Pais pPais)
        {


            MySqlConnection objConexion = new MySqlConnection(Conexion.ConectorMySql()); // crear objeto de conexion


            string strProc = @"UPDATE paises SET Nombre= @Nombre where IdPaises = @IdPaises";

            MySqlCommand objComModificar = new MySqlCommand(strProc, objConexion);



            objComModificar.CommandType = CommandType.StoredProcedure;    // le indico que el strProc sea un Stored Procedure


            // parametros
            
            objComModificar.Parameters.AddWithValue("@IdPaises", pPais.IdPaises);
            objComModificar.Parameters.AddWithValue("@Nombre", pPais.Nombre);
           


            objConexion.Open();// abre la conexion

            objComModificar.ExecuteNonQuery();  // ejecutar commad


            objConexion.Close();     // cierro la conexion

        }

        public static void Borrar(int pID)
        {
         
            MySqlConnection objConexion = new MySqlConnection(Conexion.ConectorMySql());    // crear objeto de conexion

            string strProc = @"delete from paises where IdPaises = @IdPaises";


            MySqlCommand objComBorrar = new MySqlCommand(strProc, objConexion);

            objComBorrar.Parameters.AddWithValue("@IdPaises", pID);

            objConexion.Open();// abre la conexion

            objComBorrar.ExecuteNonQuery(); // ejecutar commad

            // cierro la conexion
            objConexion.Close();

        }

        public static Entidades.Pais MostrarPais(int id)
        {
            //Creamos entidad Genero
            Entidades.Pais objpais = new Entidades.Pais();

            //Creamos el obj conexion
            MySqlConnection objconexion = new MySqlConnection(Conexion.ConectorMySql());

            //Guardamos la consulta
            string strSQL = @"select Nombre from paises where Idpaises = @IdPaises";

            //creamos el obj de la consulta y la conexion (Puente)
            MySqlCommand objMySqlcommand = new MySqlCommand(strSQL, objconexion);

            //asignamos el parametro de id
            objMySqlcommand.Parameters.AddWithValue("@IdPaises", id);
            //abrimos conexion
            objconexion.Open();

            //Guardamos la consulta en un obj data reader (Ejecucion de consulta)
            MySqlDataReader dtr = objMySqlcommand.ExecuteReader();

            if (dtr.Read())
            {

                objpais.Nombre = dtr["Nombre"].ToString();

            }

            //cerramos conexion
            objconexion.Close();



            return objpais;
        }


        public static DataTable BuscarPais(string descr)
        {


            DataTable objDt = new DataTable();

            string strProc = @"SELECT IdPaises, Nombre from paises WHERE Nombre LIKE '%" + descr + "%'";

            MySqlDataAdapter objGeneroMySql = new MySqlDataAdapter(strProc, Conexion.ConectorMySql());


            objGeneroMySql.Fill(objDt);// abre la conexion

            return objDt;
        }


        public static DataTable BuscarPais(int IdPaises)
        {


            DataTable objDt = new DataTable();

            string strProc = @"SELECT IdPaises, Nombre from paises WHERE IdPaises =" + IdPaises;



            MySqlDataAdapter objGeneroMySql = new MySqlDataAdapter(strProc, Conexion.ConectorMySql());


            objGeneroMySql.Fill(objDt);// abre la conexion

            return objDt;
        }



    }
}
