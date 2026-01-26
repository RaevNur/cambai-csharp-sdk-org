namespace CambApi;

public record CreateTranslatedTtsRequestPayload
{
    public int? RunId { get; set; }

    public string? Traceparent { get; set; }

    public string? ProjectName { get; set; }

    public string? ProjectDescription { get; set; }

    public int? FolderId { get; set; }

    public required string Text { get; set; }

    public required int VoiceId { get; set; }

    public int? Age { get; set; }

    public int? Formality { get; set; }

    public int? Gender { get; set; }

    public required int SourceLanguage { get; set; }

    public required int TargetLanguage { get; set; }

    public IEnumerable<int>? ChosenDictionaries { get; set; }
}
