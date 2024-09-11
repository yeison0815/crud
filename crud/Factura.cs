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


        private void Factura_Load(object sender, EventArgs e)
        {

        }
        private void Adicionar_Click(object sender, EventArgs e)
        {

            //funciona sin base de datos

            CLI_factura.Text = dataGridView_Factura.CurrentRow.Cells["DT_cliente"].Value.ToString();
            MEP_factura.Text = dataGridView_Factura.CurrentRow.Cells["DT_mediopago"].Value.ToString();
            PRO_factura.Text = dataGridView_Factura.CurrentRow.Cells["DT_producto"].Value.ToString();
            CAN_factura.Text = dataGridView_Factura.CurrentRow.Cells["DT_cantidad"].Value.ToString();
            FEC_factura.Text = dataGridView_Factura.CurrentRow.Cells["DT_fecha"].Value.ToString();


        }
    }
}
