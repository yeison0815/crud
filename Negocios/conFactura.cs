using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class conFactura
    {


        private modFactura DetalleFactura = new modFactura();
        public DataTable MostrarFRod()
        {
            DataTable tabla = new DataTable();
            tabla = DetalleFactura.MostrarF();
            return tabla;
        }
        public void InsertarFRod(string CantidadDF, string precioDF)
        {
            DetalleFactura.InsertarF(Convert.ToInt32(CantidadDF), Convert.ToDouble(precioDF));
        }
        public void EditarFRod(string CantidadDF, string precioDF, string idDF)
        {
            DetalleFactura.EditarF(Convert.ToInt32(CantidadDF),  Convert.ToDouble(precioDF), Convert.ToInt32(idDF));
        }


        public string getNombreFactura(int idDF)
        {
            return DetalleFactura.getNombreFactura(idDF);
        }

    }
}
