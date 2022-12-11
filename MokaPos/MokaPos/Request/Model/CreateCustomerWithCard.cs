namespace MokaPos.Request
{
    public class CreateCustomerWithCard
    {
        public string CustomerCode { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string BirthDate { get; set; }
        public string GsmNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string CardHolderFullName { get; set; }
        public string CardNumber { get; set; }
        public string ExpMonth { get; set; }
        public string ExpYear { get; set; }
        public string CardName { get; set; }

    }
}