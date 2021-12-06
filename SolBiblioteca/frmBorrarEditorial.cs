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
    public partial class frmBorrarEditorial : Form
    {
        Logica.Editorial objTraerEditorial = new Logica.Editorial();

        public frmBorrarEditorial()
        {
            InitializeComponent();
            TraerEditorial("");
        }

    

        private void btnbuscar_Click(object sender, EventArgs e)
        {

            dgwEditorial.DataSource = objTraerEditorial.BuscarEditorial(txtbuscarE.Text);

            btnBorrar.Enabled = true;
        }


        private void btnbxId_Click(object sender, EventArgs e) // buscar x ID
        {
            dgwEditorial.DataSource = objTraerEditorial.BuscarEditorial(int.Parse(txtid.Text));

            if (dgwEditorial.Rows.Count > 0)
            {

                dgwEditorial.DataSource = objTraerEditorial.BuscarEditorial(txtbuscarE.Text);


                btnBorrar.Enabled = true;
            }
            else
            {
                MessageBox.Show("NO HAY REGISTROS INGRESADOS EN EL SISTEMA");
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            EliminarBusqueda(objTraerEditorial);

            MessageBox.Show("EDITORIAL ELIMINADA", "ELIMINAR", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            TraerEditorial("");



        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // METODO

        public void TraerEditorial(string pFiltro)
        {
            dgwEditorial.DataSource = objTraerEditorial.TraerTodos(pFiltro);

        }

        

        public void EliminarBusqueda (Logica.Editorial objEd)
        {
            
                objEd.BorrarEditorial(int.Parse(txtid.Text));
            
        }
        // ------------------------------------------------------

        
    }
}
