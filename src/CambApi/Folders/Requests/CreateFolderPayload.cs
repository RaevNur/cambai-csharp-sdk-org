namespace CambApi;

public record CreateFolderPayload
{
    public int? RunId { get; set; }

    public required string FolderName { get; set; }
}
