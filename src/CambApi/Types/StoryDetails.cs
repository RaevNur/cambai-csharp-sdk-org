using System.Text.Json.Serialization;

#nullable enable

namespace CambApi;

public record StoryDetails
{
    [JsonPropertyName("story_title")]
    public required string StoryTitle { get; set; }

    [JsonPropertyName("story_description")]
    public string? StoryDescription { get; set; }

    [JsonPropertyName("created_at")]
    public required DateTime CreatedAt { get; set; }

    [JsonPropertyName("source_language")]
    public required int SourceLanguage { get; set; }

    [JsonPropertyName("target_languages")]
    public IEnumerable<int>? TargetLanguages { get; set; }

    [JsonPropertyName("folder_id")]
    public int? FolderId { get; set; }

    [JsonPropertyName("studio_url")]
    public required string StudioUrl { get; set; }
}
