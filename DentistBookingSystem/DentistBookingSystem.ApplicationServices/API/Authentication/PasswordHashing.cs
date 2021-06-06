using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DentistBookingSystem.ApplicationServices.API.Authentication
{
    public class PasswordHashing
    {
        public string Password { get; set; }
        public string Salt { get; set; }
        public PasswordHashing()
        {

        }
        public PasswordHashing(string password)
        {
            this.Password = password;
        }
        public PasswordHashing(string password, string salt)
        {
            this.Password = password;
            this.Salt = salt;
        }

        public PasswordHashing CreateNewPassword()
        {
            // generate a 128-bit salt using a secure PRNG
            byte[] salt = new byte[128 / 8];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }
            

            // derive a 256-bit subkey (use HMACSHA1 with 10,000 iterations)
            string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: this.Password,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA1,
                iterationCount: 10000,
                numBytesRequested: 256 / 8));
            Console.WriteLine($"Hashed: {hashed}");

             var PasswordAndHash = new PasswordHashing()
            {
                Password = hashed,
                Salt = Convert.ToBase64String(salt)
             };

            return PasswordAndHash;
        }
        public string Login()
        {
            // derive a 256-bit subkey (use HMACSHA1 with 10,000 iterations)
            string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: this.Password,
                salt: Convert.FromBase64String(this.Salt),
                prf: KeyDerivationPrf.HMACSHA1,
                iterationCount: 10000,
                numBytesRequested: 256 / 8));
            return hashed;
        }
    }
}
