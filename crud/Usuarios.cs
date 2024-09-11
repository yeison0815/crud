using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using BCrypt.Net;


namespace Presentacion
{
    public partial class Usuarios : Form
    {

        public Usuarios()
        {
            InitializeComponent();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes frm = Clientes.clientes_unico();
            frm.MdiParent = null;
            frm.Show();
            frm.BringToFront();
        }

        private void usuariosPrincipalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsuariosPRIN frm = UsuariosPRIN.usuario_unico();
            frm.MdiParent = null;
            frm.Show();
            frm.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombreUsuario = textBox1.Text;
            string contraseña = textBox2.Text;

            if (string.IsNullOrWhiteSpace(nombreUsuario) || string.IsNullOrWhiteSpace(contraseña))
            {
                MessageBox.Show("Por favor ingrese un nombre de usuario y una contraseña.");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Inventario;Integrated Security=True;TrustServerCertificate=true;"))
                {
                    connection.Open();
                    string query = "SELECT Contraseña FROM Usuario WHERE NombreUsuario = @NombreUsuario";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            string contraseñaHasheada = reader["Contraseña"].ToString();

                            // Compara la contraseña ingresada con el hash
                            if (BCrypt.Net.BCrypt.Verify(contraseña, contraseñaHasheada))
                            {
                                MessageBox.Show("Inicio de sesión exitoso.");
                                // Aquí puedes redirigir al usuario a la siguiente parte del programa.
                            }
                            else
                            {
                                MessageBox.Show("Contraseña incorrecta.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Usuario no encontrado.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registro nuevoFormulario = new Registro();

            // Muestra el nuevo formulario
            nuevoFormulario.Show();

            // Opcional: Ocultar o cerrar el formulario actual
            this.Hide();
        }
    }
}
