using System.Threading.Tasks;
using MokaPos.Request;
using MokaPos.Response;

namespace MokaPos.Model
{
    public class WebPosPayment
    {
        private const string Url = "https://clientwebpos.moka.com/Api/WebPos/CreateWebPosRequest";
        private const string TestUrl = "https://clientwebpos.refmoka.com/Api/WebPos/CreateWebPosRequest";


        public static BaseResponse<ThreedPaymentResponse> Create(CreateWebPosRequest request)
        {
            return RestHttpClient.Instance.Post<BaseResponse<ThreedPaymentResponse>>(request.IsTest ? TestUrl : Url,
                request.GetHttpHeaders(),
                request);
        }

        public static async Task<BaseResponse<ThreedPaymentResponse>> CreateAsync(CreateWebPosRequest request)
        {
            return await RestHttpClient.Instance.PostAsync<BaseResponse<ThreedPaymentResponse>>(
                request.IsTest ? TestUrl : Url,
                request.GetHttpHeaders(), request);
        }


        public static BaseResponse<ThreedPaymentResponse> IFrameCreate(CreateIFrameWebPosRequest request)
        {
            return RestHttpClient.Instance.Post<BaseResponse<ThreedPaymentResponse>>(request.IsTest ? TestUrl : Url,
                request.GetHttpHeaders(),
                request);
        }

        public static async Task<BaseResponse<ThreedPaymentResponse>> IFrameCreateAsync(
            CreateIFrameWebPosRequest request)
        {
            return await RestHttpClient.Instance.PostAsync<BaseResponse<ThreedPaymentResponse>>(
                request.IsTest ? TestUrl : Url,
                request.GetHttpHeaders(), request);
        }
    }
}