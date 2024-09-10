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
        private modFactura_Cl Facturas = new modFactura_Cl();
        public DataTable MostrarFac_CL()
        {
            DataTable tabla = new DataTable();
            tabla = Facturas.MostrarF_CL();
            return tabla;
        }
        public void InsertarFac_CL(string nombre, string desc, string marca, string precio, string stock)
        {
            Facturas.InsertarF_CL(nombre, desc, marca, Convert.ToDouble(precio), Convert.ToInt32(stock));
        }
        public void EditarFacF_CL(string nombre, string desc, string marca, string precio, string stock, string id)
        {
            Facturas.EditarF_CL(nombre, desc, marca, Convert.ToDouble(precio), Convert.ToInt32(stock), Convert.ToInt32(id));
        }
        public void EliminarFac_CL(string id)
        {
            Facturas.EliminarF_CL(Convert.ToInt32(id));
        }

        public string getNombre(int id)
        {
            return Facturas.getNombreF_CL(id);
        }

        public int Contar()
        {
            return Facturas.contarF_CL();
        }
    }
}
