namespace MokaPos.Request
{
    public class Capture
    {
        public string VirtualPosOrderId { get; set; }
        public string OtherTrxCode { get; set; }
        public double Amount { get; set; }
        public string ClientIP { get; set; }
    }
}