namespace CambApi;

public record EndToEndDubbingRequestPayload
{
    public int? RunId { get; set; }

    public string? ProjectName { get; set; }

    public string? ProjectDescription { get; set; }

    public int? FolderId { get; set; }

    public required string VideoUrl { get; set; }

    public required int SourceLanguage { get; set; }

    public int? TargetLanguage { get; set; }

    public IEnumerable<int>? TargetLanguages { get; set; }

    public IEnumerable<int>? SelectedAudioTracks { get; set; }

    public bool? AddOutputAsAnAudioTrack { get; set; }

    public IEnumerable<int>? ChosenDictionaries { get; set; }

    public bool? AiOptimization { get; set; }
}
