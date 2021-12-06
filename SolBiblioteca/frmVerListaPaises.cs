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
    public partial class frmVerListaPaises : Form
    {
        public frmVerListaPaises()
        {
            InitializeComponent();
            Logica.Pais objTraerPais = new Logica.Pais();
            dgwPaises.DataSource = objTraerPais.TraerTodos("");
        }
    }
}
