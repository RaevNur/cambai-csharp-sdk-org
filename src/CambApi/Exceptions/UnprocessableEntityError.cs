using CambApi.Core;

#nullable enable

namespace CambApi;

/// <summary>
/// This exception type will be thrown for any non-2XX API responses.
/// </summary>
public class UnprocessableEntityError(HttpValidationError body)
    : CambApiApiException("UnprocessableEntityError", 422, body)
{
    /// <summary>
    /// The body of the response that triggered the exception.
    /// </summary>
    public new HttpValidationError Body { get; } = body;
}
