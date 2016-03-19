//-----------------------------------------------------------------------
// <copyright file="ISpeechIsCommand.cs" company="Thinking Solutions Pty Ltd">
//     Copyright (c) Thinking Solutions 2015. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using PatTuring2016.Speech.Forms;

namespace PatTuring2016.Speech.LanguageCheckers
{
    public interface ISpeechIsCommand
    {
        bool SpeechIsCommand(string text, Converser converser, ConversingController conversingController);
    }
}