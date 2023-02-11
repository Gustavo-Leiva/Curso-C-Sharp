using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Mensaje inicial al abrirse el programa.
            MessageBox.Show("Bienvenido a Curso de C# nivel 2");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Mensaje al cerrar el programa.
            MessageBox.Show("No olvides seguir practicando...");
        }

        private void btnArchivo_Click(object sender, EventArgs e)
        {
            //Mensaje al hacer el click en el boton Archivo.
            //MessageBox.Show("Hiciste click en archivo");
         
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            //evento al hacer click en el formulario.
            MouseEventArgs click = (MouseEventArgs)e;

            if (click.Button == MouseButtons.Left)
                MessageBox.Show("Presiono el boton izquierdo del Mouse");

            else if (click.Button == MouseButtons.Right)
                MessageBox.Show("Presiono el boton derecho del Mouse");
            else if (click.Button == MouseButtons.Middle)
                MessageBox.Show("Presiono el boton del medio del Mouse");

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //modifica el color de fondo del formulario al hacer click en el boton editar.
            this.BackColor = Color.Blue;
           
        }


        private void btnAyuda_Click(object sender, EventArgs e)
        {
            //si el textBox esta vacio al hacer click rellena de color rojo.
            if (textApellido.Text == "")
                textApellido.BackColor = Color.Red;
            else
                textApellido.BackColor = System.Drawing.SystemColors.Control;
        }


        private void lblTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            //Cambiamos el color de la propiedad BackColor.
            lblTitulo.BackColor = Color.Cyan;


            //Cambiar el estilo del cursor al dispararse los eventos MouseMove. 
            lblTitulo.Cursor = Cursors.Hand;

        }

        private void lblTitulo_MouseLeave(object sender, EventArgs e)
        {
            //.Al dispararse el evento MouseLeave, se restablezca el color de fondo de la etiqueta.
            lblTitulo.BackColor = System.Drawing.SystemColors.Control;



            //Cambiar el estilo del cursor al dispararse los eventos MouseLeave.
            lblTitulo.Cursor = Cursors.Arrow;
        }


        private void textApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }


        private void textNombre_Leave(object sender, EventArgs e)
        {
            //Manejar el evento Leave del nuevo Control TextBox. Para mostrar cuantos
            //caracteres se ingresaron una vez que el control pierde el foco.

            MessageBox.Show("Tiene " + textNombre.Text.Length + " Caracteres");
        }

       
    }
}
