using System.Runtime.InteropServices.ComTypes;
using System.Text.Json.Serialization;

namespace rd_client.Models;

public class RdUser
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
    [JsonPropertyName("username")]
    public string Username { get; set; }
    [JsonPropertyName("email")]
    public string Email { get; set; }
    [JsonPropertyName("points")]
    public int Points { get; set; }
    [JsonPropertyName("locale")]
    public string Locale { get; set; }
    [JsonPropertyName("avatar")]
    public string Avatar { get; set; }
    [JsonPropertyName("type")]
    public string Type { get; set; }
    [JsonPropertyName("premium")]
    public int Premium { get; set; }
    [JsonPropertyName("expiration")]
    public string Expiration { get; set; }
}