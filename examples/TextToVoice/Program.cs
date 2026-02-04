using System;
using System.Threading.Tasks;
using CambApi;

namespace TextToVoice;

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

        Console.WriteLine("Generating new voice...");

        try
        {
            var result = await client.TextToVoice.CreateTextToVoiceAsync(new CreateTextToVoiceRequestPayload
            {
                Text = "A calm and soothing voice for meditation apps.",
                VoiceDescription = "Soft, slow-paced, and gentle female voice with a British accent.",
                Gender = Gender.Female,
                Age = 30
            });

            Console.WriteLine($"Voice Generation Task ID: {result.TaskId}");
            
            // Note: Polling logic would go here.
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
