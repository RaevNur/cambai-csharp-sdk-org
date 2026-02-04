namespace CambApi;

public record UpdateTermTranslationsPayload
{
    public int? RunId { get; set; }

    public IEnumerable<TermTranslationInput> Translations { get; set; } =
        new List<TermTranslationInput>();
}
