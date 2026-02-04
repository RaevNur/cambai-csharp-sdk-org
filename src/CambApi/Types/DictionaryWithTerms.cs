using System.Text.Json.Serialization;

#nullable enable

namespace CambApi;

public record DictionaryWithTerms
{
    [JsonPropertyName("id")]
    public required int Id { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("created_at")]
    public DateTime? CreatedAt { get; set; }

    [JsonPropertyName("last_edited_at")]
    public DateTime? LastEditedAt { get; set; }

    [JsonPropertyName("dictionary_terms")]
    public IEnumerable<DictionaryTerm>? DictionaryTerms { get; set; }

    [JsonPropertyName("languages")]
    public IEnumerable<int>? Languages { get; set; }
}
