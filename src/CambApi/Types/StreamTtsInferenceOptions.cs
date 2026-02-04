using System.Text.Json.Serialization;

#nullable enable

namespace CambApi;

public record StreamTtsInferenceOptions
{
    [JsonPropertyName("stability")]
    public double? Stability { get; set; }

    [JsonPropertyName("temperature")]
    public double? Temperature { get; set; }

    [JsonPropertyName("inference_steps")]
    public int? InferenceSteps { get; set; }

    [JsonPropertyName("speaker_similarity")]
    public double? SpeakerSimilarity { get; set; }

    [JsonPropertyName("localize_speaker_weight")]
    public double? LocalizeSpeakerWeight { get; set; }

    [JsonPropertyName("acoustic_quality_boost")]
    public bool? AcousticQualityBoost { get; set; }
}
