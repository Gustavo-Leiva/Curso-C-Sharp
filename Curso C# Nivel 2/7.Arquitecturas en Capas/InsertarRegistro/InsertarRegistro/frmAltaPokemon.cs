﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace InsertarRegistro
{
    public partial class frmAltaPokemon : Form
    {
        public frmAltaPokemon()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();//cierra la ventana de cancelar.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Al momento de hacer click tengo que leer los datos.
            Pokemon poke = new Pokemon();
            PokemonNegocio negocio = new PokemonNegocio();
         
           



            try
            {
                //aca tengo mi objeto cargado.
                poke.Numero = int.Parse(txtNumero.Text);
                poke.Nombre = txtNombre.Text;   
                poke.Descripcion= txtDescripcion.Text;

                //para agregar.
                negocio.agregar(poke);
                MessageBox.Show("agregado exitosamente");
                Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString()); //si crayea que muestre el mensaje con error.
            }


        }
    }
}
