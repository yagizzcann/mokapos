using System.Threading.Tasks;
using MokaPos.Request;
using MokaPos.Response;

namespace MokaPos.Model
{
    public class ThreedPayment
    {
        private const string DoDirectPaymentThreeDUrl =
            "/PaymentDealer/DoDirectPaymentThreeD";

        private const string DoDirectMobilePaymentThreeDUrl =
            "/PaymentDealer/DoDirectPaymentThreeDMobile";
        public static BaseResponse<string> Create(ThreeDPaymentRequest request)
        {
            request.PaymentDealerRequest.ReturnHash = 0;
            return RestHttpClient.Instance.Post<BaseResponse<string>>(
                request.BaseUrl + DoDirectPaymentThreeDUrl,
                request.GetHttpHeaders(),
                request);
        }

        public static async Task<BaseResponse<string>> CreateAsync(ThreeDPaymentRequest request)
        {
            request.PaymentDealerRequest.ReturnHash = 0;
            return await RestHttpClient.Instance.PostAsync<BaseResponse<string>>(
                request.BaseUrl + DoDirectPaymentThreeDUrl,
                request.GetHttpHeaders(), request);
        }
        
        public static BaseResponse<string> CreateMobile(ThreeDPaymentMobileRequest request)
        {
            request.PaymentDealerRequest.ReturnHash = 0;
            return RestHttpClient.Instance.Post<BaseResponse<string>>(
                request.BaseUrl + DoDirectMobilePaymentThreeDUrl,
                request.GetHttpHeaders(),
                request);
        }

        public static async Task<BaseResponse<string>> CreateMobileAsync(ThreeDPaymentMobileRequest request)
        {
            request.PaymentDealerRequest.ReturnHash = 0;
            return await RestHttpClient.Instance.PostAsync<BaseResponse<string>>(
                request.BaseUrl + DoDirectMobilePaymentThreeDUrl,
                request.GetHttpHeaders(), request);
        }
        
        
        
        
        public static BaseResponse<ThreedPaymentResponse> CreateWithHash(ThreeDPaymentRequest request)
        {
            request.PaymentDealerRequest.ReturnHash = 1;
            return RestHttpClient.Instance.Post<BaseResponse<ThreedPaymentResponse>>(
                request.BaseUrl + DoDirectPaymentThreeDUrl,
                request.GetHttpHeaders(),
                request);
        }

        public static async Task<BaseResponse<ThreedPaymentResponse>> CreateWithHashAsync(ThreeDPaymentRequest request)
        {
            request.PaymentDealerRequest.ReturnHash = 1;
            return await RestHttpClient.Instance.PostAsync<BaseResponse<ThreedPaymentResponse>>(
                request.BaseUrl + DoDirectPaymentThreeDUrl,
                request.GetHttpHeaders(), request);
        }
        
        public static BaseResponse<ThreedPaymentResponse> CreateWithHashMobile(ThreeDPaymentMobileRequest request)
        {
            request.PaymentDealerRequest.ReturnHash = 1;
            return RestHttpClient.Instance.Post<BaseResponse<ThreedPaymentResponse>>(
                request.BaseUrl + DoDirectMobilePaymentThreeDUrl,
                request.GetHttpHeaders(),
                request);
        }

        public static async Task<BaseResponse<ThreedPaymentResponse>> CreateMobileWithHashAsync(ThreeDPaymentMobileRequest request)
        {
            request.PaymentDealerRequest.ReturnHash = 1;
            return await RestHttpClient.Instance.PostAsync<BaseResponse<ThreedPaymentResponse>>(
                request.BaseUrl + DoDirectMobilePaymentThreeDUrl,
                request.GetHttpHeaders(), request);
        }
        


        /// <summary>
        /// 3d ödeminin başarılı mı başarısız mı olduğunu kontrol eder
        /// </summary>
        /// <param name="codeForHash">3d başlatma sırasında dönülen değer</param>
        /// <param name="hashValue">3d sonucunda gönderilen değer</param>
        /// <returns></returns>
        public static bool CheckHashValue(string codeForHash, string hashValue)
        {
            if (string.IsNullOrWhiteSpace(codeForHash) || string.IsNullOrWhiteSpace(hashValue))
                return false;

            string hashedTrue = HashGenerator.GenerateHash($"{codeForHash.ToUpper()}T");

            if (string.Equals(hashValue, hashedTrue))
                return true;

            return false;
        }
    }
}