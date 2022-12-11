namespace MokaPos.Request
{
    public class RetrieveBinNumberRequest : BaseRequest
    {
        public BinNumberRequest BankCardInformationRequest { get; set; }
    }
}