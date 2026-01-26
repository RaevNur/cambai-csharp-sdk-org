using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using CambApi.Core;

#nullable enable

namespace CambApi;

[JsonConverter(typeof(StringEnumSerializer<TaskStatus>))]
public enum TaskStatus
{
    [EnumMember(Value = "SUCCESS")]
    Success,

    [EnumMember(Value = "PENDING")]
    Pending,

    [EnumMember(Value = "ERROR")]
    Error
}
