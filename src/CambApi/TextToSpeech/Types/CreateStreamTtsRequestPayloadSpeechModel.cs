using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using CambApi.Core;

#nullable enable

namespace CambApi;

[JsonConverter(typeof(StringEnumSerializer<CreateStreamTtsRequestPayloadSpeechModel>))]
public enum CreateStreamTtsRequestPayloadSpeechModel
{
    [EnumMember(Value = "auto")]
    Auto,

    [EnumMember(Value = "mars-8")]
    Mars8,

    [EnumMember(Value = "mars-8-flash")]
    Mars8Flash,

    [EnumMember(Value = "mars-8-instruct")]
    Mars8Instruct,

    [EnumMember(Value = "mars-7")]
    Mars7,

    [EnumMember(Value = "mars-6")]
    Mars6
}
