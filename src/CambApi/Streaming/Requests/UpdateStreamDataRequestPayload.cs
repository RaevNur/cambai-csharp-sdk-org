namespace CambApi;

public record UpdateStreamDataRequestPayload
{
    public int? RunId { get; set; }

    public DateTime? StartTime { get; set; }

    public DateTime? EndTime { get; set; }

    public Dictionary<string, object?>? Payload { get; set; }

    public IEnumerable<int>? TargetLanguages { get; set; }

    public string? Timezone { get; set; }
}
