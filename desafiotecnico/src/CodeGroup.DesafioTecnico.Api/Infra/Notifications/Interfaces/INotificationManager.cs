namespace CodeGroup.DesafioTecnico.Api.Infra.Notifications.Interfaces;

public interface INotificationManager
{
    INotificationManager AddInformation(string message);

    INotificationManager AddCritical(string message);

    INotificationManager AddDebug(string message);

    INotificationManager AddError(string message);

    INotificationManager AddTrace(string message);

    INotificationManager AddWarning(string message);

    INotificationManager AddNone(string message);

    List<NotificationBase> GetNotifications();

    INotificationManager AddNotifications(List<NotificationBase> notificationBases);
}
