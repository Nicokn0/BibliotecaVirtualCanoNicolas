using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Autor
    {
        public int ID { get; set; } // es static 

        public int IdPropio { get; } // le

        public string Apellido { get; set; }

        public string Nombre { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public int Nacionalidad { get; set; }

        public Autor ()
        {
         
        }
    }
}
