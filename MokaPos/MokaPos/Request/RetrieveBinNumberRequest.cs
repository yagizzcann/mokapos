namespace MokaPos.Request
{
    public class RetrieveBinNumberRequest : BasePaymentDealerRequest
    {
        public BinNumberRequest BankCardInformationRequest { get; set; }
    }
}