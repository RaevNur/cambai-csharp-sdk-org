namespace CambApi;

public record GetTtsResultsTtsResultsPostRequest
{
    public int? RunId { get; set; }

    public string? Traceparent { get; set; }

    public required RunIDsRequestPayload Body { get; set; }
}
