using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Text.Json;
using CodeGroup.DesafioTecnico.Api.Infra.Notifications;
using CodeGroup.DesafioTecnico.Api.Infra.Notifications.Interfaces;
using CodeGroup.DesafioTecnico.Api.Infra.Contracts;
using CodeGroup.DesafioTecnico.Api.Infra.Extensions;

namespace CodeGroup.DesafioTecnico.Api.Controllers;

public class CodeGroupBaseController : ControllerBase
{
    protected AcceptedResult Accepted<T>(T value, List<NotificationBase> notifications = null)
    {
        notifications = notifications ?? new NotificationManager().GetNotifications();
        CorrelationIdTrace(notifications);
        return base.Accepted(new CodeGroupResponse<object>(value, notifications, sucess: true));
    }

    public override AcceptedResult Accepted(string uri)
    {
        INotificationManager notificationManager = new NotificationManager();
        CorrelationIdTrace(notificationManager);
        return base.Accepted(new CodeGroupResponse<object>(uri, notificationManager.GetNotifications(), sucess: true));
    }

    public override AcceptedResult Accepted(Uri uri)
    {
        INotificationManager notificationManager = new NotificationManager();
        CorrelationIdTrace(notificationManager);
        return base.Accepted(new CodeGroupResponse<object>(uri, notificationManager.GetNotifications(), sucess: true));
    }

    public override BadRequestObjectResult BadRequest(ModelStateDictionary modelState)
    {
        INotificationManager notificationManager = new NotificationManager();
        CorrelationIdTrace(notificationManager);
        ModelStateDictionary modelState2 = base.ModelState;
        foreach (ModelError item in (modelState2 != null) ? modelState2.Values.SelectMany((ModelStateEntry e) => e.Errors) : null)
        {
            notificationManager.AddError(item.ErrorMessage);
        }

        return base.BadRequest(new CodeGroupResponse<object>(null, notificationManager.GetNotifications(), sucess: false));
    }

    protected BadRequestObjectResult BadRequest(List<NotificationBase> notifications)
    {
        CorrelationIdTrace(notifications);
        return base.BadRequest(new CodeGroupResponse<object>(null, notifications, sucess: false));
    }

    public override ConflictObjectResult Conflict(ModelStateDictionary modelState)
    {
        INotificationManager notificationManager = new NotificationManager();
        CorrelationIdTrace(notificationManager);
        ModelStateDictionary modelState2 = base.ModelState;
        foreach (ModelError item in (modelState2 != null) ? modelState2.Values.SelectMany((ModelStateEntry e) => e.Errors) : null)
        {
            notificationManager.AddError(item.ErrorMessage);
        }

        return base.Conflict(new CodeGroupResponse<object>(null, notificationManager.GetNotifications(), sucess: false));
    }

    public override ContentResult Content(string content)
    {
        INotificationManager notificationManager = new NotificationManager();
        CorrelationIdTrace(notificationManager);
        return base.Content(JsonSerializer.Serialize(new CodeGroupResponse<object>(content, notificationManager.GetNotifications(), sucess: true)));
    }

    protected CreatedResult Created<T>(string uri, T value, List<NotificationBase> notifications = null)
    {
        notifications = notifications ?? new NotificationManager().GetNotifications();
        CorrelationIdTrace(notifications);
        return (CreatedResult)base.StatusCode(201, new CodeGroupResponse<object>(new { uri, value }, notifications, sucess: true));
    }

    protected CreatedResult Created<T>(Uri uri, T value, List<NotificationBase> notifications = null)
    {
        notifications = notifications ?? new NotificationManager().GetNotifications();
        CorrelationIdTrace(notifications);
        return (CreatedResult)base.StatusCode(201, new CodeGroupResponse<object>(new { uri, value }, notifications, sucess: true));
    }

    protected OkObjectResult Ok<T>(T value, List<NotificationBase> notifications = null)
    {
        notifications = notifications ?? new NotificationManager().GetNotifications();
        CorrelationIdTrace(notifications);
        return base.Ok(new CodeGroupResponse<T>(value, notifications, sucess: true));
    }

    protected ObjectResult StatusCode<T>(int statusCode, T value, List<NotificationBase> notifications = null)
    {
        notifications = notifications ?? new NotificationManager().GetNotifications();
        CorrelationIdTrace(notifications);
        return base.StatusCode(statusCode, new CodeGroupResponse<T>(value, notifications, sucess: true));
    }

