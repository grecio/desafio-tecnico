using CodeGroup.DesafioTecnico.Api.Domain.Constants;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.Extensions.Primitives;
using System.Text;

namespace CodeGroup.DesafioTecnico.Api.Infra.Extensions;

public static class HttpContextExtensions
{
    public static string GetCorrelationId(this HttpRequest request)
    {
        string result = string.Empty;
        try
        {
            string empty = string.Empty;
            StringValues? stringValues = request?.Headers?.FirstOrDefault((KeyValuePair<string, StringValues> x) => ConstantsApi.CORRELATIONS.Any((string Correlation) => x.Key.ToLower() == Correlation.ToLower())).Value;
            empty = stringValues.HasValue ? ((string)stringValues.GetValueOrDefault()) : null;
            result = (string.IsNullOrWhiteSpace(empty) ? Guid.NewGuid().ToString() : empty);
            return result;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex?.ToString());
            return result;
        }
    }

    public static string GetPath(this HttpContext httpContext)
    {
        string result = string.Empty;
        try
        {
            result = httpContext?.Request?.Path.ToString() ?? httpContext?.Features?.Get<IHttpRequestFeature>()?.RawTarget;
            return result;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex?.ToString());
            return result;
        }
    }

    public static async Task<string> ReadRequestBody(this HttpRequest request)
    {
        string result = string.Empty;
        try
        {
            request.EnableBuffering();
            byte[] buffer = new byte[Convert.ToInt32(request.ContentLength)];
            await request.Body.ReadAsync(buffer, 0, buffer.Length);
            result = Encoding.UTF8.GetString(buffer);
            request.Body.Seek(0L, SeekOrigin.Begin);
            return result;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex?.ToString());
            return result;
        }
    }

    public static async Task<string> ReadResponseBody(this HttpResponse response)
    {
        string result = string.Empty;
        try
        {
            response.Body.Seek(0L, SeekOrigin.Begin);
            result = await new StreamReader(response.Body).ReadToEndAsync();
            response.Body.Seek(0L, SeekOrigin.Begin);
            return result;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex?.ToString());
            return result;
        }
    }

    public static bool? ToBoolean(this string s)
    {
        if (bool.TryParse(s, out var result))
        {
            return result;
        }

        return null;
    }
}
