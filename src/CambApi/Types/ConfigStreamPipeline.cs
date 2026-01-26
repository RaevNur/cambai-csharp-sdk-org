using System.Text.Json.Serialization;

#nullable enable

namespace CambApi;

public record ConfigStreamPipeline
{
    [JsonPropertyName("demixing")]
    public DemixingOption? Demixing { get; set; }

    [JsonPropertyName("segmenting")]
    public SegmentingOption? Segmenting { get; set; }

    [JsonPropertyName("transcribing")]
    public TranscribingOption? Transcribing { get; set; }

    [JsonPropertyName("translating")]
    public TranslatingOption? Translating { get; set; }

    [JsonPropertyName("revoicing")]
    public RevoicingOption? Revoicing { get; set; }
}
