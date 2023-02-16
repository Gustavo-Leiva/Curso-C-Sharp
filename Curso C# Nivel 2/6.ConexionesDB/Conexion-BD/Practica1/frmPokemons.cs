using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1
{
    public partial class frmPokemons : Form
    {
        public frmPokemons()
        {
            InitializeComponent();
        }

       

        private void frmPokemons_Load(object sender, EventArgs e)
        {
            //aca en el form trabajo con la lectura de base de datos, la voy a invocar..
            PokemonNegocio negocio = new PokemonNegocio();
            dgvPokemons.DataSource = negocio.listar(); // a la grilla de datos le voy a asignar negocio.listar

        }


        private void dgvPokemons_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
