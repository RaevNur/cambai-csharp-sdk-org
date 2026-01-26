using System;
using System.Net.Http;
using System.Text.Json;
using CambApi.Core;

#nullable enable

namespace CambApi;

public partial class CambApiClient
{
    private RawClient _client;

    public CambApiClient(string? apiKey = null, ClientOptions? clientOptions = null)
    {
        _client = new RawClient(
            new Dictionary<string, string>()
            {
                { "x-api-key", apiKey },
                { "X-Fern-Language", "C#" },
            },
            new Dictionary<string, Func<string>>() { },
            clientOptions ?? new ClientOptions()
        );
        AudioSeparation = new AudioSeparationClient(_client);
        Dub = new DubClient(_client);
        Folders = new FoldersClient(_client);
        Languages = new LanguagesClient(_client);
        Story = new StoryClient(_client);
        TranslatedStory = new TranslatedStoryClient(_client);
        TextToAudio = new TextToAudioClient(_client);
        TextToVoice = new TextToVoiceClient(_client);
        TextToSpeech = new TextToSpeechClient(_client);
        Translation = new TranslationClient(_client);
        Transcription = new TranscriptionClient(_client);
        TranslatedTts = new TranslatedTtsClient(_client);
        Streaming = new StreamingClient(_client);
        VoiceCloning = new VoiceCloningClient(_client);
        Dictionaries = new DictionariesClient(_client);
        ProjectSetup = new ProjectSetupClient(_client);
        DeprecatedStreaming = new DeprecatedStreamingClient(_client);
    }

    public AudioSeparationClient AudioSeparation { get; init; }

    public DubClient Dub { get; init; }

    public FoldersClient Folders { get; init; }

    public LanguagesClient Languages { get; init; }

    public StoryClient Story { get; init; }

    public TranslatedStoryClient TranslatedStory { get; init; }

    public TextToAudioClient TextToAudio { get; init; }

    public TextToVoiceClient TextToVoice { get; init; }

    public TextToSpeechClient TextToSpeech { get; init; }

    public TranslationClient Translation { get; init; }

    public TranscriptionClient Transcription { get; init; }

    public TranslatedTtsClient TranslatedTts { get; init; }

    public StreamingClient Streaming { get; init; }

    public VoiceCloningClient VoiceCloning { get; init; }

    public DictionariesClient Dictionaries { get; init; }

    public ProjectSetupClient ProjectSetup { get; init; }

    public DeprecatedStreamingClient DeprecatedStreaming { get; init; }

    public async Task<object> GetSwaggerDocsDocsGetAsync(RequestOptions? options = null)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethod.Get,
                Path = "docs",
                Options = options
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<object>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new CambApiException("Failed to deserialize response", e);
            }
        }

        throw new CambApiApiException(
            $"Error with status code {response.StatusCode}",
            response.StatusCode,
            JsonUtils.Deserialize<object>(responseBody)
        );
    }

    public async Task<object> GetRedocDocsRedocsGetAsync(RequestOptions? options = null)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethod.Get,
                Path = "redocs",
                Options = options
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<object>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new CambApiException("Failed to deserialize response", e);
            }
        }

        throw new CambApiApiException(
            $"Error with status code {response.StatusCode}",
            response.StatusCode,
            JsonUtils.Deserialize<object>(responseBody)
        );
    }

    public async Task<object> GetOpenapiSchemaOpenapiJsonGetAsync(RequestOptions? options = null)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethod.Get,
                Path = "openapi.json",
                Options = options
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<object>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new CambApiException("Failed to deserialize response", e);
            }
        }

        throw new CambApiApiException(
            $"Error with status code {response.StatusCode}",
            response.StatusCode,
            JsonUtils.Deserialize<object>(responseBody)
        );
    }
}
