using System.Text.Json.Serialization;
using CambApi.Core;
using OneOf;

#nullable enable

namespace CambApi;

public record DubbedOutputInAltFormatRequestPayload
{
    [JsonPropertyName("output_format")]
    [JsonConverter(typeof(OneOfSerializer<OneOf<AudioOutputType, VideoOutputTypeWithoutAvi>>))]
    public required OneOf<AudioOutputType, VideoOutputTypeWithoutAvi> OutputFormat { get; set; }
}
