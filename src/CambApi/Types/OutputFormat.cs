using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using CambApi.Core;

#nullable enable

namespace CambApi;

[JsonConverter(typeof(StringEnumSerializer<OutputFormat>))]
public enum OutputFormat
{
    [EnumMember(Value = "wav")]
    Wav,

    [EnumMember(Value = "flac")]
    Flac,

    [EnumMember(Value = "adts")]
    Adts,

    [EnumMember(Value = "mp3")]
    Mp3,

    [EnumMember(Value = "pcm_s16le")]
    PcmS16Le,

    [EnumMember(Value = "pcm_s16be")]
    PcmS16Be,

    [EnumMember(Value = "pcm_s32be")]
    PcmS32Be,

    [EnumMember(Value = "pcm_s32le")]
    PcmS32Le,

    [EnumMember(Value = "pcm_f32le")]
    PcmF32Le,

    [EnumMember(Value = "pcm_f32be")]
    PcmF32Be
}
