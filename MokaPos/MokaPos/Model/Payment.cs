using System.Threading.Tasks;
using MokaPos.Request;
using MokaPos.Response;

namespace MokaPos.Model
{
    public class Payment 
    {
        private const string GetPaymentDetailUrl =
            "/PaymentDealer/GetDealerPaymentTrxDetailList";

        public static BaseResponse<PaymentDetailResponse> Get(GetPaymentRequest request)
        {
            return RestHttpClient.Instance.Post<BaseResponse<PaymentDetailResponse>>(request.BaseUrl + GetPaymentDetailUrl,
                request.GetHttpHeaders(),
                request);
        }

        public static async Task<BaseResponse<PaymentDetailResponse>> GetAsync(GetPaymentRequest request)
        {
            return await RestHttpClient.Instance.PostAsync<BaseResponse<PaymentDetailResponse>>(
                request.BaseUrl + GetPaymentDetailUrl,
                request.GetHttpHeaders(), request);
        }
    }
}