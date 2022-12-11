namespace MokaPos.Model
{
    public class DealerCustomer
    {
        public int DealerCustomerId { get; set; }
        public string CustomerCode { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Gender { get; set; }
        public string BirthDate { get; set; }
        public string GsmNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
    }
}