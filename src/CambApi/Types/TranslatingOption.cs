using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using CambApi.Core;

#nullable enable

namespace CambApi;

[JsonConverter(typeof(StringEnumSerializer<TranslatingOption>))]
public enum TranslatingOption
{
    [EnumMember(Value = "none")]
    None,

    [EnumMember(Value = "best_model")]
    BestModel,

    [EnumMember(Value = "fast_model")]
    FastModel
}
