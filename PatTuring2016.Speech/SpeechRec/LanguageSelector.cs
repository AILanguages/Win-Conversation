//-----------------------------------------------------------------------
// <copyright file="LanguageSelector.cs" company="Thinking Solutions Pty Ltd">
//     Copyright (c) Thinking Solutions 2015. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System.Globalization;

namespace PatTuring2016.Speech.SpeechRec
{
    public static class LanguageSelector
    {
        internal static CultureInfo GetVoice(string type)
        {
            switch (type)
            {
                case "OzEnglish":
                    return new CultureInfo("en-AU");
                case "USEnglish":
                    return new CultureInfo("en-US");
                case "UKEnglish":
                    return new CultureInfo("en-GB");
                case "German":
                    return new CultureInfo("de-DE");
                case "French":
                    return new CultureInfo("fr-FR");
                case "Japanese":
                    return new CultureInfo("ja-JP");
                case "Spanish":
                    return new CultureInfo("es-ES");
                case "Korean":
                    return new CultureInfo("ko-KR");
                case "Portuguese":
                    return new CultureInfo("pt-PT");
                case "Indonesian":
                    return new CultureInfo("id-ID");
                case "Cantonese":
                    return new CultureInfo("zh-HK");
                case "Mandarin":
                    return new CultureInfo("zh-CN");
                case "Italian":
                    return new CultureInfo("it-IT");

                default:
                    return new CultureInfo("en-AU");
            }
        }
    }
}
