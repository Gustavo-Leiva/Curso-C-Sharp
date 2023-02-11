using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto3
{
    public partial class Formulario3 : Form
    {
        public Formulario3()
        {
            InitializeComponent();
        }

        private void Formulario3_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido al Curso C# Nivel 2...");
            
         
        }

        private void Formulario3_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("No olvides seguir practicando...");
        }

        private void btnArchivo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se disparo el evento del click...");
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void Formulario3_Click(object sender, EventArgs e)
        {
            MouseEventArgs click = (MouseEventArgs)e;

            if (click.Button == MouseButtons.Left)
                MessageBox.Show("Presiono el boton Izquierdo, Atencion");

            else if (click.Button == MouseButtons.Right)
                MessageBox.Show("Presiono el boton Derecho, Atencion");

            if (click.Button == MouseButtons.Middle)
                MessageBox.Show("Presiono el boton del medio, Atencion");

        }

        //11.Cambiar el estilo del cursor al dispararse los eventos MouseMove y MouseLeave.

        private void lblEtiqueta_MouseMove(object sender, MouseEventArgs e)
        {
            //9. Cambiamos el color de la propiedad BackColor.
            lblEtiqueta.BackColor = Color.Salmon;
            lblEtiqueta.Cursor = Cursors.Hand;

        }

        private void lblEtiqueta_MouseLeave(object sender, EventArgs e)
        {
            lblEtiqueta.BackColor = System.Drawing.SystemColors.Control;
            lblEtiqueta.Cursor = Cursors.Arrow;
        }
    }
}
