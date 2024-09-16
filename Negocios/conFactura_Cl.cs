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

        private modCategorias Factura = new modCategorias();
        public DataTable ActualizarFRod()
        {
            DataTable tabla = new DataTable();
            tabla = Factura.ActualizarF();
            return tabla;
        }
    }
}
