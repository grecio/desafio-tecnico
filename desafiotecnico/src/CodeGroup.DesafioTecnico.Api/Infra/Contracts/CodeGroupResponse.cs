using CodeGroup.DesafioTecnico.Api.Domain.Enums;
using CodeGroup.DesafioTecnico.Api.Infra.Notifications;
using System.Text.Json.Serialization;

namespace CodeGroup.DesafioTecnico.Api.Infra.Contracts;

public class CodeGroupResponse<T>
{
    [JsonPropertyName("success")]
    public bool Success { get; set; }

    [JsonPropertyName("has_information_notification")]
    public bool HasInformationNotification { get; set; }

    [JsonPropertyName("has_trace_notification")]
    public bool HasTraceNotification { get; set; }

    [JsonPropertyName("has_debug_notification")]
    public bool HasDebugNotification { get; set; }

    [JsonPropertyName("has_warning_notification")]
    public bool HasWarningNotification { get; set; }

    [JsonPropertyName("has_error_notification")]
    public bool HasErrorNotification { get; set; }

    [JsonPropertyName("has_critical_notification")]
    public bool HasCriticalNotification { get; set; }

    [JsonPropertyName("notifications")]
    public List<NotificationBase> Notifications { get; set; }

    [JsonPropertyName("data")]
    public T Data { get; set; }

    public CodeGroupResponse()
    {
    }

    public CodeGroupResponse(T data, List<NotificationBase> notifications, bool sucess)
    {
        Notifications = notifications;
        Data = data;
        Success = sucess;
        if (notifications != null)
        {
            HasInformationNotification = notifications.Any((NotificationBase x) => x.Type == NotificationType.Trace.ToString());
            HasDebugNotification = notifications.Any((NotificationBase x) => x.Type == NotificationType.Debug.ToString());
            HasWarningNotification = notifications.Any((NotificationBase x) => x.Type == NotificationType.Warning.ToString());
            HasInformationNotification = notifications.Any((NotificationBase x) => x.Type == NotificationType.Information.ToString());
            HasErrorNotification = notifications.Any((NotificationBase x) => x.Type == NotificationType.Error.ToString());
            HasCriticalNotification = notifications.Any((NotificationBase x) => x.Type == NotificationType.Critical.ToString());
            if (HasCriticalNotification || HasErrorNotification)
            {
                Data = default;
            }
        }
    }
}
