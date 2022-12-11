namespace MokaPos.Request
{
    public class CreateIFrameWebPosRequest : BasePaymentDealerRequest
    {
        public WebPosIFrame WebPosRequest { get; set; }
        public bool IsTest { get; set; } = false;
    }
}