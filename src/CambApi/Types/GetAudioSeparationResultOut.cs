using System.Text.Json.Serialization;

#nullable enable

namespace CambApi;

public record GetAudioSeparationResultOut
{
    [JsonPropertyName("foreground_audio_url")]
    public required string ForegroundAudioUrl { get; set; }

    [JsonPropertyName("background_audio_url")]
    public required string BackgroundAudioUrl { get; set; }
}
