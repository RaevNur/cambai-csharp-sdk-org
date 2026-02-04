using System.IO;
using System.Threading.Tasks;
using CambApi.Core;

namespace CambApi.Providers;

public interface ITtsProvider
{
    Task<Stream> TtsAsync(CreateStreamTtsRequestPayload request, RequestOptions? options = null);
}
