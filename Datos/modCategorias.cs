using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class modCategorias
    {
        private Conexion conexion = new Conexion();

        SqlDataReader buffer;

        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        public DataTable Actualizar_SC()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarProducto";
            comando.CommandType = CommandType.StoredProcedure;
            buffer = comando.ExecuteReader();
            tabla.Load(buffer);
            conexion.CerrarConexion();
            return tabla;

        }
        public DataTable ActualizarC()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from Producto";
            buffer = comando.ExecuteReader();
            tabla.Load(buffer);
            conexion.CerrarConexion();
            return tabla;

        }
        public Int32 contarCategorias()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select count(*) as cuenta from Producto";
            Int32 cont = (Int32)comando.ExecuteScalar();
            conexion.CerrarConexion();
            return cont;
        }
        public string getNombreCategoria(int IdProducto)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select NombreProducto from Producto where IdProducto = @id";
            comando.Parameters.AddWithValue("@id", IdProducto);
            SqlDataReader data = comando.ExecuteReader();
            string nombre;
            if (data.Read())
                nombre = data["NombreProducto"].ToString();
            else
                nombre = "No encontrado";

            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return (nombre);
        }

    }
}
