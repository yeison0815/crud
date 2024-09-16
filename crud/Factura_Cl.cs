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
    public partial class Factura_Cl : Form
    {
        private static Factura_Cl instancia = null;
        public static Factura_Cl factura_unico()
        {

            if (instancia == null)
            {
                instancia = new Factura_Cl();

                return instancia;
            }
            return instancia;
        }  
        private void Factura_Load(object sender, EventArgs e)
        {
            ActualizarFactura();
        }
        private conFactura_Cl Factura = new conFactura_Cl();
        private bool ACTUALIZAR = false;

        private void ActualizarFactura()
        {
            conFactura_Cl objeto = new conFactura_Cl();
            dataGridView_Factura.DataSource = objeto.ActualizarFRod();
        }
        public Factura_Cl()
        {
            InitializeComponent();
        }
        private void actualizar_Click(object sender, EventArgs e)
        {
            //ACTUALIZAR
            if (ACTUALIZAR == false)
            {

                MessageBox.Show("Se actualizo correctamente");
                ActualizarFactura();
            }
        }
    }
}
