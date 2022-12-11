using System.Net;
using MokaPos.Model;

namespace MokaPos
{
    public class BaseDealerCustomerRequest :BaseRequest
    {
        public PaymentDealerAuthentication DealerCustomerAuthentication { get; set; }
       
    }
}