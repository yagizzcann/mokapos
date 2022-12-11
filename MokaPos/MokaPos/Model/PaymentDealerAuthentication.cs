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
            
            this.CheckKey= HashGenerator.GenerateHash(hashKey);
        }
    }
}