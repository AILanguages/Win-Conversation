//-----------------------------------------------------------------------
// <copyright file="AbstractLanguageFactory.cs" company="Thinking Solutions Pty Ltd">
//     Copyright (c) Thinking Solutions 2015. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using PatTuring2016.Speech.LanguageCheckers;

namespace PatTuring2016.Speech
{
    public class AbstractLanguageFactory
    {
        internal static AbstractLanguage GetFactory(string text, AbstractLanguage current)
        {
            switch (text)
            {
                case "japanese":
                    return new JapaneseLanguage();

                case "korean":
                    return new KoreanLanguage();
                default:
                    return current;
            }
        }
    }
}