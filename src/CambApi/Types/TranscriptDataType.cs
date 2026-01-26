using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using CambApi.Core;

#nullable enable

namespace CambApi;

[JsonConverter(typeof(StringEnumSerializer<TranscriptDataType>))]
public enum TranscriptDataType
{
    [EnumMember(Value = "raw_data")]
    RawData,

    [EnumMember(Value = "file")]
    File
}
