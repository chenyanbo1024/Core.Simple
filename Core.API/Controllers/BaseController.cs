using Core.Common;

using Microsoft.AspNetCore.Mvc;

namespace Core.API.Controllers;

public class BaseController : ControllerBase
{
    [NonAction]
    public ApiResult SUCCESS(string msg = "操作成功", object? data = null)
    {
        return new ApiResult()
        {
            Status = 200,
            Code = 2000,
            Msg = msg,
            Data = data
        };
    }

    [NonAction]
    public ApiResult CREATED(string msg = "新建或修改成功", object? data = null)
    {
        return new ApiResult()
        {
            Status = 201,
            Code = 2010,
            Msg = msg,
            Data = data
        };
    }

    [NonAction]
    public ApiResult NO_CONTENT(string msg = "删除成功")
    {
        return new ApiResult()
        {
            Status = 201,
            Code = 2010,
            Msg = msg,
        };
    }

    [NonAction]
    public ApiResult INVALID_REQUEST(string msg = "请求错误", object? data = null)
    {
        return new ApiResult()
        {
            Status = 400,
            Code = 4010,
            Msg = msg,
            Data = data
        };
    }

    [NonAction]
    public ApiResult SERVER_ERROR(string msg = "服务器发生错误", object? data = null)
    {
        return new ApiResult()
        {
            Status = 500,
            Code = 5010,
            Msg = msg,
            Data = data
        };
    }
}
