namespace CambApi;

public record CreateTtsRequestPayload
{
    public int? RunId { get; set; }

    public string? ProjectName { get; set; }

    public string? ProjectDescription { get; set; }

    public int? FolderId { get; set; }

    public required string Text { get; set; }

    public required int VoiceId { get; set; }

    public required int Language { get; set; }

    public int? Gender { get; set; }

    public int? Age { get; set; }
}
