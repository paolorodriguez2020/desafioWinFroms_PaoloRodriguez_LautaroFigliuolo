using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIntegrador
{
    class Pantalon:Prenda,ICalculadoraPantalones
    {
        private bool bermuda;

        public Pantalon(double precio, bool calidadPremium, bool bermuda) : base(precio, calidadPremium)
        {
            this.bermuda = bermuda; 
        }

        public Double calcularPantalones(int CantidadP)
        {
            double precioFinal = precio*CantidadP;

            if(bermuda == true)
            {
                precioFinal = precioFinal - (precioFinal * 0.2);
            }
            if(calidadPremium == true)
            {
                precioFinal = precioFinal + (precioFinal * 0.3);
            }

            return precioFinal; 
        }
    }
}
