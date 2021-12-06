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
    public partial class frmBorrarGenero : Form
    {

        Logica.Genero objmostrarg = new Logica.Genero();

        public frmBorrarGenero()
        {
            InitializeComponent();
            TraerGenero("");
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
           
                objmostrarg.BorrarGenero(int.Parse(txtbuscarId.Text));

                txtbuscarE.Text = "";

                TraerGenero("");

                MessageBox.Show("ELIMINADO con exito", "ELIMINAR GENERO", MessageBoxButtons.OK , MessageBoxIcon.Exclamation);

                btnbuscar.Enabled = false;

            

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
         

            if (dgwGenero.Rows.Count > 0)
            {

                dgwGenero.DataSource = objmostrarg.BuscarGenero(txtbuscarE.Text);


                btnModificar.Enabled = true;
            }
            else
            {
                MessageBox.Show("NO HAY REGISTROS INGRESADOS EN EL SISTEMA");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnbxId_Click(object sender, EventArgs e)
        {
            if (dgwGenero.Rows.Count > 0)
            {

                dgwGenero.DataSource = objmostrarg.BuscarGenero(int.Parse(txtbuscarId.Text));


                btnModificar.Enabled = true;
            }
            else
            {
                MessageBox.Show("NO HAY REGISTROS INGRESADOS EN EL SISTEMA");
            }
        }

        public void TraerGenero(string pFiltro)
        {
            dgwGenero.DataSource = objmostrarg.TraerTodos(pFiltro);

        }

    }
}
