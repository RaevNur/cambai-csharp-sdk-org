using System.Text.Json.Serialization;
using CambApi.Core;
using OneOf;

#nullable enable

namespace CambApi;

public record ValidationError
{
    [JsonPropertyName("loc")]
    [JsonConverter(
        typeof(CollectionItemSerializer<OneOf<string, int>, OneOfSerializer<OneOf<string, int>>>)
    )]
    public IEnumerable<OneOf<string, int>> Loc { get; set; } = new List<OneOf<string, int>>();

    [JsonPropertyName("msg")]
    public required string Msg { get; set; }

    [JsonPropertyName("type")]
    public required string Type { get; set; }
}
