namespace CambApi;

public record GetDictionaryDetailsDictionariesDictionaryIdFullDetailsGetRequest
{
    /// <summary>
    /// Limit how many terms are returned when fetching the dictionary details.
    /// </summary>
    public int? Limit { get; set; }

    public string? SearchTerm { get; set; }

    public int? RunId { get; set; }
}
