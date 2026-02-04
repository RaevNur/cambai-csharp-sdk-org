using System.Text.Json.Serialization;

#nullable enable

namespace CambApi;

public record ProjectDetails
{
    [JsonPropertyName("project_name")]
    public required string ProjectName { get; set; }

    [JsonPropertyName("project_description")]
    public string? ProjectDescription { get; set; }

    [JsonPropertyName("created_at")]
    public required DateTime CreatedAt { get; set; }

    [JsonPropertyName("source_language")]
    public required int SourceLanguage { get; set; }

    [JsonPropertyName("target_languages")]
    public IEnumerable<int> TargetLanguages { get; set; } = new List<int>();

    [JsonPropertyName("duration")]
    public double? Duration { get; set; }

    [JsonPropertyName("folder_id")]
    public int? FolderId { get; set; }

    [JsonPropertyName("studio_url")]
    public required string StudioUrl { get; set; }
}
