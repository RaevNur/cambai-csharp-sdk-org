namespace CambApi;

public record CreateTranslationRequestPayload
{
    public int? RunId { get; set; }

    public string? ProjectName { get; set; }

    public string? ProjectDescription { get; set; }

    public int? FolderId { get; set; }

    public IEnumerable<string> Texts { get; set; } = new List<string>();

    public int? Age { get; set; }

    public int? Formality { get; set; }

    public int? Gender { get; set; }

    public required int SourceLanguage { get; set; }

    public required int TargetLanguage { get; set; }

    public IEnumerable<int>? ChosenDictionaries { get; set; }
}
