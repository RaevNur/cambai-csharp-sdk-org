# C# SDK Quickstart

Get started with the Camb.ai C# SDK in minutes

## Overview

The Camb.ai C# SDK provides a simple interface to integrate high-quality text-to-speech into your applications. This quickstart will have you generating speech in under 5 minutes.

## Installation

Install the package via NuGet:

```bash
dotnet add package CambApi
```

## Authentication

Get your API key from [CAMB.AI Studio](https://studio.camb.ai/) and set it as an environment variable:

```bash
export CAMB_API_KEY=your_api_key_here
```

## Quick Start

### Streaming Text-to-Speech

Generate and stream speech in real-time. The SDK returns a `Stream` for the audio data:

```csharp
using CambApi;

// Initialize the client
var client = new CambApiClient(Environment.GetEnvironmentVariable("CAMB_API_KEY"));

// Stream TTS audio
var responseStream = await client.TextToSpeech.TtsAsync(new CreateStreamTtsRequestPayload
{
    Text = "Hello! Welcome to Camb.ai text-to-speech.",
    Language = CreateStreamTtsRequestPayloadLanguage.EnUs,
    VoiceId = 147320,
    SpeechModel = CreateStreamTtsRequestPayloadSpeechModel.Mars8Flash,
    OutputConfiguration = new StreamTtsOutputConfiguration
    {
        Format = OutputFormat.Wav
    }
});

// Save to file
using var fileStream = File.Create("output.wav");
await responseStream.CopyToAsync(fileStream);

Console.WriteLine("Success! Audio saved to output.wav");
```

### Using the Helper Function

You can easily wrap the stream saving into a helper method:

```csharp
public static async Task SaveStreamToFileAsync(Stream stream, string filename)
{
    using var fileStream = File.Create(filename);
    await stream.CopyToAsync(fileStream);
}

// Usage:
var stream = await client.TextToSpeech.TtsAsync(payload);
await SaveStreamToFileAsync(stream, "output.wav");
```

## Choosing a Model

Camb.ai offers three MARS models optimized for different use cases:

### MARS Flash

```csharp
SpeechModel = CreateStreamTtsRequestPayloadSpeechModel.Mars8Flash
```

**Best for**: Real-time voice agents, low-latency applications  
**Sample rate**: 22.05kHz

### MARS Pro

```csharp
SpeechModel = CreateStreamTtsRequestPayloadSpeechModel.Mars8Pro
```

**Best for**: Audio production, high-quality content  
**Sample rate**: 48kHz

### MARS Instruct

```csharp
SpeechModel = CreateStreamTtsRequestPayloadSpeechModel.Mars8Instruct,
UserInstructions = "Speak in a warm, friendly tone"
```

**Best for**: Fine-grained control over tone and style  
**Sample rate**: 22.05kHz

## Listing Available Voices

Discover available voices for your application:

```csharp
var voices = await client.VoiceCloning.ListVoicesAsync();

foreach (var voice in voices)
{
    Console.WriteLine($"ID: {voice.Id}, Name: {voice.VoiceName}, Gender: {voice.Gender}");
}
```

## Language Support

Camb.ai supports 140+ languages. Specify the language using the `CreateStreamTtsRequestPayloadLanguage` enum:
Languages supported by each model mentioned at [MARS Models](https://docs.camb.ai/models).

```csharp
// English (US)
Language = CreateStreamTtsRequestPayloadLanguage.EnUs

// Spanish
Language = CreateStreamTtsRequestPayloadLanguage.EsEs

// French
Language = CreateStreamTtsRequestPayloadLanguage.FrFr
```

## Error Handling

Handle common errors gracefully:

```csharp
try 
{
    var stream = await client.TextToSpeech.TtsAsync(payload);
}
catch (Exception ex)
{
    Console.WriteLine($"Error generating speech: {ex.Message}");
}
```

## Using Custom Provider

For more details check this guide [Custom Cloud Providers](https://docs.camb.ai/custom-cloud-providers)

### Baseten Deployment

Initialize the client with your custom provider implementation. [Baseten Provider Example](https://github.com/Camb-ai/cambai-csharp-sdk/tree/master/examples/BasetenProvider)

```csharp
using CambApi.Providers;

var ttsProvider = new BasetenProvider(
    apiKey: "YOUR_BASETEN_API_KEY",
    url: "YOUR_BASETEN_URL"
);
```

## Next Steps

| | |
| --- | --- |
| **🎙️ Voice Agents** <br> Build real-time voice agents with Pipecat <br> [Learn more](/tutorials/pipecat) | **🔗 LiveKit Integration** <br> Create voice agents with LiveKit <br> [Learn more](/tutorials/livekit) |
| **📄 API Reference** <br> Explore the full TTS API <br> [Learn more](/api-reference/endpoint/create-tts-stream) | **🔊 Voice Library** <br> Browse available voices <br> [Learn more](/api-reference/endpoint/list-voices) |

## Resources

* [GitHub: camb-ai/cambai-csharp-sdk](https://github.com/Camb-ai/cambai-csharp-sdk)
* [SDK Examples](https://github.com/Camb-ai/cambai-csharp-sdk/tree/master/examples)
* [API Reference](https://docs.camb.ai/api-reference/endpoint/create-tts-stream)
