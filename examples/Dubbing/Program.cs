using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CambApi;

namespace Dubbing;

class Program
{
    static async Task Main(string[] args)
    {
        var apiKey = Environment.GetEnvironmentVariable("CAMB_API_KEY");
        if (string.IsNullOrEmpty(apiKey))
        {
            Console.WriteLine("Please set CAMB_API_KEY environment variable.");
            return;
        }

        var client = new CambApiClient(apiKey);

        Console.WriteLine("Starting Dubbing Task...");

        try
        {
            var result = await client.Dub.CreateDubAsync(new EndToEndDubbingRequestPayload
            {
                VideoUrl = "https://example.com/video.mp4",
                SourceLanguage = (CreateStreamTtsRequestPayloadLanguage)CambApi.Constants.Languages.EN_US,
                TargetLanguages = new List<CreateStreamTtsRequestPayloadLanguage>
                {
                    (CreateStreamTtsRequestPayloadLanguage)CambApi.Constants.Languages.FR_FR,
                    (CreateStreamTtsRequestPayloadLanguage)CambApi.Constants.Languages.ES_ES
                }
            });

            Console.WriteLine($"Dubbing Task Created. Task ID: {result.TaskId}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
