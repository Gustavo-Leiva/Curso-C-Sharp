using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;
using System.Configuration;
using System.IO;

namespace AgregarDespegables
{
    public partial class frmAltaPokemon : Form
    {
        //ver cap 8 video 1
        //creo un atributo privado = a Null
        private Pokemon pokemon = null;


        //cap 8 video 7
        private OpenFileDialog archivo = null; 


        public frmAltaPokemon()
        {
            InitializeComponent();
        }

        //duplico ver video 8 unidad 1
        public frmAltaPokemon(Pokemon pokemon)
        {
            InitializeComponent();
            this.pokemon = pokemon;
            //this.pokemon es el atributo y pokemon es el valor por parametro.


            //ver video 8 cap 1
            Text = "Modificar Pokemon"; //modifica el texto del cuadro de la imagen.
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
                this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Pokemon poke = new Pokemon(); tengo una variable que se llama pokemon con lo cual no lo necesito mas. ver video 8 cap 1
            PokemonNegocio negocio = new PokemonNegocio();

            try
            {
                if(pokemon == null)
                {

                    pokemon = new Pokemon(); //si llego hasta aca es porque el pokemon esta nulo y lo va a cargar.Video8 cap 1

                }
                pokemon.Numero = int.Parse(txtNumero.Text);
                pokemon.Nombre = txtNombre.Text;
                pokemon.Descripcion = txtDescripcion.Text;

                //explicacion video 7.(hay que mapear la urlImagen
                pokemon.UrlImagen = txtUrlImagen.Text;

                //ahora tengo que capturar el valor de esos desplegables.
                pokemon.Tipo = (Elemento)cboTipo.SelectedItem;//lo casteo a elemento de manera implicita.
                pokemon.Debilidad = (Elemento)cboDebilidad.SelectedItem; //idem punto anterior.


                if(pokemon.Id != 0)
                {
                    negocio.modificar(pokemon);
                    MessageBox.Show("Modificado exitosamente");

                }
                else
                {
                    negocio.agregar(pokemon);
                    MessageBox.Show("Agregado exitosamente");

                }



                //cap 8 video 7
                //guardo imagen si la levanto localmente:

                if(archivo != null && !(txtUrlImagen.Text.ToUpper().Contains("HTTP"))) //si el archivo esta != de null y la url no tiene http estas levantando una imagen local.
                    File.Copy(archivo.FileName, ConfigurationManager.AppSettings["images-folder"] + archivo.SafeFileName);



                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show (ex.ToString());
            }


        }

        private void frmAltaPokemon_Load(object sender, EventArgs e)
        {

            //en el evento Load del formulario cargo los desplegables
            ElementoNegocio elementoNegocio = new ElementoNegocio();

            try
            {
                //con esto cargo la opciones que muestra de la base de datos Elementos.
                cboTipo.DataSource = elementoNegocio.listar();            
                //ver video 8 cap 1 esto cambia si el pokemon es != de Null voy a preseleccionar un valor (*)
                cboTipo.ValueMember = "Id";
                cboTipo.DisplayMember= "Descripcion";

                cboDebilidad.DataSource = elementoNegocio.listar();
                cboDebilidad.ValueMember = "Id";
                cboDebilidad.DisplayMember = "Descripcion";




                //ver video 8 cap 1 
                // precargo con los datos cargados anteriormente en el modificar.
                if( pokemon != null)
                {
                    txtNumero.Text = pokemon.Numero.ToString();
                    txtNombre.Text= pokemon.Nombre;
                    txtDescripcion.Text = pokemon.Descripcion;                   
                    txtUrlImagen.Text = pokemon.UrlImagen;
                    cargarImagen(pokemon.UrlImagen);//ver video 8 cap 1
                    //(*)
                    cboTipo.SelectedValue = pokemon.Tipo.Id; //con esto preselecciona los valores del pokemon que elija
                    cboDebilidad.SelectedValue = pokemon.Debilidad.Id; //idem punto anterior.

                    
                }

            }
                

            
            catch (Exception ex)
            {

                MessageBox.Show (ex.ToString());    
            }

        }

        //explicacion en video 7 

        private void txtUrlImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtUrlImagen.Text);

        }



        //explicacion en video 7 
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


        //cap 8 video 7
        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            //creamos un objeto OpenFileDialog
            //OpenFileDialog archivo = new OpenFileDialog();

            archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg;|png|*.png"; //indica el tipo de archivo a agregar.
            
            
            
            if(archivo.ShowDialog() == DialogResult.OK)
            {
                txtUrlImagen.Text = archivo.FileName; //esto guarda la direccion del archivo.
                cargarImagen(archivo.FileName);//para verlo
            }



            //guardar la imagen en una carpeta.
            //se debe agregar configuracion en App.config
            //se debe agregar System.IO para que reconozca el File.
            //File.Copy(archivo.FileName, ConfigurationManager.AppSettings["images-folder"] + archivo.SafeFileName);

        }
    }
}
