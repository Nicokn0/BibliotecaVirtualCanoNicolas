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
    public partial class frmAltaLibro : Form
    {
        Logica.Libro objLogicaLibro = new Logica.Libro();

        Entidades.Libro objEntidadLibro = new Entidades.Libro();

        public frmAltaLibro()
        {
            InitializeComponent();
            TraerLibro("");
        }

        public void TraerLibro(string pFiltro)
        {
            dgwLibros.DataSource = objLogicaLibro.TraerTodos(pFiltro);

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (this.Validar().Equals(""))
            {
                objEntidadLibro.isbn = txtisbn.Text;
                objEntidadLibro.Titulo = txtTitulo.Text;
                objEntidadLibro.Edicion = int.Parse(txtEdicion.Text);
                objEntidadLibro.IdGenero = int.Parse(txtIdGenero.Text);
                objEntidadLibro.IdEditorial = int.Parse(txtidEditorial.Text);

               
                objLogicaLibro.Agregar(objEntidadLibro);
                MessageBox.Show("Autor agregado a la lista !!!", "AGREGAR AUTOR", MessageBoxButtons.OK, MessageBoxIcon.Information);

                TraerLibro("");
                ResetearValores();
            }
            else
            {
                MessageBox.Show(Validar(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void ResetearValores()
        {
            txtTitulo.ResetText();
            txtEdicion.ResetText();
            txtisbn.ResetText();
            txtIdGenero.ResetText();
            txtidEditorial.ResetText();
            
            txtTitulo.Focus();
        }


        public string Validar()
        {
            string mensaje = "";

            if (txtisbn.Text.Equals(""))
            {
                mensaje += "Ingrese un nombre válido \n";

            }
            if (txtTitulo.Text.Equals(""))
            {
                mensaje += "Ingrese un titulo Valido \n";

            }

            if (txtEdicion.Text.Equals(""))
            {
                mensaje += "Ingrese un nombre válido \n";

            }


            if (txtIdGenero.Text == "")
            {
                mensaje += "Ingrese una Nacionalidad \n";
            }

            if (txtidEditorial.Text == "")
            {
                mensaje += "Ingrese una Nacionalidad \n";
            }
            return mensaje;

        }


    }
}
