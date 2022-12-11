namespace MokaPos.Request
{
    public class CreateCustomer
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

    }
}