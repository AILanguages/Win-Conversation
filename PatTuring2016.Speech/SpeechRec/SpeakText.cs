//-----------------------------------------------------------------------
// <copyright file="SpeakText.cs" company="Thinking Solutions Pty Ltd">
//     Copyright (c) Thinking Solutions 2015. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using PatTuring2016.Speech.Forms;
using PatTuring2016.Speech.LanguageCheckers;
using PatTuring2016.Speech.VoiceSyllabus;
using System;
using System.Speech.Synthesis;
using System.Windows.Forms;

namespace PatTuring2016.Speech.SpeechRec
{
    public class SpeakText
    {
        private readonly SpeechSynthesizer _speechSynthesizer;
        private readonly PromptBuilder _promptBuilder;
        private AbstractLanguage _abstractLanguage;

        public SpeakText(SpeechSynthesizer speechSynthesizer, DefaultLanguage defaultLanguage)
        {
            _speechSynthesizer = speechSynthesizer;
            _promptBuilder = new PromptBuilder();
            _abstractLanguage = defaultLanguage;
        }

        internal void AppendThis(string text, TextBox textBox)
        {
            textBox.AppendText(text);
            textBox.AppendText(Environment.NewLine);
        }

        internal void SpeakWithVoice(string text, string target)
        {
            _promptBuilder.ClearContent();
            _promptBuilder.StartVoice(LanguageSelector.GetVoice(target)); // source accent
            _promptBuilder.AppendText(CorrectText(text));

            //  _promptBuilder.AppendSsmlMarkup(". <prosody rate=\"slow\"> That is a <emphasis> big </emphasis> car!</prosody>");
            //string high = "<prosody pitch=\"x-high\"> This is extra high pitch. </prosody >";
            //string loud = "<prosody volume=\"x-loud\"> This is extra loud volume. </prosody>";
            //string slow = "<prosody rate=\"slow\"> This is the slow speaking rate. </prosody>";
            //_promptBuilder.AppendSsmlMarkup(high);
            //_promptBuilder.AppendSsmlMarkup(loud);
            //_promptBuilder.AppendSsmlMarkup(slow);

            _promptBuilder.EndVoice();
            Speak();
        }

        private string CorrectText(string text)
        {
            // correct text if needed for sound - temporary while using Microsoft Speech synthesizer
            if (text == "she read the book.")
                return "she red the book.";

            return text;
        }

        internal void LoadContextForm(ContextForm contextForm)
        {
            _abstractLanguage.ContextForm = contextForm;
        }

        private void Speak()
        {
            _speechSynthesizer.SpeakAsync(_promptBuilder);
        }

        internal void ShutUp()
        {
            _speechSynthesizer.SpeakAsyncCancelAll();
        }

        internal void OnDisplayRequested(Converser converser, BaseSyllabus currentSyllabus)
        {
            var syllabus = currentSyllabus;
            if (syllabus == null) return;

            AppendThis(syllabus.Name, converser.tbxOutput); // what was entered side
            AppendThis(syllabus.Name, converser.tbxGeneration); // what was generated side

            // now display the syllabus on the screen
            foreach (var syllabi in syllabus.Commands)
            {
                AppendThis(syllabi, converser.tbxGeneration);
            }
        }

        internal AbstractLanguage GetLanguage()
        {
            return _abstractLanguage;
        }

        internal void UpdateLanguage(string textIn)
        {
            _abstractLanguage = AbstractLanguageFactory.GetFactory(textIn, _abstractLanguage);
        }

        // return true if recognized speech was a command
        internal bool SpeechIsCommand(string text, Converser converser, ConversingController conversingController)
        {
            // if langauge change, set it
            if (_abstractLanguage.SetTargetLanguage(text, conversingController)) return true;

            return _abstractLanguage.MakeCommandChange(text, converser, conversingController);
        }

        internal void LogTextReceived(string text, Converser converser)
        {
            AppendThis(text, converser.tbxOutput);

           // if (converser.cbxTargetOnly.Checked) return;

            SpeakWithVoice(text, "USEnglish"); //" converser.cbxSource.Text);
        }

        internal void SpeakTextReceived(string text, Converser converser)
        {
            AppendThis(text, converser.tbxGeneration);

            if (text.StartsWith("New context stored:")) return;
            SpeakWithVoice(text, "USEnglish"); //converser.GetSingleLanguage());
        }
    }
}