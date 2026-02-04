using System.Text.Json.Serialization;

#nullable enable

namespace CambApi;

public record ConfigStream
{
    [JsonPropertyName("pipeline")]
    public ConfigStreamPipeline? Pipeline { get; set; }

    [JsonPropertyName("mixing")]
    public OverdubConfig? Mixing { get; set; }
}
