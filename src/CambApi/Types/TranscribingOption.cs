using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using CambApi.Core;

#nullable enable

namespace CambApi;

[JsonConverter(typeof(StringEnumSerializer<TranscribingOption>))]
public enum TranscribingOption
{
    [EnumMember(Value = "none")]
    None,

    [EnumMember(Value = "best_model")]
    BestModel,

    [EnumMember(Value = "fast_model")]
    FastModel
}
