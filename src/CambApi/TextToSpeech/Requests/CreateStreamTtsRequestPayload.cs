using System.Text.Json.Serialization;

#nullable enable

namespace CambApi;

public record CreateStreamTtsRequestPayload
{
    [JsonPropertyName("text")]
    public required string Text { get; set; }

    [JsonPropertyName("language")]
    public required CreateStreamTtsRequestPayloadLanguage Language { get; set; }

    [JsonPropertyName("voice_id")]
    public required int VoiceId { get; set; }

    [JsonPropertyName("speech_model")]
    public CreateStreamTtsRequestPayloadSpeechModel? SpeechModel { get; set; }

    [JsonPropertyName("user_instructions")]
    public string? UserInstructions { get; set; }

    [JsonPropertyName("enhance_named_entities_pronunciation")]
    public bool? EnhanceNamedEntitiesPronunciation { get; set; }

    [JsonPropertyName("output_configuration")]
    public StreamTtsOutputConfiguration? OutputConfiguration { get; set; }

    [JsonPropertyName("voice_settings")]
    public StreamTtsVoiceSettings? VoiceSettings { get; set; }

    [JsonPropertyName("inference_options")]
    public StreamTtsInferenceOptions? InferenceOptions { get; set; }
}
