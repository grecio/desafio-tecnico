namespace CodeGroup.DesafioTecnico.Api.Domain.Constants;

public static class OtherContants
{
    public const string API_VERSION_1 = "1";
    public const string API_VERSION_2 = "2";
    public const string ROUTE_DEFAULT_ID = "{id}";
    public const string ROUTE_DEFAULT_SEARCH = "{pageNumber}/{rowsPerPage}";
    public const string ROUTE_DEFAULT_CONTROLLER = "api/v{version:apiVersion}/[controller]";
    public const string BINDING_PAGE_NUMBER = "pageNumber";
    public const string BINDING_ROWS_PER_PAGE = "rowsPerPage";
    public const string ROUTE_DOCUMENT_MANAGEMENT_DOWNLOAD = "{id}/Download";
    public const string FIELD_PAGE_NUMBER = "PageNumber";
    public const string FIELD_ROWS_PER_PAGE = "RowsPerPage";
    public const string VALIDATION_PAGE_NUMBER = "O campo PageNumber deve começar a partir de 1.";
    public const string ROUTE_SEARCH_NAMES = "search-names";
    public const string ROUTE_SEARCH_IDS = "search-ids";
    public const string ROUTE_SEARCH = "search";
    public const string ROUTE_SEARCH_BY_EXTENSION = "extension";
    public const string ROUTE_SEARCH_BY_IDENTIFIER = "search/{identifier}";

}
