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
    public partial class frmVerListaAutores : Form
    {
        public frmVerListaAutores() // le paso por parametro la coleccion de autores 
        {
            InitializeComponent();
            Logica.Autor objTraerTodo = new Logica.Autor(); //creo el obj e instancion 
            //uso metodo traer todo para pasarle la base de datos   
            dgvListaAutores.DataSource = objTraerTodo.TraerTodos("");
            
         
        }


    }
}
