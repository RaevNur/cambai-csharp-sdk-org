namespace CambApi;

public record GetProjectSetupRunsResultsProjectSetupResultsPostRequest
{
    public int? RunId { get; set; }

    public required RunIDsRequestPayload Body { get; set; }
}
