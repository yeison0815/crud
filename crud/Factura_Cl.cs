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
        public Factura_Cl()
        {
            InitializeComponent();
        }

        private void Factura_Load(object sender, EventArgs e)
        {

        }
    }
}
