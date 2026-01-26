namespace CambApi;

public record CreateProjectSetupRequestPayload
{
    public int? RunId { get; set; }

    public string? ProjectName { get; set; }

    public string? ProjectDescription { get; set; }

    public int? FolderId { get; set; }

    public required string MediaUrl { get; set; }

    public required int SourceLanguage { get; set; }

    public IEnumerable<int> TargetLanguages { get; set; } = new List<int>();

    public IEnumerable<int>? SelectedAudioTracks { get; set; }

    public bool? AddOutputAsAnAudioTrack { get; set; }

    public IEnumerable<int>? ChosenDictionaries { get; set; }
}
