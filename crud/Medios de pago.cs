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
    public partial class Medios_de_pago : Form
    {
        private static Medios_de_pago instancia = null;
        public static Medios_de_pago medioPAGO_unico()
        {

            if (instancia == null)
            {
                instancia = new Medios_de_pago();

                return instancia;
            }
            return instancia;
        }

        private conMediopago Mediopago = new conMediopago();
        private string idMediopago = null;
        private bool Editar = false;

        private void Mediopago_load(object sender, EventArgs e)
        {
            MostrarMediopago();
        }

        private void MostrarMediopago()
        {
            conMediopago objeto = new conMediopago();
            dataGridView_Mediopago.DataSource = objeto.MostrarMRod();
        }
        public Medios_de_pago()
        {
            InitializeComponent();
        }



        private void GuardarMedios_Click(object sender, EventArgs e)
        {
            if (Editar == false)
            {
                try
                {
                    Mediopago.InsertarMRod(Nmediopago.Text, Dmediopago.Text);
                    MessageBox.Show("se inserto correctamente");
                    MostrarMediopago();
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
                    Mediopago.EditarMRod(Nmediopago.Text, Dmediopago.Text, idMediopago);
                    MessageBox.Show("se edito correctamente");
                    MostrarMediopago();
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
            Nmediopago.Clear();
            Dmediopago.Clear();
        }

        private void EditarMedios_Click(object sender, EventArgs e)
        {
            if (dataGridView_Mediopago.SelectedRows.Count > 0)
            {
                Editar = true;
                Nmediopago.Text = dataGridView_Mediopago.CurrentRow.Cells["NombreMediopago"].Value.ToString();
                Dmediopago.Text = dataGridView_Mediopago.CurrentRow.Cells["Descripcion"].Value.ToString();
                idMediopago = dataGridView_Mediopago.CurrentRow.Cells["IdMedioPago"].Value.ToString();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void BorrarMedios_Click(object sender, EventArgs e)
        {
            if (dataGridView_Mediopago.SelectedRows.Count > 0)
            {
                idMediopago = dataGridView_Mediopago.CurrentRow.Cells["IdMediopago"].Value.ToString();
                Mediopago.EliminarMRod(idMediopago);
                MessageBox.Show("Eliminado correctamente");
                MostrarMediopago();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }
    }
}
