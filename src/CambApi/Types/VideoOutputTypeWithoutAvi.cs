using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using CambApi.Core;

#nullable enable

namespace CambApi;

[JsonConverter(typeof(StringEnumSerializer<VideoOutputTypeWithoutAvi>))]
public enum VideoOutputTypeWithoutAvi
{
    [EnumMember(Value = "mkv")]
    Mkv,

    [EnumMember(Value = "mp4")]
    Mp4,

    [EnumMember(Value = "mov")]
    Mov,

    [EnumMember(Value = "mxf")]
    Mxf
}
