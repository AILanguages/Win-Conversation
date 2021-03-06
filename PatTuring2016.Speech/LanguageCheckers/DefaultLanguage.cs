﻿//-----------------------------------------------------------------------
// <copyright file="DefaultLanguage.cs" company="Thinking Solutions Pty Ltd">
//     Copyright (c) Thinking Solutions 2015. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using PatTuring2016.Speech.Forms;
using System.Speech.Recognition;
using System.Windows.Forms;

namespace PatTuring2016.Speech.LanguageCheckers
{
    public class DefaultLanguage : AbstractLanguage, ISpeechIsCommand
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
            commands.Add("low", "neutral", "high", "very high");

            // temporary commands
            commands.Add("Jackson helped the invaders no the police yesterday at the stadium, but Meagan did not.");
            commands.Add("Susan hit no helped the girl my mother ate the spaghetti with.");
            commands.Add("John saw the bear at the parking lot yesterday because he was alert.");
            commands.Add("Who helped?");
            commands.Add("Who didn't help?");
            commands.Add("Who was helpful?");
            commands.Add("Who was unhelpful?");
            commands.Add("When did Jackson help the invaders?");
            commands.Add("When did Jackson help the police?");
            commands.Add("Where did Jackson help?");
            commands.Add("Where did Meagan not help?");
            commands.Add("What did my mother eat?");
            commands.Add("Why did John see the bear?");
            commands.Add("Who was seen by John?");

            commands.Add("John ate the fish yesterday no the beef at the beach, and Beth, the pork.");
            commands.Add("My friend's mother saw the apple in the parking lot.");
            commands.Add("Then she went to the airport at 3pm.");
            commands.Add("Where was the apple seen?");
            commands.Add("Who saw the apple?");
            commands.Add("Where was the apple?");

            commands.Add("The witness arrived at the court.");
            commands.Add("Then, the lawyer saw himself in the mirror.");

            commands.Add("The lawyer arrived at the court.");
            commands.Add("Then the dog bit his mother.");
            commands.Add("Then, the witness saw himself in the mirror.");

            commands.Add("He answered the questions before he left.");
            commands.Add("Who answered?");

            commands.Add("Call Beth no John.");
            commands.Add("Who was called?");
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