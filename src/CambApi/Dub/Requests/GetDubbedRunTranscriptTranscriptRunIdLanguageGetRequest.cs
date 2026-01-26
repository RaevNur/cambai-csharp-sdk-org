namespace CambApi;

public record GetDubbedRunTranscriptTranscriptRunIdLanguageGetRequest
{
    /// <summary>
    /// Format to use for the transcription. Either `srt`, `vtt` or `txt`. Defaults to `txt`.
    /// </summary>
    public TranscriptFileFormat? FormatType { get; set; }

    /// <summary>
    /// Data type for the transcription being returned. Returns the raw data of the transcription or a presigned url for the file that holds the transcription data.
    /// </summary>
    public TranscriptDataType? DataType { get; set; }
}
