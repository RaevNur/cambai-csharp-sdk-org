using System.Text.Json.Serialization;

#nullable enable

namespace CambApi;

public record GetSetupStoryResultResponse
{
    [JsonPropertyName("run_id")]
    public required int RunId { get; set; }

    [JsonPropertyName("story_details")]
    public required StoryDetails StoryDetails { get; set; }
}
