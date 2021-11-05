using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIntegrador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double precio = Convert.ToDouble(textBox1.Text);
            bool calidadPremium  ; 

            if(rdbtnStandard.Checked == true)
            {
                calidadPremium = false; 
            }
            else
            {
                calidadPremium = true;
            }


            if(rdCamisa.Checked == true)
            {
                Camisa camisa;
                if(checkMangaCorta.Checked == true)
                {
                     camisa = new Camisa(precio, calidadPremium,true);
                }
                else
                {
                     camisa = new Camisa(precio, calidadPremium,false);
                }
               double precioFinalCamisa= camisa.calcularCamisas(Convert.ToInt32(textBox1.Text));
                lblPrecioFinal.Text = String.Format("{0:0.00}", precioFinalCamisa);
                MessageBox.Show(lblPrecioFinal.Text, "Precio Final ");
            }

            if(rdPantalon.Checked ==true)
            {
                Pantalon pantalon; 
                if (checkBermuda.Checked ==true)
                {
                     pantalon = new Pantalon(precio, calidadPremium, true);
                }

                else
                {
                    pantalon = new Pantalon(precio, calidadPremium,false);
                }

                double precioFinalPantalon = pantalon.calcularPantalones(Convert.ToInt32(textBox2.Text));

                lblPrecioFinal.Text =String.Format("{0:0.00}", precioFinalPantalon);
                MessageBox.Show(lblPrecioFinal.Text,"Precio Final");
            }

           
            
            





        }
    }
}
