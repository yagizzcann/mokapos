using System.Net;
using MokaPos.Model;

namespace MokaPos
{
    public class BaseRequest
    {
       
        public string BaseUrl { get; set; }


        public  WebHeaderCollection GetHttpHeaders()
        {
            WebHeaderCollection headers = new WebHeaderCollection();

#if NETSTANDARD
            headers["Accept"] = "application/json";
#else
            headers.Add("Accept", "application/json");
#endif
            return headers;
        }
    }
}