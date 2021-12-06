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
    public partial class frmVerListaGenero : Form
    {
        public frmVerListaGenero()
        {
            InitializeComponent();
            Logica.Genero objTraerGeneros = new Logica.Genero();
            dgwGenero.DataSource = objTraerGeneros.TraerTodos("");
        }
    }
}
