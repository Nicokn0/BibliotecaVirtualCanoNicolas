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
    public partial class frmAltaGenero : Form
    {

        Logica.Genero objLogicaGenero = new Logica.Genero();
        private frmVerListaGenero frmListagenero;

        public frmAltaGenero()
        {
            InitializeComponent();
            TraerGenero("");
        }
        public frmAltaGenero(Entidades.Genero pGenero, frmVerListaGenero formAutores)
        {
            InitializeComponent();

            
            TraerGenero("");

            //Cargo instancia de lista de generos
            frmListagenero = formAutores;

            //Completo los campos del formulario con el objeto autor
            txtgenero.Text = pGenero.Descripcion;
           

            //Cargo variables auxiliares
            int ID = pGenero.IdGenero;
          
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Entidades.Genero objGenero = new Entidades.Genero();

            objGenero.Descripcion = txtgenero.Text;

            objLogicaGenero.Agregar(objGenero);

            MessageBox.Show("Genero agregado a la lista !!!", "AGREGAR GENERO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            TraerGenero("");

            LimpiarForm();
        }
      
        public void LimpiarForm()
        {
            txtgenero.Text = "";

            txtgenero.Focus();
        }

        public void TraerGenero(string pFiltro)
        {
            dgwGenero.DataSource = objLogicaGenero.TraerTodos(pFiltro);


        }
    }
}
