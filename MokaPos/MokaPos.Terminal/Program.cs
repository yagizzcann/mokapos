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
            /*BaseResponse<DirectPaymentResponse> response = DirectPayment.Create(new DirectPaymentRequest()
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
                    OtherTrxCode = "Mütabakat sağlamak için kendi Unique ",
                    IsPoolPayment = 0, // havuz mu
                    IsTokenized = 1, // kart saklama
                    Software = "Edvido",
                    Description = "",
                    IsPreAuth = 0, // ön ödeme mi
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
                        CustomerCode = "123456", //Bu müşterinin, sizin sisteminizdeki Unique ID si.
                        DealerCustomerId =
                            "" //Daha önceden bu müşteri Moka sistemine kaydedilmişse, Moka sistemindeki bu müşterinin Unique ID si.
                    }
                }
            });
            var res = response.Data;


            var res22 = ThreedPayment.CheckHashValue("BA811DF7-EADF-4498-B626-C32E5212367F",
                "f73d6d0d888d21a73fdd1b854dde003e39b5cbc01df8dd09b7e8b4f4691c0064");


            BaseResponse<ThreedPaymentResponse> response2 = ThreedPayment.Create(new ThreeDPaymentRequest()
            {
                BaseUrl = baseUrl,
                PaymentDealerAuthentication = dealerAuth,
                PaymentDealerRequest = new ThreeDPaymentDealerRequest()
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
                    OtherTrxCode = "Mütabakat sağlamak için kendi Unique ",
                    IsPoolPayment = 0, // havuz mu
                    IsTokenized = 1, // kart saklama
                    Software = "Edvido",
                    Description = "",
                    IsPreAuth = 0, // ön ödeme mi
                    CardToken = "",
                    RedirectType =
                        0, //Opsiyonel alandır. Default değeri 0 (sıfır) dır. Ödeme işleminin sonucu servisi çağıran web sitesinde ana sayfaya yönlendirme yapar. IFrame içerisinden bu servis çağrılmışsa ve sonuç IFrame içine redirect yapılsın isteniyorsa, bu alana 1 yazılmalıdır
                    RedirectUrl = "http://localhost:5006/payment/moka/three-d-callback",
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
                        CardName = "benim kartım2" + Guid.NewGuid().ToString(),
                        Email = "yagizzcann@gmail.com",
                        FirstName = "Yagiz",
                        LastName = "Can",
                        CustomerCode = "1234567", //Bu müşterinin, sizin sisteminizdeki Unique ID si.
                        DealerCustomerId =
                            "" //Daha önceden bu müşteri Moka sistemine kaydedilmişse, Moka sistemindeki bu müşterinin Unique ID si.
                    }
                }
            });

            var res2 = response2.Data;*/


            /* BaseResponse<ThreedPaymentResponse> response3 = WebPosPayment.Create(new CreateWebPosRequest()
             {
                 BaseUrl = baseUrl,
                 PaymentDealerAuthentication = dealerAuth,
                 IsTest = true,
                 WebPosRequest = new WebPos()
                 {
                     
                     Currency = Currency.TL.ToString(),
                     Language = "en",
                     ReturnHash = 1,
                     Amount = 0.1m,
                     IsThreeD = 1,
                     InstallmentNumber = 1,
                     OtherTrxCode = "Mütabakat sağlamak için kendi Unique ",
                     IsPoolPayment = 0, // havuz mu
                     IsTokenized = 1, // kart saklama
                     Description = "",
                     IsPreAuth = 0, // ön ödeme mi
                     RedirectType =
                         0, //Opsiyonel alandır. Default değeri 0 (sıfır) dır. Ödeme işleminin sonucu servisi çağıran web sitesinde ana sayfaya yönlendirme yapar. IFrame içerisinden bu servis çağrılmışsa ve sonuç IFrame içine redirect yapılsın isteniyorsa, bu alana 1 yazılmalıdır
                     RedirectUrl = "http://localhost:5006/payment/moka/three-d-callback",
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
                         CardName = "benim kartım2" + Guid.NewGuid().ToString(),
                         Email = "yagizzcann@gmail.com",
                         FirstName = "Yagiz",
                         LastName = "Can",
                         CustomerCode = "12345678", //Bu müşterinin, sizin sisteminizdeki Unique ID si.
                         DealerCustomerId =
                             "" //Daha önceden bu müşteri Moka sistemine kaydedilmişse, Moka sistemindeki bu müşterinin Unique ID si.
                     }
                 }
             });
 
             var res2 = response3.Data;
             */


          /* BaseResponse<CustomerDetailResponse> response3 = Customer.Create(new CreateCustomerRequest()
            {
                BaseUrl = baseUrl,
                DealerCustomerAuthentication = dealerAuth,
                DealerCustomerRequest = new CreateCustomer()
                {
                    Address = "istanbul",
                    BirthDate = "19901218",
                    Email = "yagizzcann@gmail.com",
                    FirstName = "Yagiz",
                    LastName = "Can",
                    Password = "12345",
                    Gender = 1,
                    GsmNumber = "5314580225",
                    CustomerCode="1234567a9"
                    
                    
                }
            });*/
            
            
            
            
           /* BaseResponse<CustomerDetailResponse> response4 = Card.Create(new CreateCardRequest()
            {
                BaseUrl = baseUrl,
                DealerCustomerAuthentication = dealerAuth,
                DealerCustomerRequest = new CreateCard()
                {
                   
                    CardHolderFullName = "Ahmet Yılmazz",
                    CardNumber = "5127541122223332",
                    ExpYear = "2022",
                    ExpMonth = "12",
                     DealerCustomerId = 21554,
                    //CustomerCode="1234567a9",
                    CardName = "my2 test2233"
                    
                }
            });*/
            
            
                
            Console.ReadKey();
        }
    }
}