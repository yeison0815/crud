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

        private void guaradarcategoria_Click(object sender, EventArgs e)
        {
            //INSERTAR
            if (Editar == false)
            {
                try
                {
                    Categorias.InsertarCRod(Ncategoria.Text, Dcategoria.Text);
                    MessageBox.Show("se inserto correctamente");
                    MostrarCategorias();
                    limpiarForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pudo insertar los datos por: " + ex);
                }
            }
            //EDITAR
            if (Editar == true)
            {
                try
                {
                    Categorias.EditarCRod(Ncategoria.Text, Dcategoria.Text, idCategoria);
                    MessageBox.Show("se edito correctamente");
                    MostrarCategorias();
                    limpiarForm();
                    Editar = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pudo editar los datos por: " + ex);
                }
            }
        }
        private void limpiarForm()
        {
            Ncategoria.Clear();
            Dcategoria.Clear();
        }

        private void editatcategoria_Click(object sender, EventArgs e)
        {
            if (dataGridView_categoria.SelectedRows.Count > 0)
            {
                Editar = true;
                Ncategoria.Text = dataGridView_categoria.CurrentRow.Cells["NombreCategoria"].Value.ToString();
                Dcategoria.Text = dataGridView_categoria.CurrentRow.Cells["Descripcion"].Value.ToString();
                idCategoria = dataGridView_categoria.CurrentRow.Cells["IdCategoria"].Value.ToString();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void borrarcategoria_Click(object sender, EventArgs e)
        {
            if(dataGridView_categoria.SelectedRows.Count > 0)
            {
                idCategoria = dataGridView_categoria.CurrentRow.Cells["idCategoria"].Value.ToString();
                Categorias.EliminarCRod(idCategoria);
                MessageBox.Show("Eliminado correctamente");
                MostrarCategorias();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }
    }
}
