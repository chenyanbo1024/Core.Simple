namespace Core.Models.DTOs.Response;

public class TokenInfoResponse
{
    public bool Success { get; set; }

    public string Token { get; set; }

    public double ExpiresIn { get; set; }

    public string TokenType { get; set; }
}
