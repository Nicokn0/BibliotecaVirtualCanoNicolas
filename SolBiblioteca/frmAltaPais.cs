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
    public partial class frmAltaPais : Form
    {
        Logica.Pais objLogicapais = new Logica.Pais();

        public frmAltaPais()
        {
            InitializeComponent();
            TraerPais("");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Entidades.Pais objpais = new Entidades.Pais();

            objpais.Nombre = txtpais.Text;

           

            objLogicapais.Agregar(objpais);

            MessageBox.Show("Nacionalidad agregada a la lista !!!", "AGREGAR País", MessageBoxButtons.OK, MessageBoxIcon.Information);

            TraerPais("");

            LimpiarForm();
        }

        public void LimpiarForm()
        {
            txtpais.Text = "";

            txtpais.Focus();
        }


        public void TraerPais(string pFiltro)
        {
            dgwPais.DataSource = objLogicapais.TraerTodos(pFiltro);

        }
    }
}
