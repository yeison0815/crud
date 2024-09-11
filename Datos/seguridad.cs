using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;


namespace WinFormsApp1
{
    public static class Hashing
    {
        public static string HashearContraseña(string contraseña)
        {
            // Hashea la contraseña usando BCrypt con un factor de trabajo de 12
            return BCrypt.Net.BCrypt.HashPassword(contraseña, 12);
        }

        public static bool VerificarContraseña(string contraseña, string hash)
        {
            // Verifica si la contraseña coincide con el hash
            return BCrypt.Net.BCrypt.Verify(contraseña, hash);
        }
    }
}
