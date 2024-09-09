using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class conCategorias
    {

        private modCategorias Categorias = new modCategorias();
        public DataTable MostrarCRod()
        {
            DataTable tabla = new DataTable();
            tabla = Categorias.MostrarC();
            return tabla;
        }
        public string getNombre(int id)
        {
            return Categorias.getNombreCategoria(id);
        }

        public int Contar()
        {
            return Categorias.contarCategorias();
        }
    }
}
