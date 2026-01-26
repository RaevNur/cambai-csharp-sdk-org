using System.Text.Json.Serialization;

#nullable enable

namespace CambApi;

public record OverdubConfig
{
    /// <summary>
    /// Proportion of the original audio (0.0 to 1.0).
    /// </summary>
    [JsonPropertyName("original_audio_gain")]
    public double? OriginalAudioGain { get; set; }

    /// <summary>
    /// Proportion of the background audio (0.0 to 1.0).
    /// </summary>
    [JsonPropertyName("background_audio_gain")]
    public double? BackgroundAudioGain { get; set; }

    /// <summary>
    /// Cross-fade duration in seconds (0.0 to 5.0).
    /// </summary>
    [JsonPropertyName("fade_time")]
    public double? FadeTime { get; set; }

    /// <summary>
    /// Proportion of the fallback audio (0.0 to 1.0) (for streaming only).
    /// </summary>
    [JsonPropertyName("fallback_audio_gain")]
    public double? FallbackAudioGain { get; set; }
}
