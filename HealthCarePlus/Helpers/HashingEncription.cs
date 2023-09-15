using System;
using System.Security.Cryptography;
using System.Text;

namespace HealthCarePlus.Helpers
{
    internal class HashingEncription
    {
        public static string getPasswordHash(string password)
        {
            using(SHA1Managed sha1 = new SHA1Managed())
            {
                byte[] textBytes = Encoding.UTF8.GetBytes(password);
                byte[] hashingBytes = sha1.ComputeHash(textBytes);

                StringBuilder stringBuilder = new StringBuilder();
                foreach (byte item in hashingBytes)
                {
                   stringBuilder.Append(item.ToString("x2"));
                }
                return stringBuilder.ToString();
            }
        }
    }
}
