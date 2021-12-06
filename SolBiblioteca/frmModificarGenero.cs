using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolBiblioteca
{
    public partial class frmModificarGenero : Form
    {
        
        public Logica.Genero objmostrarGenero = new Logica.Genero();

   
        public frmModificarGenero()
        {
            InitializeComponent();
            TraerGenero("");
            
        }

        private void btnbuscar_Click(object sender, EventArgs e) // filtro la busqueda que realizo 
        {
            // resultado de la consulta siguiente es un DATA TABLE. Si el Data Table tiene mas de un registro
            //Tengo que asignar el Data Table como un DAta Source de un Dgw para mostrar todos los registros en una grilla. hacer visible el  dgw 

            // mientras que si el data table tiene un solo registro  debo completar los controles directamente en el formulario.
            // En caso de mostrar el dgw es darle la posibilidad del usuario con doble click, seleccione el registro que quiere y los valores de ese registro sean trasladados a los controles correspondientes del formulario.


            //dgwGenero.Rows.Count > 0
            if (dgwGenero.Rows.Count > 0)
            {
             
                dgwGenero.DataSource = objmostrarGenero.BuscarGenero(txtbuscarE.Text);

                MessageBox.Show("DEBERA CARGAR EL ID DEL  GENERO PARA MODIFICAR EL MISMO O SELECCIONAR FILA CORRESPONDIENTE A MODIFICAR", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);


                btnModificar.Enabled = true;
            }
            else
            {
                
                MessageBox.Show("NO HAY GENEROS EN EL SISTEMA, SE ABRIRA AGREGAR AUTOR", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frmAltaGenero objAlta = new frmAltaGenero();

                MostrarForm(objAlta);

            }
        }

        private void button1_Click(object sender, EventArgs e) //id buscar 
        {
            if (dgwGenero.Rows.Count > 0)
            {
                MessageBox.Show("PERMIR QUE GAFAST, ACCEDA A TU CAMARA", "PERMITIR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgwGenero.DataSource = objmostrarGenero.BuscarGenero(int.Parse(txtbID.Text));

                MostrarDatos();

            }
            else
            {
                MessageBox.Show("Ingrese ID", "Modificar Genero", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnModificar_Click_1(object sender, EventArgs e) //modificar
        {

            DialogResult btn = MessageBox.Show("¿Esta seguro de que desea MODIFICAR los datos del GENERO?", "Genero", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (btn == DialogResult.Yes)
            {

                objmostrarGenero.ModificarGenero(txtdesmod.Text, int.Parse(txtidModi.Text));
              
                ResetearValores();

                txtidModi.Enabled = false;
                

                MessageBox.Show("¡Genero Modificado!", "Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);


                TraerGenero("");
                btnModificar.Enabled = false;
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Eventos

        private void CambiarData(object sender, EventArgs e) //Evento Selected Change 
        {
            if (dgwGenero.SelectedRows.Count > 0)
            {
                txtidModi.Text = dgwGenero.CurrentRow.Cells["IdGenero"].Value.ToString();
                txtdesmod.Text = dgwGenero.CurrentRow.Cells["Descripcion"].Value.ToString();

                txtdesmod.Enabled = true;
                btnModificar.Enabled = true;
            }
        }


        //Metodos

        private void MostrarDatos()
        {
            Logica.Genero objed = new Logica.Genero();

            DataTable dt = new DataTable();

            if (txtbID.Text.Equals("") && !txtbuscarE.Text.Equals(""))
            {
                dt = objed.BuscarGenero(txtbuscarE.Text);

                if (dt.Rows.Count == 0)
                {
                    dgwGenero.Columns.Clear();
                    dgwGenero.Visible = false;
                    
                    txtbuscarE.Enabled = false;
                    
                    MessageBox.Show("No se ha encontrado registros");

                    btnModificar.Enabled = true;

                }

                if (dt.Rows.Count == 1)
                {
                    dgwGenero.Columns.Clear();
                    dgwGenero.Visible = false;

                    txtidModi.Text = dt.Rows[0]["IdGenero"].ToString();
                    txtdesmod.Text = dt.Rows[0]["Descripcion"].ToString();
                    txtdesmod.Enabled = true;

                    btnModificar.Enabled = true;
                }

                if (dt.Rows.Count > 1)
                {
                    dgwGenero.DataSource = dt;
                    dgwGenero.Visible = true;

                }

            }

            //busqueda por id
            if (txtbID.Text.Equals("") && !txtbuscarE.Text.Equals(""))
            {
                dgwGenero.Columns.Clear();

                dt = objed.BuscarGenero(int.Parse(txtbID.Text));

                if (dt.Rows.Count == 0)
                {
                    dgwGenero.Columns.Clear();
                    dgwGenero.Visible = false;
                    //LimpiarControles();
                    txtdesmod.Enabled = false;
                    

                    btnModificar.Enabled = true;
                }

                if (dt.Rows.Count == 1)
                {
                    //dgwGenero.Visible = false;
                    txtidModi.Text = dt.Rows[0]["IdGenero"].ToString();
                    txtdesmod.Text = dt.Rows[0]["Descripcion"].ToString();
                    txtdesmod.Enabled = true;

                    btnModificar.Enabled = true;
                }
            }
        }

       
        public void ResetearValores()
        {

            txtbuscarE.Text = "";
            txtbID.Text = "";
            txtdesmod.Text = "";
            txtidModi.Text = "";
        }
     
        public void TraerGenero(string pFiltro)
        {
            dgwGenero.DataSource = objmostrarGenero.TraerTodos(pFiltro);

        }


        private void MostrarForm(Form pForm) //recibe por parametro un formulario
        {
            // pForm.MdiParent = this; // se va a relacionar con el padre
            pForm.StartPosition = FormStartPosition.CenterScreen; // donde se va a posicionarf 
            pForm.Show(); // para que se observe en pantalla 
        }
    }
}
