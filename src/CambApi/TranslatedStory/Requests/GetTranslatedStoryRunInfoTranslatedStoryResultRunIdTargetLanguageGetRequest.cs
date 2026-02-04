namespace CambApi;

public record GetTranslatedStoryRunInfoTranslatedStoryResultRunIdTargetLanguageGetRequest
{
    /// <summary>
    /// Whether to include the transcription in the response for fetching the result of a Stories Translation run.
    /// </summary>
    public bool? IncludeTranscript { get; set; }
}
