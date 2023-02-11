using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_Integral
{
    public partial class Formulario5 : Form
    {
        public Formulario5()
        {
            InitializeComponent();
        }

        private void btnAceptar_MouseMove(object sender, MouseEventArgs e)
        {
            btnAceptar.Cursor = Cursors.Hand;
                
        }

        private void btnCancelar_MouseMove(object sender, MouseEventArgs e)
        {
            btnCancelar.Cursor = Cursors.Hand;
        }

        private void btnAceptar_MouseLeave(object sender, EventArgs e)
        {
            btnAceptar.Cursor = Cursors.Arrow;
        }

        private void btnCancelar_MouseLeave(object sender, EventArgs e)
        {
            btnCancelar.Cursor = Cursors.Arrow;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
            string apellido = textApellido.Text;
            string nombre = textNombre.Text;
            string nombreCompleto = apellido + " " + nombre;

            if (apellido != "" || nombre != "")
            {
                lwlElementos.Items.Add("APELLIDO Y NOMBRE: " + nombreCompleto);
            }
            

            string edad = textEdad.Text;

            if(edad != "")
            {
                lwlElementos.Items.Add("EDAD: "+ edad);
            }

           
            string direccion = textDireccion.Text;
            if(direccion != "")
            {
                lwlElementos.Items.Add("DIRECCION: " + direccion);
            }
            
          



            if (textApellido.Text == "")           
                 textApellido.BackColor = Color.Red;
            else
                textApellido.BackColor = System.Drawing.SystemColors.Control;

            if (textNombre.Text == "")                
                  textNombre.BackColor = Color.Red;
            else
                textApellido.BackColor = System.Drawing.SystemColors.Control;

            if (textEdad.Text == "")
                textEdad.BackColor = Color.Red;
            else
                textApellido.BackColor = System.Drawing.SystemColors.Control;

            if (textDireccion.Text == "")                        
                  textDireccion.BackColor = Color.Red;
            else
                textApellido.BackColor = System.Drawing.SystemColors.Control;  
                       



        }

    
        private void textEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;


        }

        private void textApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 65 || e.KeyChar > 90) && (e.KeyChar < 97 || e.KeyChar > 122) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Formulario5_Load(object sender, EventArgs e)
        {

        }
    }
}
