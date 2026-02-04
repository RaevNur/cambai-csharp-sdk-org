using System.Text.Json.Serialization;

#nullable enable

namespace CambApi;

public record RunIDsRequestPayload
{
    [JsonPropertyName("run_ids")]
    public IEnumerable<int> RunIds { get; set; } = new List<int>();
}
