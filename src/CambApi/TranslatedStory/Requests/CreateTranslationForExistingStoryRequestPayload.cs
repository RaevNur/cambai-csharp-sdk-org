using System.Text.Json.Serialization;

#nullable enable

namespace CambApi;

public record CreateTranslationForExistingStoryRequestPayload
{
    [JsonPropertyName("target_language")]
    public required int TargetLanguage { get; set; }
}
