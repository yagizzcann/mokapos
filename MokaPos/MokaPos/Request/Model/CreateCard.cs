namespace MokaPos.Request
{
    public class CreateCard
    {
        public string DealerCustomerId { get; set; }
        public string CustomerCode { get; set; }
        public string CardHolderFullName { get; set; }
        public string CardNumber { get; set; }
        public string ExpMonth { get; set; }
        public string ExpYear { get; set; }
        public string CardName { get; set; }

    }
}