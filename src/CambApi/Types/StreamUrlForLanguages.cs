using System.Text.Json.Serialization;

#nullable enable

namespace CambApi;

public record StreamUrlForLanguages
{
    [JsonPropertyName("languages")]
    public IEnumerable<int> Languages { get; set; } = new List<int>();

    [JsonPropertyName("url")]
    public required string Url { get; set; }
}
