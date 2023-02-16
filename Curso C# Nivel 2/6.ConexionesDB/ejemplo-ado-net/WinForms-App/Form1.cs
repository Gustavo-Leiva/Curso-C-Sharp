using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_App
{
    public partial class frmPokemons : Form
    {
        //***como mostrar imagenes de la base de datos

       //***
       private List<Pokemon> listaPokemon;  


        public frmPokemons()
        {
            InitializeComponent();
        }

      

        private void frmPokemons_Load(object sender, EventArgs e)
        {
            //aca en el form trabajo con la lectura de base de datos, la voy a invocar..
           
            PokemonNegocio negocio = new PokemonNegocio();
            listaPokemon = negocio.listar(); //***
            dgvPokemons.DataSource = listaPokemon; //***
            cargarImagen(listaPokemon[0].UrlImagen);//*** (esto al ejectuar carga el primer elemento que esta en la grilla).

            //dgvPokemons.DataSource = negocio.listar(); // a la grilla de datos le voy a asignar negocio.listar





        }


        

        private void dgvPokemons_SelectionChanged(object sender, EventArgs e)
        {
            //como mostrar la imagen seleccionada en la grilla.
            Pokemon seleccionado = (Pokemon)dgvPokemons.CurrentRow.DataBoundItem;
            //pbxPokemon.Load(seleccionado.UrlImagen);
            cargarImagen(seleccionado.UrlImagen);

        }



        //metodo privado 
        private void cargarImagen(string imagen)
        {
            try
            {
                pbxPokemon.Load(imagen);

            }
            catch (Exception ex)
            {

                pbxPokemon.Load("https://developers.elementor.com/docs/assets/img/elementor-placeholder-image.png");
            }
        }


        private void dgvPokemons_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
