using System.Net.Http;
using System.Text.Json;
using CambApi.Core;

#nullable enable

namespace CambApi;

public partial class TextToAudioClient
{
    private RawClient _client;

    internal TextToAudioClient(RawClient client)
    {
        _client = client;
    }

    public async Task<OrchestratorPipelineCallResult> CreateTextToAudioAsync(
        CreateTextToAudioRequestPayload request,
        RequestOptions? options = null
    )
    {
        var _query = new Dictionary<string, object>() { };
        if (request.RunId != null)
        {
            _query["run_id"] = request.RunId.ToString();
        }
        var _headers = new Dictionary<string, string>() { };
        if (request.Traceparent != null)
        {
            _headers["traceparent"] = request.Traceparent;
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethod.Post,
                Path = "text-to-sound",
                Query = _query,
                Headers = _headers,
                Options = options
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<OrchestratorPipelineCallResult>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new CambApiException("Failed to deserialize response", e);
            }
        }

        try
        {
            switch (response.StatusCode)
            {
                case 422:
                    throw new UnprocessableEntityError(
                        JsonUtils.Deserialize<HttpValidationError>(responseBody)
                    );
            }
        }
        catch (JsonException)
        {
            // unable to map error response, throwing generic error
        }
        throw new CambApiApiException(
            $"Error with status code {response.StatusCode}",
            response.StatusCode,
            JsonUtils.Deserialize<object>(responseBody)
        );
    }

    public async Task<OrchestratorPipelineResult> GetTextToAudioStatusAsync(
        string taskId,
        GetTextToAudioStatusTextToSoundTaskIdGetRequest request,
        RequestOptions? options = null
    )
    {
        var _query = new Dictionary<string, object>() { };
        if (request.RunId != null)
        {
            _query["run_id"] = request.RunId.ToString();
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethod.Get,
                Path = $"text-to-sound/{taskId}",
                Query = _query,
                Options = options
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<OrchestratorPipelineResult>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new CambApiException("Failed to deserialize response", e);
            }
        }

        try
        {
            switch (response.StatusCode)
            {
                case 422:
                    throw new UnprocessableEntityError(
                        JsonUtils.Deserialize<HttpValidationError>(responseBody)
                    );
            }
        }
        catch (JsonException)
        {
            // unable to map error response, throwing generic error
        }
        throw new CambApiApiException(
            $"Error with status code {response.StatusCode}",
            response.StatusCode,
            JsonUtils.Deserialize<object>(responseBody)
        );
    }

    /// <summary>
    /// Retrieve the Text-to-Audio (TTA) result for a given run.
    ///
    /// This endpoint validates the provided run ID and retrieves the associated
    /// Text-to-Audio output. It supports two output formats:
    /// - RAW_BYTES: Streams the audio file in WAV format.
    /// - FILE_URL: Returns a pre-signed URL for downloading the audio file.
    ///
    /// The endpoint ensures that the run type is valid for Text-to-Audio processing
    /// and that the storage preferences are applied accordingly.
    ///
    /// Args:
    ///     run_id (int): Unique identifier for the TTA run.
    ///     traceparent (Optional[str]): Trace header for distributed tracing.
    ///     api_key_obj (dict): API key object containing authentication and storage preferences.
    ///     output_type (OutputType): Desired output format. Defaults to RAW_BYTES.
    ///
    /// Returns:
    ///     StreamingResponse | GetTTAOut:
    ///         - StreamingResponse: If output_type is RAW_BYTES, a streaming response with the audio in WAV format.
    ///         - GetTTAOut: If output_type is FILE_URL, a pre-signed URL to access the audio file.
    ///
    /// Raises:
    ///     HTTPException:
    ///         - 400 BAD REQUEST: If the run type is invalid for a TTA run.
    ///         - 500 INTERNAL SERVER ERROR: If the audio file cannot be fetched or streamed.
    /// </summary>
    public async Task GetTextToAudioResultAsync(
        int? runId,
        GetTextToAudioResultTextToSoundResultRunIdGetRequest request,
        RequestOptions? options = null
    )
    {
        var _query = new Dictionary<string, object>() { };
        if (request.OutputType != null)
        {
            _query["output_type"] = request.OutputType;
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethod.Get,
                Path = $"text-to-sound-result/{runId}",
                Query = _query,
                Options = options
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        throw new CambApiApiException(
            $"Error with status code {response.StatusCode}",
            response.StatusCode,
            JsonUtils.Deserialize<object>(responseBody)
        );
    }

    public async Task<Dictionary<string, TextToAudioResult>> GetTextToSoundResultsAsync(
        GetTextToSoundResultsTextToSoundResultsPostRequest request,
        RequestOptions? options = null
    )
    {
        var _query = new Dictionary<string, object>() { };
        if (request.RunId != null)
        {
            _query["run_id"] = request.RunId.ToString();
        }
        var _headers = new Dictionary<string, string>() { };
        if (request.Traceparent != null)
        {
            _headers["traceparent"] = request.Traceparent;
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethod.Post,
                Path = "text-to-sound-results",
                Body = request.Body,
                Query = _query,
                Headers = _headers,
                Options = options
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<Dictionary<string, TextToAudioResult>>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new CambApiException("Failed to deserialize response", e);
            }
        }

        try
        {
            switch (response.StatusCode)
            {
                case 422:
                    throw new UnprocessableEntityError(
                        JsonUtils.Deserialize<HttpValidationError>(responseBody)
                    );
            }
        }
        catch (JsonException)
        {
            // unable to map error response, throwing generic error
        }
        throw new CambApiApiException(
            $"Error with status code {response.StatusCode}",
            response.StatusCode,
            JsonUtils.Deserialize<object>(responseBody)
        );
    }
}
