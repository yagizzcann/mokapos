using System.Collections.Generic;
using MokaPos.Model;

namespace MokaPos.Response
{
    public class CustomerDetailResponse
    {
        public DealerCustomer DealerCustomer { get; set; }
        public int CardListCount { get; set; }
        public List<Card> CardList { get; set; }
    }
}