using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    internal class conCategorias
    {

        private modCategorias Categorias = new modCategorias();
        public DataTable MostrarCRod()
        {
            DataTable tabla = new DataTable();
            tabla = Categorias.MostrarC();
            return tabla;
        }
        public void InsertarCRod(string nombreC, string descC)
        {
            Categorias.InsertarC(nombreC, descC);
        }
        public void EditarCRod(string nombreC, string descC,string idC)
        {
            Categorias.EditarC(nombreC, descC, Convert.ToInt32(idC));
        }
        public void EliminarCRod(string id)
        {
            Categorias.EliminarC(Convert.ToInt32(id));
        }

        public string getNombreCategorias(int idC)
        {
            return Categorias.getNombreCategoria(idC);
        }


    }
}
