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
    public partial class Usuarios : Form
    {

        public Usuarios()
        {
            InitializeComponent();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes frm = Clientes.clientes_unico();
            frm.MdiParent = this;
            frm.Show();
            frm.BringToFront();
        }

        private void usuariosPrincipalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsuariosPRIN frm = UsuariosPRIN.usuario_unico();
            frm.MdiParent = this;
            frm.Show();
            frm.BringToFront();
        }

        private void categoriasDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Categoria_de_productos frm = Categoria_de_productos.categoriaPRO_unico();
            frm.MdiParent = this;
            frm.Show();
            frm.BringToFront();
        }

        private void mediosDePagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Medios_de_pago frm = Medios_de_pago.medioPAGO_unico();
            frm.MdiParent = this;
            frm.Show();
            frm.BringToFront();
        }
    }
}
