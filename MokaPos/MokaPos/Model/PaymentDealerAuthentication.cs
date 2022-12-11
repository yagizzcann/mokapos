using System;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;

namespace MokaPos.Model
{
    public class PaymentDealerAuthentication
    {
        public string DealerCode { get; set; } = string.Empty;
        public string Username { get; set; }= string.Empty;
        public string Password { get; set; }= string.Empty;
        public string CheckKey { get; set; }= string.Empty;


        public  void SetCheckKey()
        {
            string hashKey = this.DealerCode + "MK" + this.Username + "PD" + this.Password;
            System.Text.Encoding encoding = Encoding.UTF8;
            byte[] plainBytes = encoding.GetBytes(hashKey);
#if NETSTANDARD
            SHA256 algorithm = SHA256.Create();
#else
            SHA256Managed algorithm = new SHA256Managed();
#endif
            string hashedData = String.Empty;
            byte[] hashedBytes = algorithm.ComputeHash(plainBytes, 0, encoding.GetByteCount(hashKey));
            foreach (byte bit in hashedBytes)
            {
                hashedData += bit.ToString("x2");
            }
            this.CheckKey= hashedData;
        }
    }
}