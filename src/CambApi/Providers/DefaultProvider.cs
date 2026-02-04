using System.IO;
using System.Threading.Tasks;
using CambApi.Core;

namespace CambApi.Providers;

public class DefaultProvider : ITtsProvider
{
    private readonly CambApiClient _client;

    public DefaultProvider(CambApiClient client)
    {
        _client = client;
    }

    public Task<Stream> TtsAsync(CreateStreamTtsRequestPayload request, RequestOptions? options = null)
    {
        return _client.TextToSpeech.TtsAsync(request, options);
    }
}
