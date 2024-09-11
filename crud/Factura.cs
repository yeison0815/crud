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
    }
}
