namespace MokaPos.Request
{
    public class CaptureRequest : BasePaymentDealerRequest
    {
        public Capture PaymentDealerRequest { get; set; }
    }
}