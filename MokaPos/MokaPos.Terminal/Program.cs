using System;
using MokaPos.Model;
using MokaPos.Request;
using MokaPos.Response;

namespace MokaPos.Terminal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string baseUrl = "https://service.refmoka.com";
            string baseUrl2 = "https://service.testmoka.com";

            var dealerAuth = new PaymentDealerAuthentication()
            {
                DealerCode = "",
                Username = "",
                Password = ""
            };
            dealerAuth.SetCheckKey();
            BaseResponse<DirectPaymentResponse> response = DirectPayment.Create(new DirectPaymentRequest()
            {
                BaseUrl = baseUrl,
                PaymentDealerAuthentication = dealerAuth,
                PaymentDealerRequest = new DirectPaymentDealerRequest()
                {
                    CardHolderFullName = "Ahmet Yılmaz",
                    CardNumber = "4715091122223339",
                    ExpYear = "2022",
                    ExpMonth = "12",
                    CvcNumber = "000",
                    Amount = 0.1m,
                    Currency = "TL",
                    InstallmentNumber = 1,
                    ClientIP = "10.10.10.10",
                    OtherTrxCode="Mütabakat sağlamak için kendi Unique ",
                    IsPoolPayment=0,// havuz mu
                    IsTokenized=1,// kart saklama
                    Software="Edvido",
                    Description = "",
                    IsPreAuth=0,// ön ödeme mi
                    BuyerInformation = new BuyerInformation()
                    {
                        BuyerAddress = "istanbul",
                        BuyerEmail = "yagizzcann@gmail.com",
                        BuyerFullName = "Yagiz Can",
                        BuyerGsmNumber = ""
                    },
                    
                    CustomerInformation = new CustomerInformation()
                    {
                        Address = "istanbul",
                        BirthDate = "",
                        CardName = "benim kartım",
                        Email = "yagizzcann@gmail.com",
                        FirstName = "Yagiz",
                        LastName = "Can",
                        CustomerCode="123456",//Bu müşterinin, sizin sisteminizdeki Unique ID si.
                        DealerCustomerId = ""//Daha önceden bu müşteri Moka sistemine kaydedilmişse, Moka sistemindeki bu müşterinin Unique ID si.
                    }
                    
                }
            });



            var res = response.Data;
            Console.ReadKey();
        }
    }
}