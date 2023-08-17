using CodeGroup.DesafioTecnico.Api.Infra.Notifications.Interfaces;

namespace CodeGroup.DesafioTecnico.Api.Infra.Notifications;

public class NotificationProvider : INotificationProvider
{
    public INotificationManager CreateNotification()
    {
        return new NotificationManager();
    }
}
