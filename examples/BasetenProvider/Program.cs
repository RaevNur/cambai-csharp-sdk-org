using System;
using System.IO;
using System.Threading.Tasks;
using CambApi;
using CambApi.Providers;

namespace BasetenProviderExample;

class Program
{
    static async Task Main(string[] args)
    {
        var apiKey = Environment.GetEnvironmentVariable("BASETEN_API_KEY");
        var url = Environment.GetEnvironmentVariable("BASETEN_URL"); // Optional

        if (string.IsNullOrEmpty(apiKey))
        {
            Console.WriteLine("Please set BASETEN_API_KEY environment variable.");
            return;
        }

        // Initialize Custom Provider
        // Note: In a real app, you might inject ITtsProvider
        ITtsProvider ttsProvider = new BasetenProvider(apiKey, url ?? "https://model-5qeryx53.api.baseten.co/environments/production/predict");

        Console.WriteLine("Sending TTS request to Baseten...");

        try
        {
            // Use Baseten-specific payload
            var req = new BasetenTtsRequestPayload
            {
                Text = "Hello from C# Custom Provider via Baseten!",
                VoiceId = 0, // Ignored
                Language = (CreateStreamTtsRequestPayloadLanguage)CambApi.Constants.Languages.EN_US,
                ReferenceAudio = "UklGRi...", // Dummy base64 wav
                ReferenceLanguage = "en-us"
            };

            var responseStream = await ttsProvider.TtsAsync(req);

            var outputPath = "baseten_output.mp3";
            using (var fileStream = File.Create(outputPath))
            {
                await responseStream.CopyToAsync(fileStream);
            }

            Console.WriteLine($"Success! Audio saved to {outputPath}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
