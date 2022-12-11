using System.Threading.Tasks;
using MokaPos.Request;
using MokaPos.Response;

namespace MokaPos.Model
{
    public class Customer
    {
        private const string CreateUrl = "/DealerCustomer/AddCustomer";
        private const string CreateWCardUrl = "/DealerCustomer/AddCustomerWithCard";
        private const string UpdateUrl = "/DealerCustomer/UpdateCustomer";
        private const string GetCustomerUrl = "/DealerCustomer/GetCustomer";
        private const string DeleteCustomerUrl = "/DealerCustomer/RemoveCustomer";


        public static BaseResponse<CustomerDetailResponse> Create(CreateCustomerRequest request)
        {
            return RestHttpClient.Instance.Post<BaseResponse<CustomerDetailResponse>>(request.BaseUrl + CreateUrl,
                request.GetHttpHeaders(),
                request);
        }

        public static async Task<BaseResponse<CustomerDetailResponse>> CreateAsync(CreateCustomerRequest request)
        {
            return await RestHttpClient.Instance.PostAsync<BaseResponse<CustomerDetailResponse>>(
                request.BaseUrl + CreateUrl,
                request.GetHttpHeaders(), request);
        }


        public static BaseResponse<CustomerDetailResponse> Create(CreateCustomerWithCardRequest request)
        {
            return RestHttpClient.Instance.Post<BaseResponse<CustomerDetailResponse>>(request.BaseUrl + CreateWCardUrl,
                request.GetHttpHeaders(),
                request);
        }

        public static async Task<BaseResponse<CustomerDetailResponse>> CreateAsync(
            CreateCustomerWithCardRequest request)
        {
            return await RestHttpClient.Instance.PostAsync<BaseResponse<CustomerDetailResponse>>(
                request.BaseUrl + CreateWCardUrl,
                request.GetHttpHeaders(), request);
        }


        public static BaseResponse<CustomerDetailResponse> Update(UpdateCustomerRequest request)
        {
            return RestHttpClient.Instance.Post<BaseResponse<CustomerDetailResponse>>(request.BaseUrl + UpdateUrl,
                request.GetHttpHeaders(),
                request);
        }

        public static async Task<BaseResponse<CustomerDetailResponse>> UpdateAsync(UpdateCustomerRequest request)
        {
            return await RestHttpClient.Instance.PostAsync<BaseResponse<CustomerDetailResponse>>(
                request.BaseUrl + UpdateUrl,
                request.GetHttpHeaders(), request);
        }


        public static BaseResponse<CustomerDetailResponse> Get(RetrieveCustomerRequest request)
        {
            return RestHttpClient.Instance.Post<BaseResponse<CustomerDetailResponse>>(request.BaseUrl + GetCustomerUrl,
                request.GetHttpHeaders(),
                request);
        }

        public static async Task<BaseResponse<CustomerDetailResponse>> GetAsync(RetrieveCustomerRequest request)
        {
            return await RestHttpClient.Instance.PostAsync<BaseResponse<CustomerDetailResponse>>(
                request.BaseUrl + GetCustomerUrl,
                request.GetHttpHeaders(), request);
        }


        public static BaseResponse<CustomerDetailResponse> Delete(DeleteCustomerRequest request)
        {
            return RestHttpClient.Instance.Post<BaseResponse<CustomerDetailResponse>>(
                request.BaseUrl + DeleteCustomerUrl,
                request.GetHttpHeaders(),
                request);
        }

        public static async Task<BaseResponse<CustomerDetailResponse>> DeleteAsync(DeleteCustomerRequest request)
        {
            return await RestHttpClient.Instance.PostAsync<BaseResponse<CustomerDetailResponse>>(
                request.BaseUrl + DeleteCustomerUrl,
                request.GetHttpHeaders(), request);
        }
    }
}