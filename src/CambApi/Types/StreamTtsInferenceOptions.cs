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
}
