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
        public Categoria_de_productos()
        {
            InitializeComponent();
        }

        private void Categoria_de_productos_Load(object sender, EventArgs e)
        {

        }
    }
}
