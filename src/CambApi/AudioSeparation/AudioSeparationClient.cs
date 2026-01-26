using System.Net.Http;
using System.Text.Json;
using CambApi.Core;

#nullable enable

namespace CambApi;

public partial class AudioSeparationClient
{
    private RawClient _client;

    internal AudioSeparationClient(RawClient client)
    {
        _client = client;
    }

    public async Task<OrchestratorPipelineCallResult> CreateAudioSeparationAsync(
        BodyCreateAudioSeparationAudioSeparationPost request,
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
                Path = "audio-separation",
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

    public async Task<OrchestratorPipelineResult> GetAudioSeparationStatusAsync(
        string taskId,
        GetAudioSeparationStatusAudioSeparationTaskIdGetRequest request,
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
                Path = $"audio-separation/{taskId}",
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

    public async Task<GetAudioSeparationResultOut> GetAudioSeparationRunInfoAsync(
        int? runId,
        GetAudioSeparationRunInfoAudioSeparationResultRunIdGetRequest request,
        RequestOptions? options = null
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethod.Get,
                Path = $"audio-separation-result/{runId}",
                Options = options
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<GetAudioSeparationResultOut>(responseBody)!;
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

    public async Task<
        Dictionary<string, GetAudioSeparationResultOut>
    > GetAudioSeparationRunsResultsAsync(
        GetAudioSeparationRunsResultsAudioSeparationResultsPostRequest request,
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
                Path = "audio-separation-results",
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
                return JsonUtils.Deserialize<Dictionary<string, GetAudioSeparationResultOut>>(
                    responseBody
                )!;
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
