using System.Text.Json.Serialization;

#nullable enable

namespace CambApi;

public record CreateStreamRequestPayload
{
    /// <summary>
    /// The name of the stream.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The description of the stream.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// The initial delay in seconds before starting the stream creation process.
    /// </summary>
    [JsonPropertyName("initial_delay")]
    public int? InitialDelay { get; set; }

    /// <summary>
    /// The maximum duration in minutes for the stream creation process before timing out.
    /// </summary>
    [JsonPropertyName("timeout_in_mins")]
    public int? TimeoutInMins { get; set; }

    /// <summary>
    /// List of voice identifiers to be used in the stream.
    /// </summary>
    [JsonPropertyName("voices")]
    public IEnumerable<int> Voices { get; set; } = new List<int>();

    /// <summary>
    /// List of dictionary identifiers to be used in the stream.
    /// </summary>
    [JsonPropertyName("dictionaries")]
    public IEnumerable<int> Dictionaries { get; set; } = new List<int>();

    /// <summary>
    /// The shared configuration for the streaming pipeline.
    /// </summary>
    [JsonPropertyName("config")]
    public required ConfigStream Config { get; set; }

    /// <summary>
    /// The source stream configuration details.
    /// </summary>
    [JsonPropertyName("source_stream")]
    public required SourceStream SourceStream { get; set; }

    /// <summary>
    /// List of target stream configurations.
    /// </summary>
    [JsonPropertyName("target_streams")]
    public IEnumerable<TargetStream> TargetStreams { get; set; } = new List<TargetStream>();

    [JsonPropertyName("start_time")]
    public DateTime? StartTime { get; set; }

    [JsonPropertyName("end_time")]
    public DateTime? EndTime { get; set; }

    [JsonPropertyName("timezone")]
    public string? Timezone { get; set; }
}
