using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica3
{
    public partial class frmPokemon : Form
    {

        private List<Pokemon> listaPokemon; //creo esta variable atributo


        public frmPokemon()
        {
            InitializeComponent();
        }

        private void frmPokemon_Load(object sender, EventArgs e)
        {
          PokemonNegocio negocio = new PokemonNegocio();
          listaPokemon = negocio.listar();
          dgvPokemon.DataSource = negocio.listar();
          dgvPokemon.Columns["UrlImagen"].Visible = false;//oculta la columna de UrlImagen.
          cargarImagen(listaPokemon[0].UrlImagen);

        }

        private void dgvPokemon_SelectionChanged(object sender, EventArgs e)
        {
            Pokemon seleccionado = (Pokemon) dgvPokemon.CurrentRow.DataBoundItem;
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
    }
}
