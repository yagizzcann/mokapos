using System;
using System.Security.Cryptography;
using System.Text;

namespace MokaPos
{
    public sealed class HashGenerator
    {
        private HashGenerator()
        {
        }

        /// <summary>
        /// https://developer.moka.com/home.php?page=hash_value_hesapla
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string GenerateHash(string key)
        {
            System.Text.Encoding encoding = Encoding.UTF8;
            byte[] plainBytes = encoding.GetBytes(key);
#if NETSTANDARD
            SHA256 algorithm = SHA256.Create();
#else
            SHA256Managed algorithm = new SHA256Managed();
#endif
            string hashedData = String.Empty;
            byte[] hashedBytes = algorithm.ComputeHash(plainBytes, 0, encoding.GetByteCount(key));
            foreach (byte bit in hashedBytes)
            {
                hashedData += bit.ToString("x2");
            }

            return hashedData;
        }
    }
}