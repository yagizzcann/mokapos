namespace MokaPos.Request
{
    public class DirectPaymentRequest : BaseRequest
    {
        public DirectPaymentDealerRequest PaymentDealerRequest { get; set; }
    }
}