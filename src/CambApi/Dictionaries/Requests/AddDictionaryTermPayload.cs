namespace CambApi;

public record AddDictionaryTermPayload
{
    public int? RunId { get; set; }

    public IEnumerable<TermTranslationInput> Translations { get; set; } =
        new List<TermTranslationInput>();
}
