namespace CodeGroup.DesafioTecnico.Api.Domain.Constants;

public static class ConstantsApi
{
    public static readonly string[] CORRELATIONS = new string[8] { "x-correlation-id", "X-CORRELATION-ID", "X-CorrelationID", "X-CORRELATIONID", "X-Correlation-ID", "correlationid", "CorrelationId", "CORRELATIONID" };

    public const string SWAGGER = "/swagger/{0}/swagger.json";

    public const string SWAGGER_V1 = "/swagger/v1/swagger.json";

    public const string SWAGGER_V2 = "/swagger/v2/swagger.json";

    public const string SWAGGER_DOCUMENT = "/{documentName}/swagger.json";

    public const string APPLICATION_JSON = "application/json";

    public const string APPSETTINGS = "appsettings.json";

    public const string CORRELATION_HANDLER = "X-CORRELATION-ID";

    public const string X_CORRELATION_ID_V1 = "x-correlation-id";

    public const string X_CORRELATION_ID_V2 = "X-CORRELATION-ID";

    public const string X_CORRELATION_ID_V3 = "X-CorrelationID";

    public const string X_CORRELATION_ID_V4 = "X-CORRELATIONID";

    public const string X_CORRELATION_ID_V5 = "X-Correlation-ID";

    public const string X_CORRELATION_ID_V6 = "correlationid";

    public const string X_CORRELATION_ID_V7 = "CorrelationId";

    public const string X_CORRELATION_ID_V8 = "CORRELATIONID";

    public const string CORRELATION_ID = "CorrelationId: {0}.";

    public const string API_KEY_HANDLER = "ApiKeyHandler";

    public const string HEALTHCHECK_SELF = "/self";

    public const string HEALTHCHECK_READY = "/ready";

    public const string SWAGGER_PATH = "/swagger";

    public const string SWAGGER_INDEX_PATH = "/index.html";

    public const string VALIDATED = "ValidatedAuthentication";

    public const string V1 = "v1";

    public const string API_PROVIDER = "ApiProvider";

    public const string API_PROVIDER_SWAGGER_ENABLE_AUTHORIZE_SWAGGERUI = "ApiProvider:Swagger:EnableAuthorizeSwaggerUI";

    public const string API_PROVIDER_SWAGGER_VERSION = "ApiProvider:Swagger:Version";

    public const string API_PROVIDER_SWAGGER_APPLICATION_NAME = "ApiProvider:Swagger:ApplicationName";

    public const string API_PROVIDER_USE_CORRELATION_ID = "ApiProvider:UseCorrelationId";

    public const string API_PROVIDER_KEY_HANDLER_NAME = "ApiProvider:KeyHandler:Key";

    public const string API_PROVIDER_KEY_HANDLER_VALUE = "ApiProvider:KeyHandler:Value";

    public const string MSG_API_PROVIDER_NOT_CONFIGURED = "Não foi encontrada a seção ApiProvider nas configurações do sistema.";

    public const string MSG_API_PROVIDER_SWAGGER_NOT_CONFIGURED = "Não foi encontrada a seção ApiProvider:Swagger nas configurações do sistema.";

    public const string MSG_API_PROVIDER_SWAGGER_SWAGGER_DOC_NOT_CONFIGURED = "Não foi encontrada a seção ApiProvider:Swagger:SwaggerDoc nas configurações do sistema.";

    public const string MSG_API_PROVIDER_SWAGGER_APPLICATION_NAME_NOT_CONFIGURED = "Não foi encontrada a seção ApiProvider:Swagger:SwaggerDoc:ApplicationName nas configurações do sistema.";

    public const string MSG_API_PROVIDER_SWAGGER_VERSION_NOT_CONFIGURED = "Não foi encontrada a seção ApiProvider:Swagger:SwaggerDoc:Version nas configurações do sistema.";

    public const string MSG_API_PROVIDER_SWAGGER_ENABLE_AUTHORIZE_SWAGGER_UI_NOT_CONFIGURED = "Não foi encontrada a seção ApiProvider:Swagger:EnableAuthorizeSwaggerUI nas configurações do sistema.";

    public const string MSG_API_PROVIDER_KEY_HANDLER_NOT_CONFIGURED = "Não foi encontrada a seção ApiProvider:KeyHandler nas configurações do sistema.";

    public const string MSG_API_PROVIDER_KEY_HANDLER_USE_NOT_CONFIGURED = "Não foi encontrada a seção ApiProvider:KeyHandler:UseApiKey nas configurações do sistema.";

    public const string MSG_API_PROVIDER_KEY_HANDLER_KEY_NOT_CONFIGURED = "Não foi encontrada a seção ApiProvider:KeyHandler:Key nas configurações do sistema.";

    public const string MSG_API_PROVIDER_KEY_HANDLER_VALUE_NOT_CONFIGURED = "Não foi encontrada a seção ApiProvider:KeyHandler:Value nas configurações do sistema.";

    public const string MSG_API_PROVIDER_CORRELATION_ID_NOT_CONFIGURED = "Não foi encontrada a seção ApiProvider:CorrelationId nas configurações do sistema.";

    public const string MSG_API_PROVIDER_CORRELATION_ID_USE_CORRELATION_ID_NOT_CONFIGURED = "Não foi encontrada a seção ApiProvider:CorrelationId:UseCorrelationId nas configurações do sistema.";

    public const string MSG_API_PROVIDER_API_VERSIONING_NOT_CONFIGURED = "Não foi encontrada a seção ApiProvider:ApiVersioning nas configurações do sistema.";

    public const string MSG_API_PROVIDER_API_VERSIONING_USE_API_VERSIONING_NOT_CONFIGURED = "Não foi encontrada a seção ApiProvider:ApiVersioning:UseApiVersioning nas configurações do sistema.";

    public const string MSG_KEY_HANDLER_NOT_FOUND_IN_HEADER = "O header api key é obrigatório para a requisição.";

    public const string MSG_KEY_HANDLER_INVALID = "API Key '{0}' é inválida.";

    public const string MSG_KEY_HANDLER_OK = "API Key validada com sucesso.";

    public const string MSG_CORRELATION_ID_REQUIRED = "O header de correlação é obrigatório para a requisição.";

    public const string MSG_CORRELATION_ID_OK = "Header de correlação informado com sucesso.";
}
