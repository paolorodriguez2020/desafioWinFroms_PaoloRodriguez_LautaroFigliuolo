using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIntegrador
{
    class Camisa:Prenda,ICalculadoraCamisas
    {
        private bool mangaCorta;
        
        public Camisa(double precio, bool calidadPremium, bool mangaCorta) : base(precio, calidadPremium)
        {
            this.mangaCorta = mangaCorta;
        }
        public double calcularCamisas(int cantidadC)
        {
            double precioFinal = precio * cantidadC;
            if (mangaCorta == true)
            {
                precioFinal = precioFinal - (precioFinal * 0.1);

            }
            if(calidadPremium == true)
            {
                precioFinal= precioFinal + (precioFinal*0.3);
            }


            return precioFinal;
        }
    }
}
