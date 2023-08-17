using System.Text.Json.Serialization;

namespace CodeGroup.DesafioTecnico.Api.Infra.Notifications;

public class NotificationBase
{
    [JsonPropertyName("message")]
    public string Message { get; set; } = "";

    [JsonPropertyName("type")]
    public string Type { get; set; } = "";
}
