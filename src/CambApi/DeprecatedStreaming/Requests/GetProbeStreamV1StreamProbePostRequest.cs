namespace CambApi;

public record GetProbeStreamV1StreamProbePostRequest
{
    public int? RunId { get; set; }

    public string? Traceparent { get; set; }

    public required GetProbeStreamIn Body { get; set; }
}
