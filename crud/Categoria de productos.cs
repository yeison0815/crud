using Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Categoria_de_productos : Form
    {

        private static Categoria_de_productos instancia = null;
        public static Categoria_de_productos categoriaPRO_unico()
        {

            if (instancia == null)
            {
                instancia = new Categoria_de_productos();

                return instancia;
            }
            return instancia;
        }

        private conCategorias Categorias = new conCategorias();
        private string idCategoria = null;
        private bool Editar = false;

        private void Categoria_load(object sender, EventArgs e)
        {
            MostrarCategorias();
        }

        private void MostrarCategorias()
        {
            conCategorias objeto = new conCategorias();
            dataGridView_categoria.DataSource = objeto.MostrarCRod();
        }
        public Categoria_de_productos()
        {
            InitializeComponent();
        }

        private void actualizarcategoria_Click(object sender, EventArgs e)
        {
            //ACTUALIZAR
            if (Editar == false)
            {

                MessageBox.Show("se actualizo correctamente");
                MostrarCategorias();
            }


        }


        private void Buscardor_Click(object sender, EventArgs e)
        {
            Resultado.Text = Categorias.getNombre((int)numericUpDown1.Value);
        }

        private void Cortador_Click(object sender, EventArgs e)
        {
            Resultado.Text = Convert.ToString(Categorias.Contar());
        }
    }
}
