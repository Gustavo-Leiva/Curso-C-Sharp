using System;
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

//En este capitulo vemos como insertar un registro en la base de datos.
//Los campos que vamos a dar de alta son: Numero, nombres y Descripcion.

namespace InsertarRegistro
{
    public partial class frmPokemon : Form
    {

        private List<Pokemon> listaPokemon;

        public frmPokemon()
        {
            InitializeComponent();
        }

        private void frmPokemon_Load(object sender, EventArgs e)
        {
            PokemonNegocio negocio = new PokemonNegocio();
            listaPokemon = negocio.listar();
            dgvPokemon.DataSource = negocio.listar();
            dgvPokemon.Columns["UrlImagen"].Visible = false;
            cargarImagen(listaPokemon[0].UrlImagen);

        }

        private void dgvPokemon_SelectionChanged(object sender, EventArgs e)
        {

            Pokemon seleccionado = (Pokemon)dgvPokemon.CurrentRow.DataBoundItem;
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



        //cuando hago un click llamo a este metodo para dar de alta el pokemon.(invoco el frmPokemon)
        private void btnAgregar_Click(object sender, EventArgs e)
        {           

            frmAltaPokemon alta = new frmAltaPokemon();//creo un objeto.
            alta.ShowDialog();//este showDialog no permite salir hasta que termines de trabajar en esa ventaana.

        }
    }
}
