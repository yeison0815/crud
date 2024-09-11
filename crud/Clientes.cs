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
    public partial class Clientes : Form
    {
        private static Clientes instancia = null;
        public static Clientes clientes_unico()
        {

            if (instancia == null)
            {
                instancia = new Clientes();

                return instancia;
            }
            return instancia;
        }
        public Clientes()
        {
            InitializeComponent();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {

        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Categoria_de_productos frm = Categoria_de_productos.categoriaPRO_unico();
            frm.MdiParent = null;
            frm.Show();
            frm.BringToFront();
        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Factura_Cl frm = Factura_Cl.factura_unico();
            frm.MdiParent = null;
            frm.Show();
            frm.BringToFront();
        }
    }
}
