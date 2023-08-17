using CodeGroup.DesafioTecnico.Api.Infra.Notifications.Interfaces;
using CodeGroup.DesafioTecnico.Api.Infra.Notifications;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc;
using CodeGroup.DesafioTecnico.Api.Infra.Contracts;

namespace CodeGroup.DesafioTecnico.Api.Infra.Extensions
{
    public static class ApiBehaviorExtensions
    {
        public static IActionResult InvalidModelStateResponse(this ActionContext context)
        {
            object errors;
            if (context == null)
            {
                errors = null;
            }
            else
            {
                ModelStateDictionary modelState = context.ModelState;
                errors = (modelState?.Values.SelectMany((ModelStateEntry x) => x.Errors));
            }

            return new OkObjectResult(new CodeGroupResponse<object>(null, MapActionContextFromNotificationBase((IEnumerable<ModelError>)errors)?.ToList(), sucess: false))
            {
                ContentTypes = { "application/json" }
            };
        }

        private static List<NotificationBase> MapActionContextFromNotificationBase(IEnumerable<ModelError> errors)
        {
            INotificationManager notificationManager = new NotificationProvider().CreateNotification();
            foreach (ModelError error in errors)
            {
                notificationManager.AddCritical(error.ErrorMessage.ToString());
            }

            return notificationManager.GetNotifications();
        }
    }
}
