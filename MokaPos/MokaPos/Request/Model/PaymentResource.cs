using System.Collections.Generic;
using MokaPos.Model;

namespace MokaPos.Request
{
    public class PaymentResource
    {
        public string CardHolderFullName { get; set; }
        public string CardNumber { get; set; }
        public string ExpMonth { get; set; }
        public string ExpYear { get; set; }
        public string CvcNumber { get; set; }
        public string CardToken { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; }
        public string ClientIP { get; set; }
        
        public int InstallmentNumber { get; set; }
        
        public string OtherTrxCode { get; set; }
        public string SubMerchantName { get; set; }
        public int IsPoolPayment { get; set; }
        public int IsPreAuth { get; set; }
        public int IsTokenized { get; set; }
        public int IntegratorId { get; set; }
        public string Software { get; set; }
        public string Description { get; set; }

        public List<BasketProduct> BasketProduct { get; set; }
    }
}