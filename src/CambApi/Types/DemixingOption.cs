using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using CambApi.Core;

#nullable enable

namespace CambApi;

[JsonConverter(typeof(StringEnumSerializer<DemixingOption>))]
public enum DemixingOption
{
    [EnumMember(Value = "none")]
    None,

    [EnumMember(Value = "pick_left_channel")]
    PickLeftChannel,

    [EnumMember(Value = "pick_right_channel")]
    PickRightChannel,

    [EnumMember(Value = "pick_center_channel")]
    PickCenterChannel,

    [EnumMember(Value = "best_model")]
    BestModel,

    [EnumMember(Value = "fast_model")]
    FastModel
}
