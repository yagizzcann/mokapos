using System.Threading.Tasks;
using MokaPos.Request;
using MokaPos.Response;

namespace MokaPos.Model
{
    public class PoolPayment
    {
        private const string ApproveUrl = "/PaymentDealer/DoApprovePoolPayment";
        private const string UndoUrl = "/PaymentDealer/UndoApprovePoolPayment";


        public static BaseResponse<ApprovePoolPaymentResponse> Approve(ApprovePoolPaymentRequest request)
        {
            return RestHttpClient.Instance.Post<BaseResponse<ApprovePoolPaymentResponse>>(request.BaseUrl + ApproveUrl,
                request.GetHttpHeaders(),
                request);
        }

        public static async Task<BaseResponse<ApprovePoolPaymentResponse>> ApproveAsync(
            ApprovePoolPaymentRequest request)
        {
            return await RestHttpClient.Instance.PostAsync<BaseResponse<ApprovePoolPaymentResponse>>(
                request.BaseUrl + ApproveUrl,
                request.GetHttpHeaders(), request);
        }


        public static BaseResponse<UndoApprovePoolPaymentResponse> UndoApprove(UndoApprovePoolPaymentRequest request)
        {
            return RestHttpClient.Instance.Post<BaseResponse<UndoApprovePoolPaymentResponse>>(request.BaseUrl + UndoUrl,
                request.GetHttpHeaders(),
                request);
        }

        public static async Task<BaseResponse<UndoApprovePoolPaymentResponse>> UndoApproveAsync(
            UndoApprovePoolPaymentRequest request)
        {
            return await RestHttpClient.Instance.PostAsync<BaseResponse<UndoApprovePoolPaymentResponse>>(
                request.BaseUrl + UndoUrl,
                request.GetHttpHeaders(), request);
        }
    }
}