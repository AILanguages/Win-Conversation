//-----------------------------------------------------------------------
// <copyright file="TranslateAndSpeak.cs" company="Thinking Solutions Pty Ltd">
//     Copyright (c) Thinking Solutions 2015. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using PatTuring2016.Speech.Forms;
using PatTuring2016.Speech.SpeechRec;

namespace PatTuring2016.Speech
{
    public class TranslateAndSpeak
    {
        private readonly TuringTranslate _turingTranslate;
        private SpeakText _speakText;
        private Converser _converser;

        public TranslateAndSpeak(TuringTranslate turingTranslate)
        {
            _turingTranslate = turingTranslate;
        }

        internal void Setup(SpeakText speakText, Converser converser, ContextForm contextForm)
        {
            _speakText = speakText;
            _converser = converser;
            _turingTranslate.Setup(contextForm);
        }

        internal void HandleText(string text)
        {
            LogTextConvertAndSpeak(text, _converser.GetSingleLanguage());
        }
        
        private void LogTextConvertAndSpeak(string text, string target)
        {
            _speakText.AppendThis(text, _converser.tbxOutput); // repeat what was entered
            if (_converser.cbxTargetOnly.Checked) return;

            _speakText.SpeakWithVoice(text, _converser.cbxSource.Text);

            WriteAndSpeakTranslation(text, target); // i.e. conversation now
        }

        private void WriteAndSpeakTranslation(string text, string target)
        {
            if (target.EndsWith("English"))
            {
                target = "English";
            }

            var sourcetext = _converser.cbxAccentOnly.Checked ? text :
                _turingTranslate.Translate(text, _converser, target);

            _speakText.AppendThis(sourcetext, _converser.tbxGeneration);
            _speakText.SpeakWithVoice(sourcetext, target);
        }        
    }
}