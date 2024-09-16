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

        // Método para abrir el formulario del cliente
        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes frm = Clientes.clientes_unico();
            frm.MdiParent = null;
            frm.Show();
            frm.BringToFront();
        }

        // Método para abrir el formulario de usuarios principales (administrador)
        private void usuariosPrincipalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsuariosPRIN frm = UsuariosPRIN.usuario_unico();
            frm.MdiParent = null;
            frm.Show();
            frm.BringToFront();
        }

        // Botón de inicio de sesión
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
                    // Consulta para obtener la contraseña y el rol del usuario
                    string query = "SELECT Contraseña, Rol FROM Usuario WHERE NombreUsuario = @NombreUsuario";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            string contraseñaHasheada = reader["Contraseña"].ToString();
                            string rol = reader["Rol"].ToString();

                            // Verifica la contraseña con el hash
                            if (BCrypt.Net.BCrypt.Verify(contraseña, contraseñaHasheada))
                            {
                                MessageBox.Show("Inicio de sesión exitoso.");

                                // Redirigir según el rol del usuario
                                this.Hide(); // Oculta el formulario actual

                                if (rol == "administrador")
                                {
                                    // Abrir el formulario de administrador
                                    UsuariosPRIN frmAdmin = new UsuariosPRIN();
                                    frmAdmin.FormClosed += (s, args) => this.Show(); // Muestra el formulario actual cuando el otro se cierre
                                    frmAdmin.Show();
                                }
                                else if (rol == "usuario")
                                {
                                    // Abrir el formulario de cliente
                                    Clientes frmCliente = new Clientes();
                                    frmCliente.FormClosed += (s, args) => this.Show(); // Muestra el formulario actual cuando el otro se cierre
                                    frmCliente.Show();
                                }
                                else
                                {
                                    MessageBox.Show("Rol no reconocido.");
                                    this.Show(); // Si hay un error, muestra de nuevo el formulario actual
                                }
                            }
                            else
                            {
                                MessageBox.Show("Usuario o contraseña incorrectos.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Usuario o contraseña incorrectos.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Botón para abrir el formulario de registro
        private void button2_Click(object sender, EventArgs e)
        {
            Registro nuevoFormulario = new Registro();
            nuevoFormulario.Show();
            this.Hide();
        }
    }
}