using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos; //me dijo el visual que le agregue este using 
using MySqlConnector;

namespace SolBiblioteca
{
    public partial class frmAltaAutor : Form
    {
        public frmAltaAutor()
        {
            InitializeComponent();

            MostrarPaises(cboPaises);

            // preguntar lo de la fecha  y mostrar pais
           
        }

        private void btnConfirmar_Click(object sender, EventArgs e) // Boton Confirmar desde autor creo el obj Entidad Autor
        {
            Entidades.Autor objEntidadAutor = new Entidades.Autor(); // instancio primero creo 

            // Seteo de valores
            if (this.Validar().Equals(""))
            {


                objEntidadAutor.Apellido = txtApellido.Text;
                objEntidadAutor.Nombre = txtNombre.Text;
                objEntidadAutor.FechaNacimiento = dtpFechaNac.Value.Date;
                objEntidadAutor.Nacionalidad = 1; // esta definido como string lo dejamos asi par luego modificarlo

                // Seteo Valores

                // Referencio a Entdiades para que pueda agregar al autor desde la capa de Logica 

                Logica.Autor objLogica = new Logica.Autor(); // la forma correcta de manejar las entidades de tipo autor 

                // ------- objLogica.Agregar(//paso una lista y un objeto para que se relacione con los metodos creados en la lista de logica)

                // FRONTEND CON LOGICA Y ENTIDAD Y BACKECN CON ENTIDADADES

                // lo de abajo es para coleccion
                // objLogica.Agregar(Program.ListaAutor, objEntidadAutor);// le paso por colecccion la lista autor x lo declare como static por eso posible y despues le paso por paramtetro el autor 

                // obj x base de datos
                objLogica.Agregar(objEntidadAutor);
                MessageBox.Show("Autor agregado a la lista !!!", "AGREGAR AUTOR", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ResetearValores();
            }
            else
            {
                MessageBox.Show(Validar(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // METODOS - Función

        public void ResetearValores()
        {
            txtApellido.ResetText();
            txtNombre.ResetText();
            dtpFechaNac.Value = DateTime.Today;
            cboPaises.SelectedIndex = 0;
            txtApellido.Focus();
        }

   
        public  string Validar()
            {
                string mensaje = "";
                if (txtNombre.Text.Equals(""))
                {
                    mensaje += "Ingrese un nombre válido \n";

                }
                if (txtApellido.Text.Equals(""))
                {
                mensaje += "Ingrese un apellido Valido \n";
               
                }
                
                if (cboPaises.Text == "")
                {
                    mensaje += "Ingrese una Nacionalidad \n";
                }

                return mensaje;

            }

        public void MostrarPaises(ComboBox cobox) //mostrar la lista de paises desede  la base de datos
        {
            
            Logica.Pais objLogicaPais = new Logica.Pais();

            cboPaises.DataSource = objLogicaPais.TraerTodos("");
       
            cboPaises.DisplayMember = "Nombre";      // campo a mostrar por pantalla 
            cboPaises.ValueMember = "IdPaises";      // guarda el indice //PREGUNTAR
   
        }

  
     
    }
    }

