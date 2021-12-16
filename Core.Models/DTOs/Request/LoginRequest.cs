using System.ComponentModel.DataAnnotations;

namespace Core.Models.DTOs.Request;

/// <summary>
/// 登录
/// </summary>
public class LoginRequest
{
    /// <summary>
    /// 用户名
    /// </summary>
    [Required(ErrorMessage = "用户名必填. (params:name)")]
    public string Name { get; set; }

    /// <summary>
    /// 密码
    /// </summary>

    [Required(ErrorMessage = "密码必填. (params:password)")]
    public string Password { get; set; }
}

