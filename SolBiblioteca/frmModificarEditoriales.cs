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
    public partial class frmModificarEditoriales : Form
    {
        Logica.Editorial objTraerEditorial = new Logica.Editorial();

        public frmModificarEditoriales()
        {
            InitializeComponent();

            TraerEditorial("");


        }

        // buscar ----------
        private void btnbuscar_Click(object sender, EventArgs e)
        {
          
            if (dgwEditorial.Rows.Count > 0)
            {

                dgwEditorial.DataSource = objTraerEditorial.BuscarEditorial(txtbuscarE.Text);

                MessageBox.Show("DEBERA CARGAR EL ID DEL  GENERO PARA MODIFICAR EL MISMO O SELECCIONAR FILA CORRESPONDIENTE A ELIMINAR ", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);


                btnModificar.Enabled = true;
                txtbuscarE.Enabled = true;
                btnModificar.Enabled = true;
                txtmodificar.Enabled = true;
            }
            else
            {
                MessageBox.Show("Ingrese Descripción", "Modificar Editorial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btnbxId_Click(object sender, EventArgs e) // Filtrar editoriales
        {
            if (!txtmodificar.Text.Equals(""))
            {

                dgwEditorial.DataSource = objTraerEditorial.BuscarEditorial(int.Parse(txtmodificar.Text));

                MostrarDatos();
            }
            else
            {
                MessageBox.Show("Ingrese ID", "Modificar País", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                frmAltaEditorial objAlta = new frmAltaEditorial();

                MostrarForm(objAlta);

            }
        }

       

        private void btnModificar_Click(object sender, EventArgs e) //Modificar
        {
            Logica.Editorial objEd = new Logica.Editorial();


            DialogResult btn = MessageBox.Show("¿Está seguro de que desea MODIFICAR los datos del GENERO?", "Genero", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (btn == DialogResult.Yes)
            {
                objEd.ModificarEditorial(txtmoded.Text, int.Parse(txtmodificarid.Text));
               
                ResetearValores();

                txtmodificarid.Enabled = false;


                MessageBox.Show("¡Genero Modificado!", "Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);


                TraerEditorial("");
                btnModificar.Enabled = false;
            }
            
            


            txtmodificar.Text = "";
            txtmodificar.Enabled = false;
            btnModificar.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
      
        
        // metodos 
        public void TraerEditorial(string pFiltro)
        {
            dgwEditorial.DataSource = objTraerEditorial.TraerTodos(pFiltro);

        }


        private void MostrarForm(Form pForm) //recibe por parametro un formulario
        {
            // pForm.MdiParent = this; // se va a relacionar con el padre
            pForm.StartPosition = FormStartPosition.CenterScreen; // donde se va a posicionarf 
            pForm.Show(); // para que se observe en pantalla 
        }


        private void MostrarDatos()
        {
            Logica.Genero objed = new Logica.Genero();

            DataTable dt = new DataTable();

            if (txtmodificar.Text.Equals("") && !txtbuscarE.Text.Equals(""))
            {
                dt = objed.BuscarGenero(txtbuscarE.Text);

                if (dt.Rows.Count == 0)
                {
                    dgwEditorial.Columns.Clear();
                    dgwEditorial.Visible = false;
                    //LimpiarControles() ;
                    txtbuscarE.Enabled = false;

                    MessageBox.Show("No se ha encontrado registros");

                    btnModificar.Enabled = true;

                }

                if (dt.Rows.Count == 1)
                {
                    dgwEditorial.Columns.Clear();
                    dgwEditorial.Visible = false;

                    txtmodificarid.Text = dt.Rows[0]["IdEditorial"].ToString();
                    txtmoded.Text = dt.Rows[0]["Descripcion"].ToString();
                    txtmoded.Enabled = true;

                    btnModificar.Enabled = true;
                }

                if (dt.Rows.Count > 1)
                {
                    dgwEditorial.DataSource = dt;
                    dgwEditorial.Visible = true;

                }

            }

            //busqueda por id
            if (txtmodificar.Text.Equals("") && ! txtbuscarE.Text.Equals(""))
            {
                dgwEditorial.Columns.Clear();

                dt = objed.BuscarGenero(int.Parse(txtmodificar.Text));

                if (dt.Rows.Count == 0)
                {
                    dgwEditorial.Columns.Clear();
                    dgwEditorial.Visible = false;
                    //LimpiarControles();
                    txtbuscarE.Enabled = false;


                    btnModificar.Enabled = true;
                }

                if (dt.Rows.Count == 1)
                {
                    //dgwGenero.Visible = false;
                    txtmodificarid.Text = dt.Rows[0]["IdGenero"].ToString();
                    txtmoded.Text = dt.Rows[0]["Descripcion"].ToString();
                    txtmoded.Enabled = true;

                    btnModificar.Enabled = true;
                }
            }
        }

        public void ResetearValores()
        {

            txtbuscarE.Text = "";
            txtmodificar.Text = "";
            txtmodificarid.Text = "";
            txtmoded.Text = "";
        }

        // Evento

        private void Selecion_Event(object sender, EventArgs e)
        {
            if (dgwEditorial.SelectedRows.Count > 0)
            {
                txtmodificarid.Text = dgwEditorial.CurrentRow.Cells["IdEditorial"].Value.ToString();
                txtmoded.Text = dgwEditorial.CurrentRow.Cells["Descripcion"].Value.ToString();

                txtmoded.Enabled = true;
                btnModificar.Enabled = true;
            }
        }
    }
}
