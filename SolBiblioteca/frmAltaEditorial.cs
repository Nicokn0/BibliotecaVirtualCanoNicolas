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
    public partial class frmAltaEditorial : Form
    {
        Entidades.Editorial objEditorial = new Entidades.Editorial();

        Logica.Editorial objLogicaeditorial = new Logica.Editorial();

        public frmAltaEditorial()
        {
            InitializeComponent();
            TraerEditorial("");
        }

        private void btn_Click(object sender, EventArgs e)
        {
          
            objEditorial.Descripcion = txtnomedi.Text;


            objLogicaeditorial.Agregar(objEditorial);

            MessageBox.Show("Editorial agregada a la lista !!!", "AGREGAR Editorial", MessageBoxButtons.OK, MessageBoxIcon.Information);

            TraerEditorial("");

            LimpiarForm();
        }

        public void LimpiarForm()
        {
            txtnomedi.Text = "";

            txtnomedi.Focus();
        }

        public void TraerEditorial(string pFiltro)
        {
            dgwEditorial.DataSource = objLogicaeditorial.TraerTodos(pFiltro);

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
