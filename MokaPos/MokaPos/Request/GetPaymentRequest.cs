namespace MokaPos.Request
{
    public class GetPaymentRequest : BasePaymentDealerRequest
    {
        public PaymentDealerRequest PaymentDealerRequest { get; set; }
    }

    public class PaymentDealerRequest
    {
        public string PaymentId { get; set; }
        public string OtherTrxCode { get; set; }
    }
}