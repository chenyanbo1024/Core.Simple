using System.ComponentModel;

namespace Core.Common
{
    /// <summary>
    /// 一些常用API操作码
    /// </summary>
    public enum ApiCode
    {
        /// <summary>
        /// 服务器成功返回用户请求的数据
        /// </summary>
        [Description("操作成功")]
        OK = 2000,

        /// <summary>
        /// 用户新建或修改数据成功
        /// </summary>
        [Description("新建或修改成功")]
        CREATED = 2010,

        /// <summary>
        /// 用户删除数据成功
        /// </summary>
        [Description("删除成功")]
        NO_CONTENT = 2040,

        [Description("请求错误")]
        INVALID_REQUEST = 4000,

        /// <summary>
        /// 未授权
        /// </summary>
        [Description("未授权，或无效Token")]
        UNAUTHORIZED = 4010,

        /// <summary>
        /// 被拒绝，无权限
        /// </summary>
        [Description("无操作权限")]
        FORBIDDEN = 4030,

        /// <summary>
        /// 用户发出的请求针对的是不存在的记录，服务器没有进行操作
        /// </summary>
        [Description("参数检验失败")]
        NOT_FOUND = 4040,

        /// <summary>
        /// 服务器发生错误，用户将无法判断发出的请求是否成功。
        /// </summary>
        [Description("服务器发生错误")]
        SERVER_ERROR = 5000,
    }


    public enum ApiStatus
    {
        /// <summary>
        /// 服务器成功返回用户请求的数据
        /// </summary>
        [Description("操作成功")]
        OK = 200,

        /// <summary>
        /// 用户新建或修改数据成功
        /// </summary>
        [Description("新建或修改成功")]
        CREATED = 201,

        /// <summary>
        /// 用户删除数据成功
        /// </summary>
        [Description("删除成功")]
        NO_CONTENT = 204,

        [Description("请求错误")]
        INVALID_REQUEST = 400,

        /// <summary>
        /// 未授权
        /// </summary>
        [Description("未授权，或无效Token")]
        UNAUTHORIZED = 401,

        /// <summary>
        /// 被拒绝，无权限
        /// </summary>
        [Description("无操作权限")]
        FORBIDDEN = 403,

        /// <summary>
        /// 用户发出的请求针对的是不存在的记录，服务器没有进行操作
        /// </summary>
        [Description("参数检验失败")]
        NOT_FOUND = 404,

        /// <summary>
        /// 服务器发生错误，用户将无法判断发出的请求是否成功。
        /// </summary>
        [Description("服务器发生错误")]
        SERVER_ERROR = 500,
    }
}
