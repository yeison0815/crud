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
            comando.CommandText = "MostrarMediopago";
            comando.CommandType = CommandType.StoredProcedure;
            buffer = comando.ExecuteReader();
            tabla.Load(buffer);
            conexion.CerrarConexion();
            return tabla;

        }
        public DataTable MostrarF()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from Factura";
            buffer = comando.ExecuteReader();
            tabla.Load(buffer);
            conexion.CerrarConexion();
            return tabla;

        }


        public string getNombreFactura(int IdFac)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select Cliente from Factura where IdFactura = @idF";
            comando.Parameters.AddWithValue("@idF", IdFac);
            SqlDataReader data = comando.ExecuteReader();
            string nombre;
            if (data.Read())
                nombre = data["Cliente"].ToString();
            else
                nombre = "No encontrado";

            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return (nombre);
        }
        public void Insertar_SF(string fecha, string cliente, string producto, int cantidad )
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsetarMediopago";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@fecha", fecha);
            comando.Parameters.AddWithValue("@cliente", cliente);
            comando.Parameters.AddWithValue("@prodcuto", producto);
            comando.Parameters.AddWithValue("@cantidad", cantidad);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void InsertarF(string fecha, string cliente, string producto, string cantidad)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insert into Factura (Fecha, Cliente, Producto, Cantidad) values (@fecha,@cliente,@prodcuto,@cantidad);";
            comando.Parameters.AddWithValue("@Nfecha", fecha);
            comando.Parameters.AddWithValue("@cliente", cliente);
            comando.Parameters.AddWithValue("@producto", producto);
            comando.Parameters.AddWithValue("@cantidad", cantidad);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
        public void Editar_SF(string fecha, string cliente, string producto, int cantidad, int idF)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarFactura";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@fecha", fecha);
            comando.Parameters.AddWithValue("@valorMediopago", cliente);
            comando.Parameters.AddWithValue("@cliente", producto);
            comando.Parameters.AddWithValue("@cliente", cantidad);
            comando.Parameters.AddWithValue("@idF", idF);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void EditarF(string fecha, string cliente, string producto, int cantidad, int idF)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "update Mediopago set Fecha=@fecha, Cliente=@cliente, Producto=@producto, Cantidad=@cantidad where IdFactura=@idF";
            comando.CommandType = CommandType.Text;
            comando.Parameters.AddWithValue("@fecha", fecha);
            comando.Parameters.AddWithValue("@producto", producto);
            comando.Parameters.AddWithValue("@cantidad", cantidad);
            comando.Parameters.AddWithValue("@cliente", cliente);
            comando.Parameters.AddWithValue("@idF", idF);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
        public void Eliminar_SF(int idfa)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarFactura";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idF", idfa);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void EliminarF(int idfa)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "delete from Factura where IdFactura=@idF";
            comando.CommandType = CommandType.Text;
            comando.Parameters.AddWithValue("@idF", idfa);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
    
    }
}
