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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e) //salir del formulario
        {
            this.Close();
        }


        private void nuevoToolStripMenuItem_click(object sender, EventArgs e)
        {
            //llamo a un nuevo metodo privado que se encargara de mostrar todos los formularios hijos de la misma manera. Va a llamar a frmAltaAutor
            
            MostrarForm(new frmAltaAutor());
        }

        private void MostrarForm (Form pForm) //recibe por parametro un formulario
        {
            pForm.MdiParent = this; // se va a relacionar con el padre
            pForm.StartPosition = FormStartPosition.CenterScreen; // donde se va a posicionarf 
            pForm.Show(); // para que se observe en pantalla 
        }

        private void verAutorToolStripMenuItem_Click(object sender, EventArgs e) // evento click para ver autor 
        {
            MostrarForm(new frmVerListaAutores()); //llamo al metodo para mostrar la lista de autores  y dentro de los parentesis le paso la lista cree en program listaautor 
        }

        private void modificaToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            MostrarForm(new frmModificarAutor(Program.ListaAutor));
        }

        private void borrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarForm(new frmBorrarAutor(Program.ListaAutor));
        }

        private void verEditorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarForm(new frmVerListaEditoriales());
        }

        private void verGenerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarForm(new frmVerListaGenero());
        }

        private void verPaisesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarForm(new frmVerListaPaises());
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarForm(new frmModificarEditoriales());
        }

        private void borrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MostrarForm(new frmBorrarEditorial());
        }

        private void borrarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            MostrarForm(new frmBorrarPais());
        }

        private void borrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MostrarForm(new frmBorrarGenero());
        }

        private void modificarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MostrarForm(new frmModificarGenero());
        }

        private void modificarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MostrarForm(new frmModificarPais());
        }

        private void nuevoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MostrarForm(new frmAltaEditorial());
        }

        private void nuevoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MostrarForm(new frmAltaGenero());
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarForm(new frmAltaPais());
        }

        private void agregarLibroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarForm(new frmAltaLibro());
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
