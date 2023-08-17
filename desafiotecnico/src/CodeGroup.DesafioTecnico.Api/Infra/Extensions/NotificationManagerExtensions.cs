using CodeGroup.DesafioTecnico.Api.Domain.Enums;
using CodeGroup.DesafioTecnico.Api.Infra.Notifications;

namespace CodeGroup.DesafioTecnico.Api.Infra.Extensions;

public static class NotificationManagerExtensions
{
    public static List<NotificationBase> AddInformation(this List<NotificationBase> notifications, string message)
    {
        notifications?.Add(new NotificationBase
        {
            Type = NotificationType.Information.ToString(),
            Message = message
        });
        return notifications!;
    }

    public static List<NotificationBase> AddCritical(this List<NotificationBase> notifications, string message)
    {
        notifications?.Add(new NotificationBase
        {
            Type = NotificationType.Critical.ToString(),
            Message = message
        });
        return notifications!;
    }

    public static List<NotificationBase> AddDebug(this List<NotificationBase> notifications, string message)
    {
        notifications?.Add(new NotificationBase
        {
            Type = NotificationType.Debug.ToString(),
            Message = message
        });
        return notifications!;
    }

    public static List<NotificationBase> AddError(this List<NotificationBase> notifications, string message)
    {
        notifications?.Add(new NotificationBase
        {
            Type = NotificationType.Error.ToString(),
            Message = message
        });
        return notifications!;
    }

    public static List<NotificationBase> AddTrace(this List<NotificationBase> notifications, string message)
    {
        notifications?.Add(new NotificationBase
        {
            Type = NotificationType.Trace.ToString(),
            Message = message
        });
        return notifications!;
    }

    public static List<NotificationBase> AddWarning(this List<NotificationBase> notifications, string message)
    {
        notifications?.Add(new NotificationBase
        {
            Type = NotificationType.Warning.ToString(),
            Message = message
        });
        return notifications!;
    }

    public static List<NotificationBase> AddNone(this List<NotificationBase> notifications, string message)
    {
        notifications?.Add(new NotificationBase
        {
            Type = NotificationType.None.ToString(),
            Message = message
        });
        return notifications!;
    }
}
