using System.Threading.Tasks;
using MokaPos.Request;
using MokaPos.Response;

namespace MokaPos.Model
{
    public class CapturePayment
    {
        private const string PaymentUrl = "/PaymentDealer/DoCapture";


        public static BaseResponse<CaptureResponse> Post(CaptureRequest request)
        {
            return RestHttpClient.Instance.Post<BaseResponse<CaptureResponse>>(request.BaseUrl + PaymentUrl,
                request.GetHttpHeaders(),
                request);
        }

        public static async Task<BaseResponse<CaptureResponse>> PostAsync(CaptureRequest request)
        {
            return await RestHttpClient.Instance.PostAsync<BaseResponse<CaptureResponse>>(
                request.BaseUrl + PaymentUrl,
                request.GetHttpHeaders(), request);
        }
    }
}