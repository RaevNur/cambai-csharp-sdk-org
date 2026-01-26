using System.Text.Json.Serialization;

#nullable enable

namespace CambApi;

public record TranslationResult
{
    [JsonPropertyName("texts")]
    public IEnumerable<string> Texts { get; set; } = new List<string>();
}
