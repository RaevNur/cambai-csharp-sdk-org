using System.Text.Json.Serialization;

#nullable enable

namespace CambApi;

public record StreamTtsVoiceSettings
{
    [JsonPropertyName("enhance_reference_audio_quality")]
    public bool? EnhanceReferenceAudioQuality { get; set; }

    [JsonPropertyName("maintain_source_accent")]
    public bool? MaintainSourceAccent { get; set; }

    [JsonPropertyName("apply_ref_loudness_norm")]
    public bool? ApplyRefLoudnessNorm { get; set; }
}
