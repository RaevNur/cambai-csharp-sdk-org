namespace CambApi;

public record GetProbeStreamStreamProbePostRequest
{
    public int? RunId { get; set; }

    public required GetProbeStreamIn Body { get; set; }
}
