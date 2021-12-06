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
    public partial class frmBorrarAutor : Form
    {
        Entidades.Autor objMod = new Entidades.Autor();
        Logica.Autor objlA = new Logica.Autor();

       

        public frmBorrarAutor(List<Entidades.Autor> pAutor)
        {
            InitializeComponent();
            TraerAutor("");
          
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (dgwAutor.Rows.Count > 0)
            {

                dgwAutor.DataSource = objlA.BuscarAutor(txtbuscarE.Text);

                MessageBox.Show("DEBERA CARGAR EL ID DEL  PAÍS PARA BORRAR EL MISMO O SELECCIONAR FILA CORRESPONDIENTE A MODIFICAR ", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);


                btnBorrar.Enabled = true;
            }
            else
            {

                MessageBox.Show("NO HAY AUTORES EN EL SISTEMA, SE ABRIRA AGREGAR AUTOR", "Borrar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frmAltaAutor objAlta = new frmAltaAutor ();

                MostrarForm(objAlta);

            }
        }


        private void btnbxId_Click(object sender, EventArgs e) //buscar x ID
        {
            dgwAutor.DataSource = objlA.BuscarAutor(int.Parse(txtid.Text));

            if (dgwAutor.Rows.Count > 0)
            {

                dgwAutor.DataSource = objlA.BuscarAutor(int.Parse(txtid.Text));

                MessageBox.Show("DEBERA CARGAR EL ID DEL  AUTOR PARA BORRAR EL MISMO ", "BORRAR", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnBorrar.Enabled = true;
            }
            else
            {
                MessageBox.Show("NO HAY REGISTROS INGRESADOS EN EL SISTEMA");
                
                frmAltaAutor objAlta = new frmAltaAutor();

                MostrarForm(objAlta);


            }
        }

        private void btnBorrar_Click(object sender, EventArgs e) // BORRAR
        {
                objlA.Borrar(int.Parse(txtid.Text));

                MessageBox.Show("Se  ELIMINO el autor con EXITO", "ELIMINAR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnBorrar.Enabled = true;


            TraerAutor("");
        }


        private void btnSalir_Click(object sender, EventArgs e) //Salir
        {
            this.Close();
        }

        //METODO

        public void TraerAutor(string pFiltro)
        {
            dgwAutor.DataSource = objlA.TraerTodos(pFiltro);

        }

        private void MostrarForm(Form pForm) //recibe por parametro un formulario
        {
            // pForm.MdiParent = this; // se va a relacionar con el padre
            pForm.StartPosition = FormStartPosition.CenterScreen; // donde se va a posicionarf 
            pForm.Show(); // para que se observe en pantalla 
        }

    
    }
}
