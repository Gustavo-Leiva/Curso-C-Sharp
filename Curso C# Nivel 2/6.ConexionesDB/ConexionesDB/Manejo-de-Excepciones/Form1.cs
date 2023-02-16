using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manejo_de_Excepciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int resultado;
            try
            {

                resultado= calcular();
                lblResultado.Text = "= " + resultado;
            }
            catch (FormatException ex)
            {
                MessageBox.Show("cargar solo numeros....");
               
            }
            catch (DivideByZeroException ex) 
            {
                MessageBox.Show("No se puede dividir por cero....");

            }

            catch(Exception ex)
            {
                MessageBox.Show("Hubo un error no reconocido...");
            }

            finally //es un bloque opcional
            {

            }

           
        }


        private int calcular()
        {
            int a, b, r;

            try
            {
                a = int.Parse(txtUno.Text);
                b = int.Parse(txtDos.Text);
                r = a / b;
                return r;

            }
            catch (Exception ex)
            {
                //guardar registro de error en archivo....
                throw ex;
            }
        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }
    }
}
