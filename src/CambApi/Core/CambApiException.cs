using System;

#nullable enable

namespace CambApi.Core;

/// <summary>
/// Base exception class for all exceptions thrown by the SDK.
/// </summary>
public class CambApiException(string message, Exception? innerException = null)
    : Exception(message, innerException) { }
