using System.Threading.Tasks;
using MokaPos.Request;
using MokaPos.Response;

namespace MokaPos.Model
{
    
    public class ThreedPayment 
    {
        private const string DoDirectPaymentThreeDUrl =
            "/PaymentDealer/DoDirectPaymentThreeD";

        public static BaseResponse<ThreedPaymentResponse> Create(ThreeDPaymentRequest request)
        {
            return RestHttpClient.Instance.Post<BaseResponse<ThreedPaymentResponse>>(request.BaseUrl + DoDirectPaymentThreeDUrl,
                request.GetHttpHeaders(),
                request);
        }

        public static async Task<BaseResponse<ThreedPaymentResponse>> CreateAsync(ThreeDPaymentRequest request)
        {
            return await RestHttpClient.Instance.PostAsync<BaseResponse<ThreedPaymentResponse>>(
                request.BaseUrl + DoDirectPaymentThreeDUrl,
                request.GetHttpHeaders(), request);
        }
    }
}