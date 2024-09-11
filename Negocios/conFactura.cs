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


        private modFactura factura = new modFactura();
        public DataTable MostrarFRod()
        {
            DataTable tabla = new DataTable();
            tabla = factura.MostrarF();
            return tabla;
        }
        public void InsertarFRod(string fechaF, string clienteF,string productoF, string cantidadF)
        {
            factura.InsertarF(fechaF, clienteF,productoF,cantidadF);
        }
        public void EditarFRod(string fechaF, string clienteF,string productof, string cantidadf, string idF)
        {
            factura.EditarF(fechaF, clienteF,productof, Convert.ToInt32(cantidadf), Convert.ToInt32(idF));
        }
        public void EliminarFRod(string idc)
        {
            factura.EliminarF(Convert.ToInt32(idc));
        }

        public string getNombreFactura(int idF)
        {
            return factura.getNombreFactura(idF);
        }

    }
}
