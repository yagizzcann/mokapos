namespace MokaPos.Request
{
    public class UndoApprovePoolPayment
    {
        public string VirtualPosOrderId { get; set; }
        public string OtherTrxCode { get; set; }
    }
}