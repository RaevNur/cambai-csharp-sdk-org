using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using CambApi.Core;

#nullable enable

namespace CambApi;

[JsonConverter(typeof(StringEnumSerializer<AudioOutputType>))]
public enum AudioOutputType
{
    [EnumMember(Value = "flac")]
    Flac,

    [EnumMember(Value = "wav")]
    Wav,

    [EnumMember(Value = "mp3")]
    Mp3,

    [EnumMember(Value = "aac")]
    Aac,

    [EnumMember(Value = "m4a")]
    M4A
}
