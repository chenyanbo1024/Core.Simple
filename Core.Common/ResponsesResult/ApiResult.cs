namespace Core.Common
{
    /// <summary>
    /// 通用响应报文
    /// </summary>
    public class ApiResult
    {
        public ApiResult(int status = 200,int code = 2000, string msg = "", object? data = null, int count = 0)
        {
            Status = status;
            Code = code;
            Msg = msg;
            Data = data;
            Count = count;
        }

        public int Status { get; set; }
        public int Code { get; set; }
        public string? Msg { get; set; }
        public object? Data { get; set; }
        public int Count { get; set; }
    }
}