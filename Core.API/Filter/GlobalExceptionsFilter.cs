using Core.Common;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Core.API.Filter;

public class GlobalExceptionsFilter : IExceptionFilter
{
    private readonly ILogger<GlobalExceptionsFilter> _logger;
    public GlobalExceptionsFilter(ILogger<GlobalExceptionsFilter> logger)
    {
        _logger = logger;
    }

    public void OnException(ExceptionContext context)
    {
        // 异常已被处理
        if (context.ExceptionHandled)
        {
            return;
        }

        // 获取异常对象
        var exception = context.Exception;

        // 获取触发异常的控制器 及 接口名
        var controllerName = context.RouteData.Values["Controller"]?.ToString() ?? "";
        var actionName = context.RouteData.Values["Action"]?.ToString() ?? "";

        // 写入异常 Log
        _logger.LogError(message: $"【全局异常】：Controller: {controllerName}，Action: {actionName} \r\n【异常类型】：{exception.GetType().Name} \r\n【异常信息】：{exception.Message} \r\n【堆栈调用】：\r\n{exception.StackTrace}");

        //设置异常对象为已处理
        context.ExceptionHandled = true;

        context.Result = new JsonResult(new ApiResult
        {
            Code = (int)ApiCode.SERVER_ERROR,
            Msg = $"全局捕获到一个异常......({exception.Message})"
        });
    }
}
