namespace MokaPos
{
    public sealed class Currency
    {
        private readonly string value;

        public static readonly Currency TL = new Currency("TL");
        public static readonly Currency GBP = new Currency("GBP");
        public static readonly Currency EUR = new Currency("EUR");
        public static readonly Currency USD = new Currency("USD");
       

        private Currency(string value)
        {
            this.value = value;
        }

        public override string ToString()
        {
            return value;
        }
    }
}