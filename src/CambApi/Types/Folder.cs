using System.Text.Json.Serialization;

#nullable enable

namespace CambApi;

public record Folder
{
    [JsonPropertyName("team_id")]
    public required int TeamId { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }
}
