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
    public partial class frmModificarPais : Form
    {

        public Logica.Pais objLogicaPais = new Logica.Pais();

        Logica.Genero objed = new Logica.Genero();


        public frmModificarPais()
        {
            InitializeComponent();
            TraerPais("");
        }

        //INICIO DE BUSQUEDAS --------------------
        private void btnbuscar_Click(object sender, EventArgs e) // Filtro
        {
            if (dgwPais.Rows.Count > 0)
            {

                dgwPais.DataSource = objLogicaPais.BuscarPais(txtbuscarE.Text);

                MessageBox.Show("DEBERA CARGAR EL ID DEL  PAÍS PARA MODIFICAR EL MISMO O SELECCIONAR FILA CORRESPONDIENTE A MODIFICAR ", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);


                btnModificar.Enabled = true;
            }
            else
            {

                MessageBox.Show("NO HAY PAISES EN EL SISTEMA, SE ABRIRA AGREGAR AUTOR", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frmAltaPais objAlta = new frmAltaPais();

                MostrarForm(objAlta);

            }
        }

        //busqueda por ID
        private void btnbxId_Click(object sender, EventArgs e)
        {
            if (dgwPais.Rows.Count > 0)
            {

                dgwPais.DataSource = objLogicaPais.BuscarPais(int.Parse(txtbuscarId.Text));

                MostrarDatos();

            }
            else
            {
                MessageBox.Show("Ingrese ID", "Modificar País", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // FIN DE BUSQUEDA ----------------------------------------------------------

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Logica.Editorial objEd = new Logica.Editorial();

            objEd.ModificarEditorial(txtbuscarId.Text, int.Parse(txtbuscarE.Text));

            MessageBox.Show("Se ha modificado el PAÍS con EXITO", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            ResetearValores();
            
            txtbuscarId.Enabled = false;
            btnModificar.Enabled = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
      
        // Evento

        private void Seleccionar_Fila(object sender, EventArgs e)
        {
            if (dgwPais.SelectedRows.Count > 0)
            {
                txtmodID.Text = dgwPais.CurrentRow.Cells["IdPaises"].Value.ToString();
                txtNombreMod.Text = dgwPais.CurrentRow.Cells["Nombre"].Value.ToString();

                txtNombreMod.Enabled = true;
                btnModificar.Enabled = true;
            }
        }

        // metodos 
        public void TraerPais(string pFiltro)
        {
            dgwPais.DataSource = objLogicaPais.TraerTodos(pFiltro);

        }

        private void MostrarForm(Form pForm) //recibe por parametro un formulario
        {
            // pForm.MdiParent = this; // se va a relacionar con el padre
            pForm.StartPosition = FormStartPosition.CenterScreen; // donde se va a posicionarf 
            pForm.Show(); // para que se observe en pantalla 
        }

        private void MostrarDatos()
        {
    

            DataTable dt = new DataTable();

            if (txtbuscarId.Text.Equals("") && !txtbuscarE.Text.Equals(""))
            {
                dt = objed.BuscarGenero(txtbuscarE.Text);

                if (dt.Rows.Count == 0)
                {
                    dgwPais.Columns.Clear();
                    dgwPais.Visible = false;
                    //LimpiarControles();
                    txtbuscarE.Enabled = false;

                    MessageBox.Show("No se ha encontrado registros");

                    btnModificar.Enabled = true;

                }

                if (dt.Rows.Count == 1)
                {
                    dgwPais.Columns.Clear();
                    dgwPais.Visible = false;

                    txtbuscarId.Text = dt.Rows[0]["IdPaises"].ToString();
                    txtNombreMod.Text = dt.Rows[0]["Nombre"].ToString();
                    txtNombreMod.Enabled = true;

                    btnModificar.Enabled = true;
                }

                if (dt.Rows.Count > 1)
                {
                    dgwPais.DataSource = dt;
                    dgwPais.Visible = true;

                }

            }

            //busqueda por id
            if (txtbuscarId.Text.Equals("") && !txtbuscarE.Text.Equals(""))
            {
                dgwPais.Columns.Clear();

                dt = objed.BuscarGenero(int.Parse(txtbuscarId.Text));

                if (dt.Rows.Count == 0)
                {
                    dgwPais.Columns.Clear();
                    dgwPais.Visible = false;
                
                    txtmodID.Enabled = false;


                    btnModificar.Enabled = true;
                }

                if (dt.Rows.Count == 1)
                {
                   
                    txtmodID.Text = dt.Rows[0]["IdGenero"].ToString();
                    txtNombreMod.Text = dt.Rows[0]["Descripcion"].ToString();
                    txtNombreMod.Enabled = true;

                    btnModificar.Enabled = true;
                }
            }
        }


        public void ResetearValores()
        {

            txtbuscarE.Text = "";
            txtbuscarId.Text = "";
            txtmodID.Text = "";
            txtNombreMod.Text = "";
        }
    }
}
