using System.Text.Json.Serialization;

#nullable enable

namespace CambApi;

public record GetTtsResultOutFileUrl
{
    [JsonPropertyName("output_url")]
    public required string OutputUrl { get; set; }
}
