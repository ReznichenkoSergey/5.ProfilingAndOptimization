using System;
using System.Security.Cryptography;
using System.Text;

namespace GeneratePasswordApp
{
    public class TestClass
    {
        readonly int iterate = 10000;

        public string GeneratePasswordHashUsingSalt(string passwordText, byte[] salt)
        {
            using var pbkdf2 = new Rfc2898DeriveBytes(passwordText, salt, iterate); 

            byte[] hash = pbkdf2.GetBytes(20);

            byte[] hashBytes = new byte[36];

            Array.Copy(salt, 0, hashBytes, 0, 16); 
            Array.Copy(hash, 0, hashBytes, 16, 20);

            return Convert.ToBase64String(hashBytes);
        }
    }
}
