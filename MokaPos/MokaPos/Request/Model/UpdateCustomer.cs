namespace MokaPos.Request
{
    public class UpdateCustomer
    {
        public string DealerCustomerId { get; set; }
        public string CustomerCode { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string BirthDate { get; set; }
        public string GsmNumber { get; set; }
        public string Email { get; set; }

    }
}