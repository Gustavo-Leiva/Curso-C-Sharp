using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica2
{
    public partial class frmPokemons : Form
    {

        private List<Pokemon> listaPokemon; //creo esta variable atributo


        public frmPokemons()
        {
            InitializeComponent();
        }

        private void frmPokemons_Load(object sender, EventArgs e)
        {
            PokemonNegocio negocio = new PokemonNegocio();  
            listaPokemon = negocio.listar(); //cuando abre la aplicacion los listas
            dgvPokemons.DataSource = listaPokemon;//cargo la grilla
            pbxPokemon.Load(listaPokemon[0].UrlImagen); //aca cargo una imagen

            
        }

        private void dgvPokemons_SelectionChanged(object sender, EventArgs e)
        {
            Pokemon seleccionado = (Pokemon) dgvPokemons.CurrentRow.DataBoundItem; //indica la fila inicial.
            cargarImagen(seleccionado.UrlImagen);
            //pbxPokemon.Load(seleccionado.UrlImagen);//cada vez que haga un click cambia la imagen.


        }

        //atrapo el error porque elimine una imagen de la base de datos

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
    }
}
