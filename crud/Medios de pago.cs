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
    public partial class Medios_de_pago : Form
    {
        private static Medios_de_pago instancia = null;
        public static Medios_de_pago medioPAGO_unico()
        {

            if (instancia == null)
            {
                instancia = new Medios_de_pago();

                return instancia;
            }
            return instancia;
        }
        public Medios_de_pago()
        {
            InitializeComponent();
        }

        private void Medios_de_pago_Load(object sender, EventArgs e)
        {

        }
    }
}
