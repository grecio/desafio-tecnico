using CodeGroup.DesafioTecnico.Api.Infra.Extensions;
using CodeGroup.DesafioTecnico.Api.Infra.Notifications.Interfaces;

namespace CodeGroup.DesafioTecnico.Api.Infra.Notifications;

public class NotificationManager : INotificationManager
{
    private List<NotificationBase> Notifications { get; set; } = new List<NotificationBase>();


    public INotificationManager AddInformation(string message)
    {
        Notifications.AddInformation(message);
        return this;
    }

    public INotificationManager AddCritical(string message)
    {
        Notifications.AddCritical(message);
        return this;
    }

    public INotificationManager AddDebug(string message)
    {
        Notifications.AddDebug(message);
        return this;
    }

    public INotificationManager AddError(string message)
    {
        Notifications.AddError(message);
        return this;
    }

    public INotificationManager AddTrace(string message)
    {
        Notifications.AddTrace(message);
        return this;
    }

    public INotificationManager AddWarning(string message)
    {
        Notifications.AddWarning(message);
        return this;
    }

    public INotificationManager AddNone(string message)
    {
        Notifications.AddNone(message);
        return this;
    }

    public List<NotificationBase> GetNotifications()
    {
        return Notifications;
    }

    public INotificationManager AddNotifications(List<NotificationBase> notificationBases)
    {
        Notifications?.AddRange(notificationBases);
        return this;
    }
}
