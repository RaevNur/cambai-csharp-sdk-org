namespace CambApi;

public record GetStoryRunInfoStoryResultRunIdGetRequest
{
    /// <summary>
    /// Whether to include the transcription in the response for fetching the result of a Stories run.
    /// </summary>
    public bool? IncludeTranscript { get; set; }
}
