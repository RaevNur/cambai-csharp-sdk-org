using System.Text.Json.Serialization;

#nullable enable

namespace CambApi;

public record CreateCustomVoiceOut
{
    [JsonPropertyName("voice_id")]
    public required int VoiceId { get; set; }
}
