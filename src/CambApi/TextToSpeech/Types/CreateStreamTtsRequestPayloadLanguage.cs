using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using CambApi.Core;

#nullable enable

namespace CambApi;

[JsonConverter(typeof(StringEnumSerializer<CreateStreamTtsRequestPayloadLanguage>))]
public enum CreateStreamTtsRequestPayloadLanguage
{
    [EnumMember(Value = "ar-kw")]
    ArKw,

    [EnumMember(Value = "de-ch")]
    DeCh,

    [EnumMember(Value = "ko-kr")]
    KoKr,

    [EnumMember(Value = "th-th")]
    ThTh,

    [EnumMember(Value = "ml-in")]
    MlIn,

    [EnumMember(Value = "pt-pt")]
    PtPt,

    [EnumMember(Value = "kn-in")]
    KnIn,

    [EnumMember(Value = "fi-fi")]
    FiFi,

    [EnumMember(Value = "es-mx")]
    EsMx,

    [EnumMember(Value = "fr-ca")]
    FrCa,

    [EnumMember(Value = "cs-cz")]
    CsCz,

    [EnumMember(Value = "pt-br")]
    PtBr,

    [EnumMember(Value = "hi-in")]
    HiIn,

    [EnumMember(Value = "ar-sy")]
    ArSy,

    [EnumMember(Value = "es-us")]
    EsUs,

    [EnumMember(Value = "bn-bd")]
    BnBd,

    [EnumMember(Value = "ja-jp")]
    JaJp,

    [EnumMember(Value = "mr-in")]
    MrIn,

    [EnumMember(Value = "ar-ma")]
    ArMa,

    [EnumMember(Value = "es-es")]
    EsEs,

    [EnumMember(Value = "en-us")]
    EnUs,

    [EnumMember(Value = "zh-cn")]
    ZhCn,

    [EnumMember(Value = "el-gr")]
    ElGr,

    [EnumMember(Value = "pl-pl")]
    PlPl,

    [EnumMember(Value = "ar-om")]
    ArOm,

    [EnumMember(Value = "fr-ch")]
    FrCh,

    [EnumMember(Value = "en-uk")]
    EnUk,

    [EnumMember(Value = "en-au")]
    EnAu,

    [EnumMember(Value = "ar-jo")]
    ArJo,

    [EnumMember(Value = "ar-ae")]
    ArAe,

    [EnumMember(Value = "tr-tr")]
    TrTr,

    [EnumMember(Value = "ar-ly")]
    ArLy,

    [EnumMember(Value = "ru-ru")]
    RuRu,

    [EnumMember(Value = "en-in")]
    EnIn,

    [EnumMember(Value = "ar-ye")]
    ArYe,

    [EnumMember(Value = "ar-eg")]
    ArEg,

    [EnumMember(Value = "fr-be")]
    FrBe,

    [EnumMember(Value = "ta-in")]
    TaIn,

    [EnumMember(Value = "zh-tw")]
    ZhTw,

    [EnumMember(Value = "vi-vn")]
    ViVn,

    [EnumMember(Value = "bn-in")]
    BnIn,

    [EnumMember(Value = "ar-sa")]
    ArSa,

    [EnumMember(Value = "de-at")]
    DeAt,

    [EnumMember(Value = "pa-in")]
    PaIn,

    [EnumMember(Value = "it-it")]
    ItIt,

    [EnumMember(Value = "nl-nl")]
    NlNl,

    [EnumMember(Value = "ar-bh")]
    ArBh,

    [EnumMember(Value = "fr-fr")]
    FrFr,

    [EnumMember(Value = "ar-qa")]
    ArQa,

    [EnumMember(Value = "uk-ua")]
    UkUa,

    [EnumMember(Value = "ar-tn")]
    ArTn,

    [EnumMember(Value = "de-de")]
    DeDe,

    [EnumMember(Value = "ar-xa")]
    ArXa,

    [EnumMember(Value = "ar-lb")]
    ArLb,

    [EnumMember(Value = "zh-hk")]
    ZhHk,

    [EnumMember(Value = "ro-ro")]
    RoRo,

    [EnumMember(Value = "as-in")]
    AsIn,

    [EnumMember(Value = "ar-iq")]
    ArIq,

    [EnumMember(Value = "nl-be")]
    NlBe,

    [EnumMember(Value = "te-in")]
    TeIn,

    [EnumMember(Value = "id-id")]
    IdId,

    [EnumMember(Value = "ar-dz")]
    ArDz
}
