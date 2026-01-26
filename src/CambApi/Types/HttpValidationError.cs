using System.Text.Json.Serialization;

#nullable enable

namespace CambApi;

public record HttpValidationError
{
    [JsonPropertyName("detail")]
    public IEnumerable<ValidationError>? Detail { get; set; }
}
