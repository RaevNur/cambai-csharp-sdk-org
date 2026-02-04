using System;
using System.IO;
using System.Threading.Tasks;
using CambApi;

namespace BasicTts;

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

        Console.WriteLine("Sending TTS request...");

        try
        {
            var responseStream = await client.TextToSpeech.TtsAsync(new CreateStreamTtsRequestPayload
            {
                Text = "Hello from Camb AI! This is a C# SDK test.",
                VoiceId = 20303, // Change to a valid voice ID if needed
                Language = (CreateStreamTtsRequestPayloadLanguage)CambApi.Constants.Languages.EN_US,
                SpeechModel = CreateStreamTtsRequestPayloadSpeechModel.MarsPro,
                OutputConfiguration = new StreamTtsOutputConfiguration
                {
                    Format = OutputFormat.Mp3
                }
            });

            var outputPath = "output.mp3";
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
