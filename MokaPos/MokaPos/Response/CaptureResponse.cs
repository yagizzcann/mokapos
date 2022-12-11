namespace MokaPos.Response
{
    public class CaptureResponse
    {
        public bool IsSuccessful { get; set; }
        public string ResultCode { get; set; }
        public string ResultMessage { get; set; }
    }
}