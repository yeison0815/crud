using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class modMediopago
    {
        private Conexion conexion = new Conexion();

        SqlDataReader buffer;

        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        public DataTable Mostrar_SM()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarMediopago";
            comando.CommandType = CommandType.StoredProcedure;
            buffer = comando.ExecuteReader();
            tabla.Load(buffer);
            conexion.CerrarConexion();
            return tabla;

        }
        public DataTable MostrarM()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from Mediopago";
            buffer = comando.ExecuteReader();
            tabla.Load(buffer);
            conexion.CerrarConexion();
            return tabla;

        }


        public string getNombreMediopago(int IdMediopago)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select NombreMediopago from Mediopago where IdMediopago = @idM";
            comando.Parameters.AddWithValue("@idM", IdMediopago);
            SqlDataReader data = comando.ExecuteReader();
            string nombre;
            if (data.Read())
                nombre = data["NombreMediopago"].ToString();
            else
                nombre = "No encontrado";

            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return (nombre);
        }
        public void Insertar_SM(string nombreMediopago, string descripM)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsetarMediopago";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@NombreMed", nombreMediopago);
            comando.Parameters.AddWithValue("@descripMediopago", descripM);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void InsertarM(string nombreMediopago, string descripM)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insert into Mediopago (NombreMediopago, Descripcion) values (@NombreMed,@descripMediopago);";
            comando.Parameters.AddWithValue("@NombreMed", nombreMediopago);
            comando.Parameters.AddWithValue("@descripMediopago", descripM);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
        public void Editar_SM(string nombreMediopago, string descripM, int idMediopago)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarMediopago";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@NombreMed", nombreMediopago);
            comando.Parameters.AddWithValue("@descripMediopago", descripM);
            comando.Parameters.AddWithValue("@idM", idMediopago);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void EditarM(string nombreMediopago, string descripM, int idMediopago)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "update Mediopago set NombreMediopago=@NombreMed, Descripcion=@descripMediopago where IdMediopago=@idM";
            comando.CommandType = CommandType.Text;
            comando.Parameters.AddWithValue("@NombreMed", nombreMediopago);
            comando.Parameters.AddWithValue("@descripMediopago", descripM);
            comando.Parameters.AddWithValue("@idM", idMediopago);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
        public void Eliminar_SM(int idMediopago)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarMediopago";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idM", idMediopago);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void EliminarM(int idMediopago)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "delete from Mediopago where IdMediopago=@idMed";
            comando.CommandType = CommandType.Text;
            comando.Parameters.AddWithValue("@idMed", idMediopago);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
    }
}
