using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo2
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void perfilPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //navegar a otra ventana.

            Form1 ventana = new Form1(); //creo una instancia 

            //puedo usar .Show o .ShowDialog

            //.Show muestra tantas ventanas como las veces que hagas click
            //ventana.Show(); // muestro la ventana.

            //.ShowDialog muestra una unica ventana no permite seguir hasta que la cierre.
            ventana.ShowDialog(); 
        }

        private void tsbPerfilPersona_Click(object sender, EventArgs e)
        {
            Form1 ventana = new Form1();
            ventana.ShowDialog();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
