using crud;
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
    public partial class UsuariosPRIN : Form
    {
        private static UsuariosPRIN instancia = null;
        public static UsuariosPRIN usuario_unico()
        {

            if (instancia == null)
            {
                instancia = new UsuariosPRIN();

                return instancia;
            }
            return instancia;
        }
        public UsuariosPRIN()
        {
            InitializeComponent();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMain frm = frmMain.producto_unico();
            frm.MdiParent = null;
            frm.Show();
            frm.BringToFront();
        }
    }
}
