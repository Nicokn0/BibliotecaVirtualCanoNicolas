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
    public partial class frmBorrarPais : Form
    {
        Logica.Pais objmostrarp = new Logica.Pais();


        public frmBorrarPais()
        {
            InitializeComponent();
            TraerGenero("");
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (dgwPais.Rows.Count > 0)
            {

                dgwPais.DataSource = objmostrarp.BuscarPais(txtbuscarE.Text);


                btnBorrar.Enabled = true;
            }
            else
            {
                MessageBox.Show("NO HAY REGISTROS INGRESADOS EN EL SISTEMA");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e) // Eliminar
        {

            MessageBox.Show("ELIMINADO con exito", "País Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            objmostrarp.Borrar(int.Parse(txtbuscarId.Text));

            TraerGenero("");


            txtbuscarE.Text = "";

            btnbuscar.Enabled = false;
        }

        private void btnbxId_Click(object sender, EventArgs e) //buscar x id
        {
            if (dgwPais.Rows.Count > 0)
            {

                dgwPais.DataSource = objmostrarp.BuscarPais(int.Parse(txtbuscarId.Text));


                btnBorrar.Enabled = true;
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

        public void TraerGenero(string pFiltro)
        {
            dgwPais.DataSource = objmostrarp.TraerTodos(pFiltro);

        }

    }
}
