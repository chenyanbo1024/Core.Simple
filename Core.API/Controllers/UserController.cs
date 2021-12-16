using Core.Common;
using Core.IServices;
using Core.Models.DTOs.Request;
using Core.Models.Model;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Core.API.Controllers;

/// <summary>
/// 用户模块
/// </summary>
[Route("api/[controller]")]
[ApiController]
[AllowAnonymous]
public class UserController : BaseController
{
    private readonly IUserServices _userServices;

    public UserController(IUserServices userServices)
    {
        _userServices = userServices;
    }

    /// <summary>
    /// 添加一行数据
    /// </summary>
    /// <returns></returns>
    [HttpPost]
    public async Task<ApiResult> Add([FromBody] LoginRequest request)
    {
        var model = new User
        {
            Name = request.Name,
            Password = request.Password,
        };
        var data = await _userServices.AddAsync(model);

        return SUCCESS(data: data);
    }

    /// <summary>
    /// 查询一行数据
    /// </summary>
    [HttpGet]
    public async Task<ApiResult> Query()
    {
        var data = await _userServices.FindByIdAsync(1);
        if (data is null)
        {
            return SUCCESS(data: null);
        }
        return SUCCESS(data: data);
    }
}
