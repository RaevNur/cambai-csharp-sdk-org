using System.Text.Json.Serialization;

#nullable enable

namespace CambApi;

public record GetProbeStreamOut
{
    [JsonPropertyName("video_streams")]
    public IEnumerable<VideoStream> VideoStreams { get; set; } = new List<VideoStream>();

    [JsonPropertyName("audio_streams")]
    public IEnumerable<AudioStream> AudioStreams { get; set; } = new List<AudioStream>();

    [JsonPropertyName("data_streams")]
    public IEnumerable<DataStream> DataStreams { get; set; } = new List<DataStream>();
}
