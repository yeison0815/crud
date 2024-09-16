using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class conFactura_Cl
    {

        private modFactura_Cl Factura = new modFactura_Cl();
        public DataTable ActualizarFRod()
        {
            DataTable tabla = new DataTable();
            tabla = Factura.ActualizarF();
            return tabla;
        }
    }
}
