# Camb.ai C# SDK

The official C# SDK for interacting with Camb AI's powerful voice and audio generation APIs. Create expressive speech, unique voices, and rich soundscapes with just a few lines of C#.

## ✨ Features

- **Dubbing**: Dub your videos into multiple languages with voice cloning!
- **Expressive Text-to-Speech**: Convert text into natural-sounding speech using a wide range of pre-existing voices.
- **Generative Voices**: Create entirely new, unique voices from text prompts and descriptions.
- **Soundscapes from Text**: Generate ambient audio and sound effects from textual descriptions.
- Access to voice cloning, translation, and more (refer to full API documentation).

## 📦 Installation

Install the package via NuGet:

```bash
dotnet add package CambApi
```

## 🔑 Authentication & Accessing Clients

To use the Camb AI SDK, you'll need an API key.

```csharp
using CambApi;

var client = new CambApiClient("YOUR_CAMB_API_KEY");
```

### Client with Specific MARS Pro Provider (e.g. Baseten)

You can use the **TtsProvider** pattern to switch between the default Camb.ai provider and custom providers like Baseten.

#### Baseten Provider

To deploy the model go to models from baseten example: https://www.baseten.co/library/mars6/ and deploy then perform setup like below.

(See `examples/BasetenProvider` for full implementation details)

```csharp
// Initialize custom provider
var ttsProvider = new BasetenProvider(
    apiKey: "YOUR_BASETEN_API_KEY",
    url: "YOUR_BASETEN_URL" // Optional, defaults to production URL
);

// Unified interface call using the custom provider
// Note: Requires passing ITtsProvider or similar abstraction in your app
```

## 🚀 Getting Started: Examples

NOTE: For more examples and full runnable files refer to the `examples/` directory.

### 1. Text-to-Speech (TTS)

Convert text into spoken audio using one of Camb AI's high-quality voices.

```csharp
using CambApi;

var client = new CambApiClient("YOUR_API_KEY");

var response = await client.TextToSpeech.TtsAsync(new CreateStreamTtsRequestPayload
{
    Text = "Hello from Camb AI! This is a test.",
    VoiceId = 20303,
    Language = CreateStreamTtsRequestPayloadLanguage.EnUs,
    SpeechModel = CreateStreamTtsRequestPayloadSpeechModel.MarsPro,
    OutputConfiguration = new StreamTtsOutputConfiguration
    {
        Format = OutputFormat.Mp3
    }
});

// Response is a Stream, save to file
using var fileStream = File.Create("output.mp3");
await response.CopyToAsync(fileStream);
```

### 2. Text-to-Voice (Generative Voice)

Create completely new and unique voices from a textual description.

```csharp
var result = await client.TextToVoice.CreateTextToVoiceAsync(new CreateTextToVoiceRequestPayload
{
    Text = "A smooth, rich baritone voice.",
    VoiceDescription = "Ideal for storytelling."
});

// Result contains IDs or URLs to samples
```

### 3. Text-to-Audio (Sound Generation)

Generate sound effects or ambient audio.

```csharp
var response = await client.TextToAudio.CreateTextToAudioAsync(new CreateTextToAudioRequestPayload
{
    Prompt = "A gentle breeze rustling through autumn leaves.",
    Duration = 10,
    AudioType = TextToAudioType.Sound
});

// Check status loop...
```

### 4. End-to-End Dubbing

Dub videos into different languages.

```csharp
var result = await client.Dub.CreateDubAsync(new EndToEndDubbingRequestPayload
{
    VideoUrl = "your_video_url",
    SourceLanguage = CreateStreamTtsRequestPayloadLanguage.EnUs, // Use appropriate language enum
    TargetLanguages = new List<CreateStreamTtsRequestPayloadLanguage> { CreateStreamTtsRequestPayloadLanguage.FrFr }
});
```

## License

This project is licensed under the MIT License.
