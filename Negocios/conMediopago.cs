using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class conMediopago
    {

        private modMediopago Pago = new modMediopago();
        public DataTable MostrarMRod()
        {
            DataTable tabla = new DataTable();
            tabla = Pago.MostrarM();
            return tabla;
        }
        public void InsertarMRod(string nombreC, string valC)
        {
            Pago.InsertarM(nombreC, valC);
        }
        public void EditarMRod(string nombreC, string valC, string idC)
        {
            Pago.EditarM(nombreC, valC, Convert.ToInt32(idC));
        }
        public void EliminarMRod(string idc)
        {
            Pago.EliminarM(Convert.ToInt32(idc));
        }

        public string getNombreCategorias(int idC)
        {
            return Pago.getNombreMediopago(idC);
        }

    }
}
