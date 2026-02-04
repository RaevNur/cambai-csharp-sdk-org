namespace CambApi;

public record ListFoldersFoldersGetRequest
{
    public int? Limit { get; set; }

    public string? SearchQuery { get; set; }

    public int? RunId { get; set; }
}