    protected UnauthorizedObjectResult Unauthorized<T>(T value, List<NotificationBase> notifications = null)
    {
        notifications = notifications ?? new NotificationManager().GetNotifications();
        CorrelationIdTrace(notifications);
        return base.Unauthorized(new CodeGroupResponse<T>(value, notifications, sucess: false));
    }

    public override ActionResult ValidationProblem(ModelStateDictionary modelStateDictionary)
    {
        INotificationManager notificationManager = new NotificationManager();
        CorrelationIdTrace(notificationManager);
        foreach (ModelError item in base.ModelState.Values.SelectMany((ModelStateEntry e) => e.Errors))
        {
            notificationManager.AddError(item.ErrorMessage);
        }

        return base.BadRequest(new CodeGroupResponse<object>(null, notificationManager.GetNotifications(), sucess: false));
    }

    protected IActionResult Json<T>(T data, List<NotificationBase> notifications = null)
    {
        if (notifications == null)
        {
            notifications = new List<NotificationBase>();
        }

        CorrelationIdTrace(notifications);
        return base.Ok(new CodeGroupResponse<object>(data, notifications, sucess: true));
    }

    protected IActionResult BadRequest(Exception ex, List<NotificationBase> notifications = null)
    {
        notifications = notifications ?? new NotificationManager().GetNotifications();
        CorrelationIdTrace(notifications);
        notifications.AddWarning(ex.ToString());
        return base.StatusCode(400, new CodeGroupResponse<object>(ex.ToString(), notifications, sucess: false));
    }

    protected IActionResult BadRequest(ControllerContext context, List<NotificationBase> notifications = null)
    {
        notifications = notifications ?? new NotificationManager().GetNotifications();
        CorrelationIdTrace(notifications);
        return context.InvalidModelStateResponse();
    }

    protected IActionResult CreatedAtAction<T>(string actionName, object routeValues, T value, List<NotificationBase> notifications = null)
    {
        notifications = notifications ?? new NotificationManager().GetNotifications();
        CorrelationIdTrace(notifications);
        return base.CreatedAtAction(actionName, routeValues, new CodeGroupResponse<T>(value, notifications, sucess: true));
    }

    protected IActionResult InternalServerError(object value, List<NotificationBase> notifications = null)
    {
        notifications = notifications ?? new NotificationManager().GetNotifications();
        CorrelationIdTrace(notifications);
        if (value != null)
        {
            notifications.AddCritical(value.ToString());
        }

        return base.StatusCode(500, new CodeGroupResponse<object>(null, notifications, sucess: false));
    }

    protected IActionResult InternalServerError(Exception ex, List<NotificationBase> notifications = null)
    {
        notifications = notifications ?? new NotificationManager().GetNotifications();
        CorrelationIdTrace(notifications);
        if (ex != null)
        {
            notifications.AddCritical(ex.ToString());
        }

        return base.StatusCode(500, new CodeGroupResponse<object>(null, notifications, sucess: false));
    }

    protected IActionResult InternalServerError<T>(T error, List<NotificationBase> notifications = null)
    {
        notifications = notifications ?? new NotificationManager().GetNotifications();
        CorrelationIdTrace(notifications);
        if (error != null)
        {
            notifications.AddCritical(error.ToString());
        }

        return base.StatusCode(500, new CodeGroupResponse<object>(null, notifications, sucess: false));
    }

    protected IActionResult StatusCode(HttpStatusCode statusCode, List<NotificationBase> notifications = null)
    {
        notifications = notifications ?? new NotificationManager().GetNotifications();
        CorrelationIdTrace(notifications);
        bool sucess = ((statusCode > (HttpStatusCode)399) ? true : false);
        return base.StatusCode((int)statusCode, new CodeGroupResponse<object>(null, notifications, sucess));
    }

    protected void CorrelationIdTrace(INotificationManager notifications)
    {
        string correlationId = base.HttpContext.Request.GetCorrelationId();
        if (!string.IsNullOrEmpty(correlationId))
        {
            notifications.AddInformation($"CorrelationId: {correlationId}.");
        }
    }

    protected void CorrelationIdTrace(List<NotificationBase> notifications)
    {
        string correlationId = base.HttpContext.Request.GetCorrelationId();
        if (!string.IsNullOrEmpty(correlationId))
        {
            notifications.AddInformation($"CorrelationId: {correlationId}.");
        }
    }
}
