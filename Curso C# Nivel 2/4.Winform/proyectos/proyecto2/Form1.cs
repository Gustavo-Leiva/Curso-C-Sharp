using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace proyecto2
{
    public partial class Formulario2 : Form
    {
        public Formulario2()
        {
            InitializeComponent();
        }

        private void Formulario2_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido a C#...");
            
                    
        }

        private void Formulario2_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("No olvides seguir practicando...");
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Se disparo el evento Click, Atencion");
            this.BackColor = Color.Blue;
        }

        private void Formulario2_Click(object sender, EventArgs e)
        {
            MouseEventArgs click = (MouseEventArgs)e;

            if (click.Button == MouseButtons.Left)
                MessageBox.Show("Presiono el boton Izquierdo, Atencion");

            else if (click.Button == MouseButtons.Right)
                MessageBox.Show("Presiono el boton Derecho, Atencion");
            if (click.Button == MouseButtons.Middle)
                MessageBox.Show("Presiono el boton del medio, Atencion");
        }

       
       
    }
}
