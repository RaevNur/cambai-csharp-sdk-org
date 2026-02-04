namespace CambApi;

public record CreateTextToVoiceRequestPayload
{
    public string? Traceparent { get; set; }

    public string? ProjectName { get; set; }

    public string? ProjectDescription { get; set; }

    public int? FolderId { get; set; }

    /// <summary>
    /// The text to be converted to voice
    /// </summary>
    public required string Text { get; set; }

    /// <summary>
    /// Description to use for the created voice
    /// </summary>
    public required string VoiceDescription { get; set; }
}
