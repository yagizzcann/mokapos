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
#if NETSTANDARD
            SHA256 algorithm = SHA256.Create();
#else
            SHA256Managed algorithm = new SHA256Managed();
#endif
            byte[] computeHash = algorithm.ComputeHash(Encoding.UTF8.GetBytes(key));
            return Convert.ToBase64String(computeHash);
        }
    }
}