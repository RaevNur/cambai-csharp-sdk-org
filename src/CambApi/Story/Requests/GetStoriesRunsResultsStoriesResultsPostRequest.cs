namespace CambApi;

public record GetStoriesRunsResultsStoriesResultsPostRequest
{
    public int? RunId { get; set; }

    public string? Traceparent { get; set; }

    public required RunIDsRequestPayload Body { get; set; }
}
