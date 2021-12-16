namespace Core.Common
{
    /// <summary>
    /// 通用分页信息类
    /// </summary>
    public class ApiResultPage<T>
    {
        public ApiResultPage(int status = 200,int code = 2000, string msg = "", int totalCount = 0, int pageSize = 10, List<T>? data = null)
        {
            Status = status;
            Code = code;
            Msg = msg;
            TotalCount = totalCount;
            PageSize = pageSize;
            Data = data;
        }

        public int Status { get; set; }

        public int Code { get; set; }

        public string Msg { get; set; }

        /// <summary>
        /// 数据总数
        /// </summary>
        public int TotalCount { get; set; }

        /// <summary>
        /// 每页大小
        /// </summary>
        public int PageSize { set; get; }

        /// <summary>
        /// 返回数据
        /// </summary>
        public List<T>? Data { get; set; }
    }
}