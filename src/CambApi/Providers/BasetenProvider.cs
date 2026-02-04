using System;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using CambApi.Core;

namespace CambApi.Providers;

public record BasetenTtsRequestPayload : CreateStreamTtsRequestPayload
{
    public required string ReferenceAudio { get; set; }
    public required string ReferenceLanguage { get; set; }
}

public class BasetenProvider : ITtsProvider
{
    private readonly string _apiKey;
    private readonly string _url;
    private readonly HttpClient _httpClient;

    public BasetenProvider(string apiKey, string url = "https://model-5qeryx53.api.baseten.co/environments/production/predict")
    {
        _apiKey = apiKey;
        _url = url;
        _httpClient = new HttpClient();
    }

    public async Task<Stream> TtsAsync(CreateStreamTtsRequestPayload request, RequestOptions? options = null)
    {
        if (request is not BasetenTtsRequestPayload basetenReq)
        {
            throw new ArgumentException("Request must be of type BasetenTtsRequestPayload for BasetenProvider");
        }

        // Map Language enum to string (simplified)
        // Note: You might need a more robust mapper
        var langStr = request.Language.ToString().ToLower().Replace("_", "-");
        if (langStr == "enus") langStr = "en-us"; // Handle Enum specific naming if needed

        var payload = new
        {
            text = request.Text,
            stream = true,
            output_format = "mp3",
            language = langStr,
            reference_audio = basetenReq.ReferenceAudio,
            audio_ref = basetenReq.ReferenceAudio,
            reference_language = basetenReq.ReferenceLanguage,
            apply_ner_nlp = false
        };

        var json = JsonSerializer.Serialize(payload);
        var requestMessage = new HttpRequestMessage(HttpMethod.Post, _url);
        requestMessage.Headers.Add("Authorization", $"Api-Key {_apiKey}");
        requestMessage.Content = new StringContent(json, Encoding.UTF8, "application/json");

        var response = await _httpClient.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
        
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStreamAsync();
    }
}
