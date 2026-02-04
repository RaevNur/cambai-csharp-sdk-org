namespace CambApi;

public record GetTtsRunInfoTtsResultRunIdGetRequest
{
    /// <summary>
    /// Output format for the Text To Speech result
    /// </summary>
    public string? OutputType { get; set; }
}
