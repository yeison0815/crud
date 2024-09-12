using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;

namespace Datos
{
    public class modFactura
    {

        private Conexion conexion = new Conexion();

        SqlDataReader buffer;

        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        public DataTable Mostrar_SF()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarDetalleFactura";
            comando.CommandType = CommandType.StoredProcedure;
            buffer = comando.ExecuteReader();
            tabla.Load(buffer);
            conexion.CerrarConexion();
            return tabla;

        }
        public DataTable MostrarF()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from DetalleFactura";
            buffer = comando.ExecuteReader();
            tabla.Load(buffer);
            conexion.CerrarConexion();
            return tabla;

        }


        public string getNombreFactura(int IdDE)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select IdFactura from DetalleFactura where IdDetalle = @idD";
            comando.Parameters.AddWithValue("@idD", IdDE);
            SqlDataReader data = comando.ExecuteReader();
            string nombre;
            if (data.Read())
                nombre = data["IdFactura"].ToString();
            else
                nombre = "No encontrado";

            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return (nombre);
        }
        public void Insertar_SF(int Cantidad, double Precio )
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsetarDetalleFactura";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@fecha", Cantidad);
            comando.Parameters.AddWithValue("@cliente", Precio);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void InsertarF(int Cantidad, double precio)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insert into DetalleFactura (Cantidad, PrecioVenta) values (@Cantidad,@Precio);";
            comando.Parameters.AddWithValue("@Cantidad", Cantidad);
            comando.Parameters.AddWithValue("@Precio", precio);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
        public void Editar_SF(int Cantidad, double precio, int idDF)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarDetalleFactura";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@cantidad", Cantidad);
            comando.Parameters.AddWithValue("@Precio", precio);
            comando.Parameters.AddWithValue("@idDF", idDF);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void EditarF(int Cantidad, double precio, int idF)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "update DetalleFactura set  Cantidad=@cantidad, PrecioVenta=@Precio where IdDetalle=@idDF";
            comando.CommandType = CommandType.Text;
            comando.Parameters.AddWithValue("@cantidad", Cantidad);
            comando.Parameters.AddWithValue("@Precio", precio);
            comando.Parameters.AddWithValue("@idDF", idF);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

    
    }
}
