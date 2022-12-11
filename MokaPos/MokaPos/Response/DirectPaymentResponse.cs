namespace MokaPos.Response
{
    public class DirectPaymentResponse
    {
        public bool IsSuccessful { get; set; }
        public string ResultCode { get; set; }
        public string ResultMessage { get; set; }
        public string VirtualPosOrderId { get; set; }
    }
}