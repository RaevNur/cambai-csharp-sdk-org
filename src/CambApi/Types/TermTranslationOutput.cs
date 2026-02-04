using System.Text.Json.Serialization;

#nullable enable

namespace CambApi;

public record TermTranslationOutput
{
    [JsonPropertyName("language")]
    public required int Language { get; set; }

    [JsonPropertyName("term_text")]
    public required string TermText { get; set; }
}
