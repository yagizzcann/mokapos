using MokaPos.Model;

namespace MokaPos.Request
{
    public class DirectPaymentDealerRequest :PaymentResource
    {
    
        public BuyerInformation BuyerInformation { get; set; }
        public CustomerInformation CustomerInformation { get; set; }
    }
}