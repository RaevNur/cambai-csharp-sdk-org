using System.Net.Http;
using System.Text.Json;
using CambApi.Core;

#nullable enable

namespace CambApi;

public partial class ProjectSetupClient
{
    private RawClient _client;

    internal ProjectSetupClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Creates a new project setup with transcription capabilities.
    ///
    /// This endpoint allows users to create a new project by providing media content
    /// (either as a file upload or URL), specifying source and target languages, and
    /// other project metadata. The function validates inputs, checks file size limitations,
    /// and initiates the project setup process.
    ///
    /// Args:
    ///     request_payload (CreateProjectSetupRequestPayload): Complete project configuration
    ///             including media URL, source/target languages, project metadata, and
    ///             processing preferences such as audio track selection and dictionary choices.
    ///         api_key_obj_and_subscription: Dependency injection providing validated API key
    ///             object and associated subscription details for authorization and usage
    ///             limit enforcement.
    ///         traceparent (str | None, optional): OpenTelemetry trace parent header for
    ///             distributed tracing across microservices. Enables request correlation
    ///             and performance monitoring throughout the processing pipeline.
    ///
    /// Returns:
    ///     Project setup response with project details and processing status.
    ///
    /// Raises:
    ///     HTTPException:
    ///         - 400: If neither media_file nor media_url is provided
    ///         - 400: If uploaded file has no filename
    ///         - 413: If uploaded file exceeds size limit
    /// </summary>
    public async Task<CreateProjectSetupOut> CreateProjectAsync(
        CreateProjectSetupRequestPayload request,
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
                Path = "project-setup",
                Query = _query,
                Options = options
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<CreateProjectSetupOut>(responseBody)!;
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

    public async Task<IEnumerable<GetCreateProjectSetupResponse>> CreateProjectSetupTaskStatusAsync(
        string taskId,
        CreateProjectSetupTaskStatusProjectSetupTaskIdGetRequest request,
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
                Path = $"project-setup/{taskId}",
                Query = _query,
                Options = options
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<IEnumerable<GetCreateProjectSetupResponse>>(
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

    /// <summary>
    /// Retrieves the final result of a completed project setup.
    ///
    /// This endpoint provides access to the final results of a completed project setup.
    /// It verifies that the authenticated user has access to the requested run_id and
    /// validates that the run is of the correct type (`DUB_PROJECT`) before returning results.
    ///
    /// Note:
    ///     This endpoint should only be called by users to retrieve their run results via API.
    ///     Access validation is performed to ensure users can only access their own runs.
    ///
    /// Args:
    ///     run_id: Positive integer ID of the project setup run.
    ///     api_key_obj: API key authentication data from dependency.
    ///     traceparent: OpenTelemetry trace header for distributed tracing.
    ///
    /// Returns:
    ///     GetCreateProjectSetupResponse: Project setup results including run details.
    ///
    /// Raises:
    ///     HTTPException:
    ///         - 404: If the run_id is not found
    ///         - 400: If the run type is not valid for this endpoint (must be DUB_PROJECT)
    /// </summary>
    public async Task<GetCreateProjectSetupResponse?> GetProjectSetupResultAsync(
        int? runId,
        GetProjectSetupResultProjectSetupResultRunIdGetRequest request,
        RequestOptions? options = null
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethod.Get,
                Path = $"project-setup-result/{runId}",
                Options = options
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<GetCreateProjectSetupResponse?>(responseBody)!;
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

    public async Task<IEnumerable<GetCreateProjectSetupResponse>> GetProjectSetupRunsResultsAsync(
        GetProjectSetupRunsResultsProjectSetupResultsPostRequest request,
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
                Path = "project-setup-results",
                Body = request.Body,
                Query = _query,
                Options = options
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<IEnumerable<GetCreateProjectSetupResponse>>(
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
