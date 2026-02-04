using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using CambApi.Core;

#nullable enable

namespace CambApi;

[JsonConverter(typeof(StringEnumSerializer<TextToAudioType>))]
public enum TextToAudioType
{
    [EnumMember(Value = "sound")]
    Sound,

    [EnumMember(Value = "music")]
    Music
}
