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
    public partial class Factura : Form
    {


        public Factura()
        {

            InitializeComponent();


        }
        private static Factura instancia = null;

        public static Factura factura_AD_unico()
        {

            if (instancia == null)
            {
                instancia = new Factura();

                return instancia;
            }
            return instancia;
        }

        private conFactura detallefactura = new conFactura();
        private string idDetalleFactura = null;
        private bool Editar = false;




        private void MostrarFactura()
        {
            conFactura objeto = new conFactura();
            dataGridView_Factura.DataSource = objeto.MostrarFRod();

        }



        private void limpiarForm()
        {

            CAN_factura.Text = "";
            COS_factura.Clear();

        }
        private void Adicionar_Click_1(object sender, EventArgs e)
        {



            if (Editar == false)
            {
                try
                {
                    detallefactura.InsertarFRod(CAN_factura.Text, COS_factura.Text);
                    MessageBox.Show("se inserto correctamente");
                    MostrarFactura();
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
                    detallefactura.EditarFRod(CAN_factura.Text, COS_factura.Text, idDetalleFactura);
                    MessageBox.Show("se edito correctamente");
                    MostrarFactura();
                    limpiarForm();
                    Editar = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pudo editar los datos por: " + ex);
                }

            }

        }

        private void Factura_Load(object sender, EventArgs e)
        {
            MostrarFactura();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (dataGridView_Factura.SelectedRows.Count > 0)
            {
                Editar = true;
                CAN_factura.Text = dataGridView_Factura.CurrentRow.Cells["Cantidad"].Value.ToString();
                COS_factura.Text = dataGridView_Factura.CurrentRow.Cells["PrecioVenta"].Value.ToString();
                idDetalleFactura = dataGridView_Factura.CurrentRow.Cells["IdDetalle"].Value.ToString();
            }
            else
                MessageBox.Show("seleccione una fila por favor");

        }


        private void button2_Click(object sender, EventArgs e)
        {

            double total = 0;

            foreach (DataGridViewRow row in dataGridView_Factura.Rows)
            {

                total += Convert.ToDouble(row.Cells["PrecioVenta"].Value);


            }

            TO_factura.Text = "$"+Convert.ToString(total);

        }
    }
}
