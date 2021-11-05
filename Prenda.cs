using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIntegrador
{
    class Prenda
    {
        protected double precio;
        protected bool calidadPremium ; 

        public Prenda(double precio , bool calidadPremium )
        {
            this.precio = precio;
            this.calidadPremium = calidadPremium; 
        }


    }
}
