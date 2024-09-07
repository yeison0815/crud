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
            ClientecLcs frm = new ClientecLcs();
            frm.Show();
        }

        private void usuariosPrincipalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsuariosPRIN frm = new UsuariosPRIN();  
            frm.Show();
        }
    }
}
