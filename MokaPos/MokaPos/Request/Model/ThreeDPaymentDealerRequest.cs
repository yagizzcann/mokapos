using MokaPos.Model;

namespace MokaPos.Request
{
    public class ThreeDPaymentDealerRequest :PaymentResource
    {
       
      
      
        public int ReturnHash { get; set; }
        public string RedirectUrl { get; set; }
        public int RedirectType { get; set; }
        public BuyerInformation BuyerInformation { get; set; }
        public CustomerInformation CustomerInformation { get; set; }
    }
}