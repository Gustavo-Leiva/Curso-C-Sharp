﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace Arquitectura_en_Capas
{
    public partial class frmPokemons : Form
    {
        private List<Pokemon> listaPokemon;

        public frmPokemons()
        {
            InitializeComponent();
        }


        private void frmPokemons_Load(object sender, EventArgs e)
        {


            PokemonNegocio negocio = new PokemonNegocio();
            listaPokemon = negocio.listar();
            dgvPokemons.DataSource = negocio.listar();
            dgvPokemons.Columns["UrlImagen"].Visible= false;
            cargarImagen(listaPokemon[0].UrlImagen);
           

        }


        private void dgvPokemons_SelectionChanged(object sender, EventArgs e)
        {

            Pokemon seleccionado = (Pokemon) dgvPokemons.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.UrlImagen);

        }


        private void cargarImagen(string imagen)
        {

            try
            {
                pbxPokemon.Load(imagen);


            }
            catch (Exception ex)
            {

                pbxPokemon.Load("https://www.shutterstock.com/image-vector/ui-image-placeholder-wireframes-apps-260nw-1037719204.jpg");
            }
        }





        private void dgvPokemons_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
