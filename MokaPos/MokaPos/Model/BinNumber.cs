using System.Threading.Tasks;
using MokaPos.Request;
using MokaPos.Response;

namespace MokaPos.Model
{
    public class BinNumber
    {
        private const string BinNumberUrl = "/PaymentDealer/GetBankCardInformation";


        public static BaseResponse<BinNumberResponse> Get(RetrieveBinNumberRequest request)
        {
            return RestHttpClient.Instance.Post<BaseResponse<BinNumberResponse>>(request.BaseUrl + BinNumberUrl,
                request.GetHttpHeaders(),
                request);
        }

        public static async Task<BaseResponse<BinNumberResponse>> GetAsync(RetrieveBinNumberRequest request)
        {
            return await RestHttpClient.Instance.PostAsync<BaseResponse<BinNumberResponse>>(
                request.BaseUrl + BinNumberUrl,
                request.GetHttpHeaders(), request);
        }
    }
}