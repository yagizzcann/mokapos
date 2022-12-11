namespace MokaPos.Request
{
    public class ApprovePoolPayment
    {
        public string VirtualPosOrderId { get; set; }
        public string OtherTrxCode { get; set; }
    }
}