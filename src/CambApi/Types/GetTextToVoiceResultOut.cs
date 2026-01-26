using System.Text.Json.Serialization;

#nullable enable

namespace CambApi;

public record GetTextToVoiceResultOut
{
    [JsonPropertyName("previews")]
    public IEnumerable<string> Previews { get; set; } = new List<string>();
}
