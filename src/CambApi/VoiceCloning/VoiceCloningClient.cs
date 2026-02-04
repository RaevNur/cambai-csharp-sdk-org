using System.Net.Http;
using System.Text.Json;
using CambApi.Core;
using OneOf;

#nullable enable

namespace CambApi;

public partial class VoiceCloningClient
{
    private RawClient _client;

    internal VoiceCloningClient(RawClient client)
    {
        _client = client;
    }

    public async Task<IEnumerable<OneOf<Dictionary<string, object?>, Voice>>> ListVoicesAsync(
        ListVoicesListVoicesGetRequest request,
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
                Path = "list-voices",
                Query = _query,
                Options = options
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<
                    IEnumerable<OneOf<Dictionary<string, object?>, Voice>>
                >(responseBody)!;
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

    public async Task<CreateCustomVoiceOut> CreateCustomVoiceAsync(
        BodyCreateCustomVoiceCreateCustomVoicePost request,
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
                Method = HttpMethod.Post,
                Path = "create-custom-voice",
                Query = _query,
                Options = options
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<CreateCustomVoiceOut>(responseBody)!;
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
