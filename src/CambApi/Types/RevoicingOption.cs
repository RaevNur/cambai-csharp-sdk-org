using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using CambApi.Core;

#nullable enable

namespace CambApi;

[JsonConverter(typeof(StringEnumSerializer<RevoicingOption>))]
public enum RevoicingOption
{
    [EnumMember(Value = "none")]
    None,

    [EnumMember(Value = "best_model")]
    BestModel,

    [EnumMember(Value = "fast_model")]
    FastModel
}
