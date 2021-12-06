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
    public partial class frmModificarAutor : Form
    {
     
        Logica.Autor objlA = new Logica.Autor();
        Entidades.Autor objMod = new Entidades.Autor();
        

        Logica.Autor objbuscar = new Logica.Autor();

        public frmModificarAutor(List<Entidades.Autor> pAutor)
        {
            InitializeComponent();
            dtpFechaNac.MaxDate = DateTime.Now;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            //
            int indiceId;

            if (txtBuscar.Text.Equals(""))
            {
                MessageBox.Show("Ingrese ID", "BORRAR AUTOR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                indiceId = int.Parse(txtBuscar.Text);


                MostrarDatos(indiceId);

                HabilitarControles();

            }
        }

  
        public void HabilitarControles()
        {
            if (txtNombre.Enabled && txtApellido.Enabled && cboPaises.Enabled && dtpFechaNac.Enabled && btnConfirmar.Enabled)
            {
                txtNombre.Enabled = false;
                txtApellido.Enabled = false;
                cboPaises.Enabled = false;
                dtpFechaNac.Enabled = false;
                btnConfirmar.Enabled = false;

            }
            else
            {
                txtNombre.Enabled = true;
                txtApellido.Enabled = true;
                cboPaises.Enabled = true;
                dtpFechaNac.Enabled = true;
                btnConfirmar.Enabled = true;
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Entidades.Autor objMod = new Entidades.Autor();

            objMod.Nombre = txtNombre.Text;
            objMod.Apellido = txtApellido.Text;
            objMod.Nacionalidad = cboPaises.SelectedIndex + 1;

            objMod.FechaNacimiento = dtpFechaNac.Value;
            objMod.ID = int.Parse(txtBuscar.Text);

          

            objlA.Modificar(objMod);

            
            ResetearValores();

            MessageBox.Show("Se ha modificado el autor con EXITO", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void ResetearValores ()
        {
            txtApellido.ResetText();
            txtNombre.ResetText();
            dtpFechaNac.Value = DateTime.Today;
            cboPaises.SelectedIndex = 0;
            txtApellido.Focus();
        }

        private void cboPaises_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void MostrarDatos(int id)
        {
            //cargar dgw. LIKE BUSQUEDA
            
                Logica.Autor objaut = new Logica.Autor();

                txtApellido.Text = objaut.TraerUno(id).Apellido;
                txtNombre.Text = objaut.TraerUno(id).Nombre;
                dtpFechaNac.Value = objaut.TraerUno(id).FechaNacimiento;
                cboPaises.SelectedValue = objaut.TraerUno(id).Nacionalidad ;

                
                MessageBox.Show($" Para MODIFICAR el autor debera presionar el botón MODIFICAR", " MODIFICAR AUTOR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

        }


    }
}
