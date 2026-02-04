namespace CambApi;

public record CreateTextToAudioRequestPayload
{
    public int? RunId { get; set; }

    public string? Traceparent { get; set; }

    public string? ProjectName { get; set; }

    public string? ProjectDescription { get; set; }

    public int? FolderId { get; set; }

    /// <summary>
    /// The text to be converted to audio.
    /// </summary>
    public required string Prompt { get; set; }

    /// <summary>
    /// The desired duration of the audio.
    /// </summary>
    public double? Duration { get; set; }

    /// <summary>
    /// The audio type preference.
    /// </summary>
    public TextToAudioType? AudioType { get; set; }
}
