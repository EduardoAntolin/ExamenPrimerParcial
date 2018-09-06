using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Platillos
    {
        public string identificador { get; set; }
        string platillonombre { get; set; }
        string descripcion { get; set; }
       public List<Ingredientes> ingredientes = new List<Ingredientes>();
        double _precio;
        public double precio
        {
            get
            {
                return _precio;
            }
            set
            {
                if(value < 50)
                {
                    _precio = 50;
                }
                else
                {
                    _precio = precio;
                }
            }
        }
      

    }
}
