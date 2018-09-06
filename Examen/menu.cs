using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class menu
    {
        public string nombre { get; set; }
        public string identificador { get; set; }
        public int inicio { get; set; }
        public int fin { get; set; }
        public List<Platillos> platillos = new List<Platillos>();
        public menu()
        {
            nombre = "Nuevo nombre";
        }

    }
}
