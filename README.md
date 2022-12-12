# MokaPos Client Library for .Net Framework and .Net Core

Unofficial MokaPos client library

Supports .NET Framework, .NET Core 1.1, .NET Core 2.0, .NET Core 2.1, .NET Core 3.0, .NET Core 3.1, .NET Core 5.0, .NET Core 6.0, .NET Core 7.0 runtimes

## Installation

To install MokaPos, run the following command in the Package Manager Console

```
Install-Package MokaPos
```

# Usage

```csharp

string baseUrl = "";

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
                       CardHolderFullName = "Ahmet Y",
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
                           BuyerEmail = "y@gmail.com",
                           BuyerFullName = "Yagiz Can",
                           BuyerGsmNumber = ""
                       },

                       CustomerInformation = new CustomerInformation()
                       {
                           Address = "istanbul",
                           BirthDate = "",
                           CardName = "benim kartım",
                           Email = "y@gmail.com",
                           FirstName = "Yagiz",
                           LastName = "Can",
                           CustomerCode="123456",//Bu müşterinin, sizin sisteminizdeki Unique ID si.
                           DealerCustomerId = 0//Daha önceden bu müşteri Moka sistemine kaydedilmişse, Moka sistemindeki bu müşterinin Unique ID si.
                       }

                   }
               });






    BaseResponse<ThreedPaymentResponse> responseThreeD = ThreedPayment.Create(new ThreeDPaymentRequest()
            {
                BaseUrl = baseUrl,
                PaymentDealerAuthentication = dealerAuth,
                PaymentDealerRequest = new ThreeDPaymentDealerRequest()
                {
                    CardHolderFullName = "Ahmet Y",
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
                    RedirectUrl = "",
                    BuyerInformation = new BuyerInformation()
                    {
                        BuyerAddress = "istanbul",
                        BuyerEmail = "yy@gmail.com",
                        BuyerFullName = "Yagiz Can",
                        BuyerGsmNumber = ""
                    },

                    CustomerInformation = new CustomerInformation()
                    {
                        Address = "istanbul",
                        BirthDate = "",
                        CardName = "benim kartım" ,
                        Email = "yy@gmail.com",
                        FirstName = "Yagiz",
                        LastName = "Can",
                        CustomerCode = "1234567", //Bu müşterinin, sizin sisteminizdeki Unique ID si.
                        DealerCustomerId =0 //Daha önceden bu müşteri Moka sistemine kaydedilmişse, Moka sistemindeki bu müşterinin Unique ID si.
                    }
                }
            });

	// To check threed payment is success
			ThreedPayment.CheckHashValue("BA811DF7-EADF-4498-B626-C32E5212367F",
                "f73d6d0d888d21a73fdd1b854dde003e39b5cbc01df8dd09b7e8b4f4691c0064");
		

BaseResponse<CustomerDetailResponse> response = Customer.Create(new CreateCustomerRequest()
            {
                BaseUrl = baseUrl,
                DealerCustomerAuthentication = dealerAuth,
                DealerCustomerRequest = new CreateCustomer()
                {
                    Address = "istanbul",
                    BirthDate = "19950918",
                    Email = "yagizzcann@gmail.com",
                    FirstName = "Yagiz",
                    LastName = "Can",
                    Password = "12345",
                    Gender = 1,
                    GsmNumber = "5314580225",
                    CustomerCode="1234567"
                    
                    
                }
            });
		
BaseResponse<CustomerDetailResponse> response4 = Card.Create(new CreateCardRequest()
            {
                BaseUrl = baseUrl,
                DealerCustomerAuthentication = dealerAuth,
                DealerCustomerRequest = new CreateCard()
                {
                   
                    CardHolderFullName = "Ahmet Yılmazz",
                    CardNumber = "5127541122223332",
                    ExpYear = "2022",
                    ExpMonth = "12",
                    CustomerCode="1234567a9",
                    CardName = "my card"
                    
                }
            });
		
		
Test Cards
		
Kart Numarası	          SKT	CVC	Banka Adı	Kart Tipi
5127 5411 2222 3332	12/2022	000	Akbank	Master
4531 4411 2222 3338	12/2022	000	Aktif Bank	Visa
4230 0211 2222 3332	12/2022	000	Albaraka	Visa
5126 1811 2222 3338	12/2022	000	Alternatif Bank	Master
4258 4611 2222 3337	12/2022	000	Anadolu Bank	Visa
5482 0211 2222 3334	12/2022	000	Burgan Bank	Master
4715 0911 2222 3339	12/2022	000	Citi Bank	Visa
5120 1711 2222 3335	12/2022	000	Deniz Bank	Master
4234 9511 2222 3336	12/2022	000	Fibabanka	Visa
4022 7711 2222 3334	12/2022	000	Finansbank	Visa
5269 1111 2222 3332	12/2022	000	Finansbank	Master
5269 5511 2222 3339	12/2022	000	Garanti Bankası	Master
4155 1411 2222 3339	12/2022	000	Halkbank	Visa
5100 0511 2222 3333	12/2022	000	HSBC Bankası	Master
4137 2911 2222 3335	12/2022	000	ICBC	Visa
5101 5111 2222 3335	12/2022	000	ING Bankası	Master
4397 4811 2222 3337	12/2022	000	ININAL	Visa
5406 6811 2222 3338	12/2022	000	Iş Bankası	Master
4183 4411 2222 3339	12/2022	000	Iş Bankası	Visa
5125 9511 2222 3335	12/2022	000	Kuveyt Türk	Master
4691 8011 2222 3339	12/2022	000	Odeabank	Visa
5313 8911 2222 3335	12/2022	000	Papara	Master
4349 1311 2222 3337	12/2022	000	PTT Bank	Visa
5100 1011 2222 3336	12/2022	000	Şekerbank	Master
4024 5911 2222 3334	12/2022	000	TEB	Visa
4347 2711 2222 3333	12/2022	000	Turkcell	Visa
5185 9911 2222 3338	12/2022	000	Turkishbank	Master
4007 4211 2222 3335	12/2022	000	Türkiye Finans	Visa
5313 2511 2222 3332	12/2022	000	Türkpara	Master
4029 4011 2222 3331	12/2022	000	Vakıfbank	Visa
5353 5511 2222 3336	12/2022	000	Vakıf Katılım	Master
4462 1211 2222 3339	12/2022	000	Yapıkredi	Visa
5136 6211 2222 3331	12/2022	000	Ziraat Bankası	Master
4162 8311 2222 3336	12/2022	000	Ziraat Katılım	Visa
```


