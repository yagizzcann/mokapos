using System.Threading.Tasks;
using MokaPos.Request;
using MokaPos.Response;

namespace MokaPos.Model
{
    public class DirectPayment 
    {
        private const string BasicPaymentUrl =
            "/PaymentDealer/DoDirectPayment";

        public static BaseResponse<DirectPaymentResponse> Create(DirectPaymentRequest request)
        {
            return RestHttpClient.Instance.Post<BaseResponse<DirectPaymentResponse>>(request.BaseUrl + BasicPaymentUrl,
                request.GetHttpHeaders(),
                request);
        }

        public static async Task<BaseResponse<DirectPaymentResponse>> CreateAsync(DirectPaymentRequest request)
        {
            return await RestHttpClient.Instance.PostAsync<BaseResponse<DirectPaymentResponse>>(
                request.BaseUrl + BasicPaymentUrl,
                request.GetHttpHeaders(), request);
        }
    }
}