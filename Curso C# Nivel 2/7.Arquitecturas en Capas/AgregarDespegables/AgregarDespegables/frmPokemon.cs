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


namespace AgregarDespegables
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
            

            cargar();

            //unid 8 cap 6 carga en la opcion campo 
            cboCampo.Items.Add("Número");
            cboCampo.Items.Add("Nombre");
            cboCampo.Items.Add("Descripcion");


        }


        private void cargar()
        {
            //ver video 6 y video 7 
            // todo este codigo estaba contenido en frmPokemon_Load; en el video 7 lo refactorizamos a otro metdo llamado cargar().

            PokemonNegocio negocio = new PokemonNegocio();
            try
            {
                listaPokemon = negocio.listar();
                dgvPokemon.DataSource = negocio.listar();
                ocultarColumnas();

                //dgvPokemon.Columns["UrlImagen"].Visible = false;                      //esto en el video 8 cap 4 lo ponemos en un metodo
                //dgvPokemon.Columns["Id"].Visible = false;//video 8 cap 1              //esto en el video 8 cap 4 lo ponemos en un metodo


                cargarImagen(listaPokemon[0].UrlImagen);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }



        private void dgvPokemon_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvPokemon.CurrentRow != null)
            {
                Pokemon seleccionado = (Pokemon) dgvPokemon.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.UrlImagen);
            }

        }





        private void cargarImagen (string imagen)
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








        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaPokemon alta = new frmAltaPokemon();
            alta.ShowDialog();

            //actualizo la carga es decir cuando agrego un elemento modifica visualmente la grilla de contenidos.
            cargar(); // se creo este metodo que lo que permite es realizar la carga y actualizacion de grilla (dataGreedView)

        }


        // Unidad 8 - video 1
        private void btnModificar_Click(object sender, EventArgs e)
        {
            //tengo que pasar por parametro el pokemon que voy a modificar.

            Pokemon seleccionado;
            seleccionado = (Pokemon)dgvPokemon.CurrentRow.DataBoundItem; // con esto ya tengo el pokemon seleccionado.

            frmAltaPokemon modificar = new frmAltaPokemon(seleccionado);//tengo pasar por parametro al constructor de la clase
            modificar.ShowDialog();
            cargar();           


        }

        //unidad 8 video 2
        private void btnEliminarFisico_Click(object sender, EventArgs e)
        {

            eliminar();

        }

        private void btnLogico_Click(object sender, EventArgs e)
        {

            eliminar(true);

        }


        //video 8 cap 3
        private void eliminar (bool logico = false)
        {

            PokemonNegocio negocio = new PokemonNegocio();
            Pokemon seleccionado;

            try
            {
                DialogResult respuesta = MessageBox.Show("De verdad querés eliminarlo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);//esto retorna y valor que puedo evaluar.
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Pokemon)dgvPokemon.CurrentRow.DataBoundItem;

                    if (logico)
                        negocio.eliminarLogico(seleccionado.Id);
                    else
                        negocio.eliminar(seleccionado.Id);

                    
                    cargar(); // con el metodo cargar actualizo la grilla

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }




        //video 8 cap 9
        private bool validarFiltro()
        {
            if(cboCampo.SelectedIndex <0) //digo que no esta seleccionado
            {
                MessageBox.Show("por favor seleccione el campo para filtrar");
                return true;
            }


            if(cboCriterio.SelectedIndex <0)
            {
                MessageBox.Show("por favor seleccione el criterio para filtrar");
                return true;

            }


            if (cboCampo.SelectedItem.ToString() == "Número")
            {

                if(string.IsNullOrEmpty(txtFiltradoAvanzado.Text))
                {

                    MessageBox.Show("Debes cargar el filtro para numéricos....");
                    return true;

                }

                if (!(soloNumeros(txtFiltradoAvanzado.Text)))
                {
                    MessageBox.Show("Solo nros para filtrar por un campo númerico....");
                    return true;
                }

            }


            return false;

        }


        private bool soloNumeros(string cadena)
        {
            foreach(char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                    return false;
            }

            return true;

        }
       


        //video 8 cap 4
        private void btnFiltro_Click(object sender, EventArgs e)
        {
            PokemonNegocio negocio = new PokemonNegocio();

            try
            {
                //video 8 cap 9

                if (validarFiltro())
                    return; //me corta la ejecucion del evento y los demas codigos no se ejecutan.



                //capturo los datos seleccionados.
                string campo = cboCampo.SelectedItem.ToString();
                string criterio = cboCriterio.SelectedItem.ToString();
                string filtro = txtFiltradoAvanzado.Text;
                dgvPokemon.DataSource = negocio.filtrar(campo, criterio, filtro);
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

            
            //se movio los codigos de este metodo a al metodo  txtFiltro_KeyPress




        }




        //esto en el video 8 cap 4 lo ponemos en un metodo
        private void ocultarColumnas()
        {

            dgvPokemon.Columns["UrlImagen"].Visible = false;                      
            dgvPokemon.Columns["Id"].Visible = false; 

        }

        //video 8 cap 5 cada vez que tipeamos se hace un filtro automatico
        private void txtFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {


        }


        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {


            List<Pokemon> listaFiltrada;
            string filtro = txtFiltro.Text;

            if (filtro.Length >= 3) //digo que filtre si los caracteres son mayores a 3
            {
                //para que busque por igual 
                //listaFiltrada = listaPokemon.FindAll(x => x.Nombre.ToLower() == filtro.ToLower()); //si el elemento que estoy buscando esta en la lista lo filtra

                //para que busque por coincidencia uso el contains
                listaFiltrada = listaPokemon.FindAll(x => x.Nombre.ToLower().Contains(filtro.ToLower()) || x.Tipo.Descripcion.ToLower().Contains(filtro.ToLower())); //si el elemento que estoy buscando esta en la lista lo filtra


            }

            else
            {
                listaFiltrada = listaPokemon; //si el elemento a buscar esta vacio devuelve toda la lista.
            }


            dgvPokemon.DataSource = null;
            dgvPokemon.DataSource = listaFiltrada;
            ocultarColumnas();
        }

        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboCampo.SelectedItem.ToString(); //guarda el elemento seleccionado

            if(opcion == "Número")
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Mayor a");
                cboCriterio.Items.Add("Menor a");
                cboCriterio.Items.Add("Igual a");

            }

            else
            {

                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Comienza con");
                cboCriterio.Items.Add("Termina con");
                cboCriterio.Items.Add("Contiene");


            }


        }
    }
}
