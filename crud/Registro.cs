using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;

namespace Presentacion
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                // Validar que se haya ingresado un nombre de usuario y una contraseña
                if (string.IsNullOrWhiteSpace(txtNombreUsuario.Text) || string.IsNullOrWhiteSpace(txtContraseña.Text))
                {
                    MessageBox.Show("Por favor ingrese un nombre de usuario y una contraseña.");
                    return;
                }

                string nombreUsuario = txtNombreUsuario.Text;
                string contraseña = txtContraseña.Text;

                // Hashear la contraseña
                string contraseñaHasheada = Hashing.HashearContraseña(contraseña);

                try
                {
                    using (SqlConnection connection = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Inventario;Integrated Security=True;TrustServerCertificate=true;"))
                    {
                        connection.Open();
                        string query = "INSERT INTO Usuario (NombreUsuario, Contraseña, Rol) VALUES (@NombreUsuario, @Contraseña, @Rol)";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            // Asignar los valores para la consulta SQL
                            command.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                            command.Parameters.AddWithValue("@Contraseña", contraseñaHasheada);

                            // Asignar automáticamente el rol "usuario"
                            command.Parameters.AddWithValue("@Rol", "usuario");

                            int result = command.ExecuteNonQuery();

                            // Verificar si se insertó correctamente
                            if (result > 0)
                            {
                                MessageBox.Show("Usuario registrado exitosamente.");
                            }
                            else
                            {
                                MessageBox.Show("Hubo un error al registrar el usuario.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}