using System.Net;
using MokaPos.Model;

namespace MokaPos
{
    public class BasePaymentDealerRequest : BaseRequest
    {
        public PaymentDealerAuthentication PaymentDealerAuthentication { get; set; }
       
    }
}