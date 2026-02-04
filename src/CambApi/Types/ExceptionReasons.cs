using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using CambApi.Core;

#nullable enable

namespace CambApi;

[JsonConverter(typeof(StringEnumSerializer<ExceptionReasons>))]
public enum ExceptionReasons
{
    [EnumMember(Value = "HARMFUL_CONTENT_DETECTED")]
    HarmfulContentDetected,

    [EnumMember(Value = "VOICE_CONVERSION_ERROR")]
    VoiceConversionError,

    [EnumMember(Value = "PROCESSING_ERROR")]
    ProcessingError,

    [EnumMember(Value = "SOURCE_TOO_LONG")]
    SourceTooLong,

    [EnumMember(Value = "SOURCE_TOO_LARGE")]
    SourceTooLarge,

    [EnumMember(Value = "SOURCE_TYPE_NOT_SUPPORTED")]
    SourceTypeNotSupported,

    [EnumMember(Value = "ERROR_DOWNLOADING_SOURCE")]
    ErrorDownloadingSource,

    [EnumMember(Value = "TOO_MANY_GDRIVE_REQUESTS")]
    TooManyGdriveRequests,

    [EnumMember(Value = "SOURCE_BLOCKED_IN_REGION")]
    SourceBlockedInRegion,

    [EnumMember(Value = "SOURCE_IS_AGE_RESTRICTED")]
    SourceIsAgeRestricted,

    [EnumMember(Value = "SOURCE_NOT_FOUND")]
    SourceNotFound,

    [EnumMember(Value = "MISMATCHED_SOURCE_CODEC")]
    MismatchedSourceCodec,

    [EnumMember(Value = "CONTENT_DOES_NOT_MATCH_EXTENSION")]
    ContentDoesNotMatchExtension,

    [EnumMember(Value = "INVALID_SOURCE_DATA")]
    InvalidSourceData,

    [EnumMember(Value = "VIDEO_DOES_NOT_HAVE_AUDIO_STREAMS")]
    VideoDoesNotHaveAudioStreams,

    [EnumMember(Value = "MASTERING_OUT_OF_RANGE")]
    MasteringOutOfRange,

    [EnumMember(Value = "INVALID_AUDIO_TRACKS_SELECTION")]
    InvalidAudioTracksSelection,

    [EnumMember(Value = "PAYMENT_REQUIRED")]
    PaymentRequired,

    [EnumMember(Value = "FORBIDDEN")]
    Forbidden,

    [EnumMember(Value = "INTERNAL_ERROR")]
    InternalError,

    [EnumMember(Value = "NONE")]
    None
}
