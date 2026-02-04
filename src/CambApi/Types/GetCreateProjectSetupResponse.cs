using System.Text.Json.Serialization;

#nullable enable

namespace CambApi;

public record GetCreateProjectSetupResponse
{
    [JsonPropertyName("run_id")]
    public required int RunId { get; set; }

    [JsonPropertyName("project_details")]
    public required ProjectDetails ProjectDetails { get; set; }
}
