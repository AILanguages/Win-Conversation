//-----------------------------------------------------------------------
// <copyright file="AbstractLanguage.cs" company="Thinking Solutions Pty Ltd">
//     Copyright (c) Thinking Solutions 2015. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using PatTuring2016.Common;
using PatTuring2016.Speech.Forms;
using System;
using System.Speech.Recognition;
using System.Windows.Forms;

namespace PatTuring2016.Speech.LanguageCheckers
{
    public abstract class AbstractLanguage
    {
        internal ContextForm ContextForm { get; set; }

        // take verbal command and change system settings
        internal bool SetTargetLanguage(string language, ConversingController conversingController)
        {
            switch (language)
            {
                case "mandarin":
                case "german":
                case "italian":
                case "cantonese":
                case "french":
                case "portuguese":
                case "spanish":
                    var lang = (AllLanguageList)Enum.Parse(typeof(AllLanguageList),
                        char.ToUpper(language[0]) + language.Substring(1));
                    conversingController.ChangeTargetTo(lang);
                    return true;

                case "japanese":
                    conversingController.ChangeTargetTo(AllLanguageList.Japanese);
                    return true;

                case "korean":
                    conversingController.ChangeTargetTo(AllLanguageList.Korean);
                    return true;

                case "australian":
                    conversingController.ChangeTargetTo(AllLanguageList.OzEnglish);
                    return true;
                case "american":
                    conversingController.ChangeTargetTo(AllLanguageList.USEnglish);
                    return true;
                case "english":
                    conversingController.ChangeTargetTo(AllLanguageList.UKEnglish);
                    return true;
            }

            return false;
        }

        internal abstract void AddCommands(Choices commandLoad);

        internal abstract void SetIntimate(ConversingController conversingController);

        internal abstract void SetPolite(ConversingController conversingController);

        internal abstract void SetFormal(ConversingController conversingController);

        internal bool MakeCommandChange(string text, Converser converser, ConversingController conversingController)
        {
            // deal with commands if present
            switch (text)
            {
                case "target only":
                    converser.cbxTargetOnly.Checked = true;
                    return true;

                case "confirm source":
                    converser.cbxTargetOnly.Checked = false;
                    return true;

                case "formal":
                    SetFormal(conversingController);
                    return true;

                case "polite":
                    SetPolite(conversingController);
                    return true;

                case "intimate":
                    SetIntimate(conversingController);
                    return true;

                case "close the program":
                    Application.Exit();
                    return true;
            }

            return false;
        }
    }
}