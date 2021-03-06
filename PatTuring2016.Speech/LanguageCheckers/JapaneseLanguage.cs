﻿//-----------------------------------------------------------------------
// <copyright file="JapaneseLanguage.cs" company="Thinking Solutions Pty Ltd">
//     Copyright (c) Thinking Solutions 2015. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using PatTuring2016.Speech.Forms;
using System.Speech.Recognition;
using System.Windows.Forms;

namespace PatTuring2016.Speech.LanguageCheckers
{
    public class JapaneseLanguage : AbstractLanguage, ISpeechIsCommand
    {
        internal override void AddCommands(Choices commands)
        {
            // add language swap commands
            commands.Add("mandarin", "german", "italian");
            commands.Add("cantonese", "french", "australian");
            commands.Add("american", "english", "portuguese");
            commands.Add("spanish", "japanese", "korean");

            // other commands
            commands.Add("target only", "confirm source", "close the program");
            commands.Add("formal", "polite", "intimate", "reset");
            commands.Add("phonetics", "characters", "letters");
        }

        internal override void SetIntimate(ConversingController conversingController)
        {
            ContextForm.cbxPolite.Text = "Low";
            ContextForm.cbxFormality.Text = "Neutral";
        }

        internal override void SetPolite(ConversingController conversingController)
        {
            ContextForm.cbxPolite.Text = "Neutral";
            ContextForm.cbxFormality.Text = "Neutral";
        }

        internal override void SetFormal(ConversingController conversingController)
        {
            ContextForm.cbxPolite.Text = "Neutral";
            ContextForm.cbxFormality.Text = "High";
        }

        // return true if we should continue
        public bool SpeechIsCommand(string text, Converser converser, ConversingController conversingController)
        {
            // deal with commands if present
            switch (text)
            {
                //case "target only":
                //    converser.cbxTargetOnly.Checked = true;
                //    return true;
                //case "confirm source":
                //    converser.cbxTargetOnly.Checked = false;
                //    return true;

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