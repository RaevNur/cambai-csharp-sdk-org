namespace CambApi;

public record GetTextToVoiceStatusTextToVoiceTaskIdGetRequest
{
    public int? RunId { get; set; }

    public string? Traceparent { get; set; }
}
