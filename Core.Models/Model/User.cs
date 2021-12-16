using System.ComponentModel.DataAnnotations;

namespace Core.Models.Model;

/// <summary>
/// 用户表
/// </summary>
public class User
{
    /// <summary>
    /// 主键ID
    /// </summary>
    [Key]
    public int Id { get; set; }

    /// <summary>
    /// 名字
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// 密码
    /// </summary>
    public string Password { get; set; }
}
