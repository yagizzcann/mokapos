using System.Threading.Tasks;
using MokaPos.Request;
using MokaPos.Response;

namespace MokaPos.Model
{
    public class Card
    {
        public string CardToken { get; set; }
        public string CardName { get; set; }
        public string BankName { get; set; }
        public string CardNumberFirstSix { get; set; }
        public string CardNumberLastFour { get; set; }
        public string CardHolderFullName { get; set; }
        public string ExpMonth { get; set; }
        public string ExpYear { get; set; }


        private const string CreateUrl = "/DealerCustomer/AddCard";
        private const string UpdateUrl = "/DealerCustomer/UpdateCard";
        private const string GetUrl = "/DealerCustomer/GetCard";
        private const string GetListUrl = "/DealerCustomer/GetCardList";
        private const string RemoveUrl = "/DealerCustomer/RemoveCard";


        public static BaseResponse<CustomerDetailResponse> Create(CreateCardRequest request)
        {
            return RestHttpClient.Instance.Post<BaseResponse<CustomerDetailResponse>>(request.BaseUrl + CreateUrl,
                request.GetHttpHeaders(),
                request);
        }

        public static async Task<BaseResponse<CustomerDetailResponse>> CreateAsync(CreateCardRequest request)
        {
            return await RestHttpClient.Instance.PostAsync<BaseResponse<CustomerDetailResponse>>(
                request.BaseUrl + CreateUrl,
                request.GetHttpHeaders(), request);
        }


        public static BaseResponse<CustomerDetailResponse> Update(UpdateCardRequest request)
        {
            return RestHttpClient.Instance.Post<BaseResponse<CustomerDetailResponse>>(request.BaseUrl + UpdateUrl,
                request.GetHttpHeaders(),
                request);
        }

        public static async Task<BaseResponse<CustomerDetailResponse>> UpdateAsync(UpdateCardRequest request)
        {
            return await RestHttpClient.Instance.PostAsync<BaseResponse<CustomerDetailResponse>>(
                request.BaseUrl + UpdateUrl,
                request.GetHttpHeaders(), request);
        }


        public static BaseResponse<CustomerDetailResponse> Get(GetCardRequest request)
        {
            return RestHttpClient.Instance.Post<BaseResponse<CustomerDetailResponse>>(request.BaseUrl + GetUrl,
                request.GetHttpHeaders(),
                request);
        }

        public static async Task<BaseResponse<CustomerDetailResponse>> GetAsync(GetCardRequest request)
        {
            return await RestHttpClient.Instance.PostAsync<BaseResponse<CustomerDetailResponse>>(
                request.BaseUrl + GetUrl,
                request.GetHttpHeaders(), request);
        }


        public static BaseResponse<CustomerDetailResponse> GetList(RetrieveCardListRequest request)
        {
            return RestHttpClient.Instance.Post<BaseResponse<CustomerDetailResponse>>(request.BaseUrl + GetListUrl,
                request.GetHttpHeaders(),
                request);
        }

        public static async Task<BaseResponse<CustomerDetailResponse>> GetListAsync(RetrieveCardListRequest request)
        {
            return await RestHttpClient.Instance.PostAsync<BaseResponse<CustomerDetailResponse>>(
                request.BaseUrl + GetListUrl,
                request.GetHttpHeaders(), request);
        }
        
        
        
        public static BaseResponse<CustomerDetailResponse> Remove(DeleteCardRequest request)
        {
            return RestHttpClient.Instance.Post<BaseResponse<CustomerDetailResponse>>(request.BaseUrl + RemoveUrl,
                request.GetHttpHeaders(),
                request);
        }

        public static async Task<BaseResponse<CustomerDetailResponse>> RemoveAsync(DeleteCardRequest request)
        {
            return await RestHttpClient.Instance.PostAsync<BaseResponse<CustomerDetailResponse>>(
                request.BaseUrl + RemoveUrl,
                request.GetHttpHeaders(), request);
        }
    }
}