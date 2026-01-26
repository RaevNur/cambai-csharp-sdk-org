using System.Text.Json.Serialization;

#nullable enable

namespace CambApi;

public record DictionaryTerm
{
    [JsonPropertyName("id")]
    public required int Id { get; set; }

    [JsonPropertyName("term_translations")]
    public IEnumerable<TermTranslationOutput> TermTranslations { get; set; } =
        new List<TermTranslationOutput>();
}
