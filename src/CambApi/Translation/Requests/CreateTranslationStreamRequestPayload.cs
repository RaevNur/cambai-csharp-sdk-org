namespace CambApi;

public record CreateTranslationStreamRequestPayload
{
    public string? Traceparent { get; set; }

    public required int SourceLanguage { get; set; }

    public required int TargetLanguage { get; set; }

    public required string Text { get; set; }

    public int? Formality { get; set; }

    public int? Gender { get; set; }

    public int? TeamId { get; set; }

    public string? ProjectName { get; set; }

    public string? ProjectDescription { get; set; }

    public int? FolderId { get; set; }
}
