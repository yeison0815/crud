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
        public DataTable Mostrar_SC()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarCategoria";
            comando.CommandType = CommandType.StoredProcedure;
            buffer = comando.ExecuteReader();
            tabla.Load(buffer);
            conexion.CerrarConexion();
            return tabla;

        }
        public DataTable MostrarC()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from CategoriaProducto";
            buffer = comando.ExecuteReader();
            tabla.Load(buffer);
            conexion.CerrarConexion();
            return tabla;

        }


        public string getNombreCategoria(int IdCategoria)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select NombreCategoria from CategoriaProducto where IdCategoria = @idC";
            comando.Parameters.AddWithValue("@idC", IdCategoria);
            SqlDataReader data = comando.ExecuteReader();
            string nombre;
            if (data.Read())
                nombre = data["NombreCategoria"].ToString();
            else
                nombre = "No encontrado";

            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return (nombre);
        }
        public void Insertar_SC(string nombreCategoria, string descripC)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsetarCategoria";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@NombreCat", nombreCategoria);
            comando.Parameters.AddWithValue("@descripCategoria", descripC);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void InsertarC(string nombreCategoria, string descripC)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insert into CategoriaProducto (NombreCategoria, Descripcion) values (@NombreCat,@descripCategoria);";
            comando.Parameters.AddWithValue("@NombreCat", nombreCategoria);
            comando.Parameters.AddWithValue("@descripCategoria", descripC);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
        public void Editar_SC(string nombreCategoria, string descripC,int idCategoria)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarCategoria";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@NombreCat", nombreCategoria);
            comando.Parameters.AddWithValue("@descripCategoria", descripC);
            comando.Parameters.AddWithValue("@idC", idCategoria);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void EditarC(string nombreCategoria, string descripC,int idCategoria)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "update CategoriaProducto set NombreCategoria=@NombreCat, Descripcion=@descripCategoria where IdCategoria=@idC";
            comando.CommandType = CommandType.Text;
            comando.Parameters.AddWithValue("@NombreCat", nombreCategoria);
            comando.Parameters.AddWithValue("@descripCategoria", descripC);
            comando.Parameters.AddWithValue("@idC", idCategoria);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
        public void Eliminar_SC(int idCategoria)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarCategoria";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idC", idCategoria);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void EliminarC(int idCategoria)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "delete from CategoriaProducto where IdCategoria=@idCat";
            comando.CommandType = CommandType.Text;
            comando.Parameters.AddWithValue("@idCat", idCategoria);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
    }
}
