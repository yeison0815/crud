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
    }
}
