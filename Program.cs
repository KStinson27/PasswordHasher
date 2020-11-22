using System;
using System.Security.Cryptography;
using System.Text;
using Microsoft.AspNetCore.Identity;


namespace PasswordHash
{
    class Program
    { //Old 
        /*public static byte[] GetHash(string inputString)
        {
            using (HashAlgorithm algorithm = SHA256.Create())
                return algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputString));
        }

        public static string GetHashString(string inputString)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in GetHash(inputString))
                sb.Append(b.ToString("X2"));

            return sb.ToString();
        }*/

        static void Main(string[] args)
        {
            
            //string password;
            //string hashPassword;

            var pH = new PasswordHasher<string>();

            Console.WriteLine(pH.HashPassword(null, "password"));
            Console.ReadLine();

            
          
        }
    }
}
