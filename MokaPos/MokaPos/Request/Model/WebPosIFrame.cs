using MokaPos.Model;

namespace MokaPos.Request
{
    public class WebPosIFrame
    {
        public decimal Amount { get; set; }
        public string Currency { get; set; }
        public int InstallmentNumber { get; set; }
        public string OtherTrxCode { get; set; }
        public int ClientWebPosTypeId { get; set; }
        public int IsThreeD { get; set; }
        public int IsPoolPayment { get; set; }
        public int IsPreAuth { get; set; }
        public int IsTokenized { get; set; }
        public string Language { get; set; }
        public string SubMerchantName { get; set; }
        public string Description { get; set; }
        public int ReturnHash { get; set; }
        public string RedirectUrl { get; set; }
        public int RedirectType { get; set; } = 1;
        public BuyerInformation BuyerInformation { get; set; }
        public CustomerInformation CustomerInformation { get; set; }
    }
}