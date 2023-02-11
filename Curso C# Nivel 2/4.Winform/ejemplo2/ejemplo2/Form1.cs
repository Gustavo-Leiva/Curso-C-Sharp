using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string eleme = txtNombre.Text;
            lwElementos.Items.Add(eleme);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboColorFavorito.Items.Add("Rojo");
            cboColorFavorito.Items.Add("Azul");
            cboColorFavorito.Items.Add("Amarillo");
            cboColorFavorito.Items.Add("Negro");
            cboColorFavorito.Items.Add("Blanco");


        }

        private void lblFecha_Click(object sender, EventArgs e)
        {

        }

        private void lblNumero_Click(object sender, EventArgs e)
        {

        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            DateTime fecha = dtpFechaNacimiento.Value;
            //operador ternario (es un if en una sola linea)
            string chocolate = cbxChocolate.Checked == true ? "Le gusta el chocolate" : "odia el chocolate";
            string tipo;
            if (rbtMuggle.Checked)
                tipo = "Muggle";

            else if (rbtWizzard.Checked)
                tipo = "Wizard";

            else
                tipo = "Squibs";

            string colorFavorito = cboColorFavorito.SelectedItem.ToString();
            string numeroFavorito = numFavorito.Value.ToString();

            string mensaje = chocolate + ", es " + tipo + ", su color es " + colorFavorito + ", su numero es " + numeroFavorito;
            MessageBox.Show("Nombre: " + nombre + " fecha: " + fecha + "," + mensaje);


        }
    }
}
