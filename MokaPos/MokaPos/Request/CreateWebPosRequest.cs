namespace MokaPos.Request
{
    public class CreateWebPosRequest : BasePaymentDealerRequest
    {
        public WebPos WebPosRequest { get; set; }
        public bool IsTest { get; set; } = false;
    }
}