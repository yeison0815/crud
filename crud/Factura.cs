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
            MostrarFactura();
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

        private conFactura factura = new conFactura();
        private string idFactura = null;
        private bool Editar = false;



        private void MostrarFactura()
        {
            conFactura objeto = new conFactura();
            dataGridView_Factura.DataSource = objeto.MostrarFRod();

        }


       
        private void limpiarForm()
        {
            COS_factura.Clear();
        }
        private void Adicionar_Click_1(object sender, EventArgs e)
        {
            if (Editar == false)
            {
                try
                {
                    factura.InsertarFRod(CLI_factura.Text, PRO_factura.Text, CAN_factura.Text, FEC_factura.Text);
                    MessageBox.Show("se inserto correctamente");
                    MostrarFactura();
                    limpiarForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pudo insertar los datos por: " + ex);
                }
            }

            }
    }
}
