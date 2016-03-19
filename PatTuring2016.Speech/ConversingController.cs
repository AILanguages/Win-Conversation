//-----------------------------------------------------------------------
// <copyright file="ConversingController.cs" company="Thinking Solutions Pty Ltd">
//     Copyright (c) Thinking Solutions 2015. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using PatTuring2016.Common;
using PatTuring2016.Speech.Forms;
using PatTuring2016.Speech.SpeechRec;
using PatTuring2016.Speech.VoiceSyllabus;

namespace PatTuring2016.Speech
{
    public class ConversingController
    {
        private readonly TranslateAndSpeak _translateAndSpeak;
        private readonly TuringConverse _turingConverser;
        private readonly SetVoiceMonitoring _setVoiceMonitoring;
        private readonly SyllabusTracker _syllabusTracker;
        readonly SpeakText _speakText;
        private Converser _converser;
        private readonly SettingsController _settingsController;

        public ConversingController(SetVoiceMonitoring setVoiceMonitoring,
            SyllabusTracker syllabusTracker, SpeakText speakText, TuringConverse turingConverser,
            TranslateAndSpeak translateAndSpeak, SettingsController settingsController)
        {
            _setVoiceMonitoring = setVoiceMonitoring;
            _syllabusTracker = syllabusTracker;
            _speakText = speakText;
            _turingConverser = turingConverser;
            _translateAndSpeak = translateAndSpeak;
            _settingsController = settingsController;
        }

        internal void Setup(Converser converser)
        {
            _converser = converser;
            _converser.tbxOutput.Text = string.Empty;
            _converser.tbxGeneration.Text = string.Empty;

            _settingsController.Setup(converser, this, _syllabusTracker);

            var contextForm = _settingsController.GetContextForm();
            _speakText.LoadContextForm(contextForm);

            // not used at present, but retain during refactor
            _translateAndSpeak.Setup(_speakText, converser, contextForm);
        }

        internal Converser GetConverser()
        {
            return _converser;
        }

        internal void AddSyllabus(BaseSyllabus currentSyllabus)
        {
            _syllabusTracker.AddSyllabus(currentSyllabus);
        }

        internal void ClearTextBoxes()
        {
            _converser.tbxOutput.Text = string.Empty;
            _converser.tbxGeneration.Text = string.Empty;
        }

        internal void OnDisplayRequested()
        {
            _speakText.OnDisplayRequested(_converser, _syllabusTracker.CurrentSyllabus);
        }

        internal void LoadSyllabus()
        {
            _setVoiceMonitoring.CreateEngine(this, _converser.cbxSource.Text); // setup current langauge recognition
            _setVoiceMonitoring.LoadCurrentSyllabus(_syllabusTracker, _speakText.GetLanguage()); // load full syllabus/commands
        }

        internal void HandleSpeech(string textIn)
        {
            if (_speakText.SpeechIsCommand(textIn, _converser, this))
            {
                _speakText.UpdateLanguage(textIn);
                return;
            }

            _speakText.LogTextReceived(textIn, _converser);

            var text =
               _converser.cbxAccentOnly.Checked ?
               textIn : _turingConverser.Update(textIn, _converser.GetSingleLanguage(), "Polite");

            _speakText.SpeakTextReceived(text, _converser);
        }

        internal void ChangeTargetTo(AllLanguageList newTarget)
        {
            _converser.SetSingleLanguage(newTarget.ToString());
        }

        // speak the last sylabus selected
        internal void SayLast()
        {
            SpeakSyllabus(_syllabusTracker.CurrentSyllabus);
        }

        // speak all syllabi entered
        internal void OnSyllabusSelected()
        {
            foreach (var baseSyllabus in _syllabusTracker.Syllabi)
            {
                SpeakSyllabus(baseSyllabus);
            }


        }

        private void SpeakSyllabus(BaseSyllabus syllabus)
        {
            if (syllabus == null) return;

            foreach (var phrase in syllabus.Commands)
            {
                HandleSpeech(phrase);
            }
        }

        internal void MoreContext()
        {
            _settingsController.MoreContext();
        }

        internal void CloseWindows()
        {
            _settingsController.CloseWindows();
        }

        internal void SetQuiet()
        {
            _speakText.ShutUp();
        }

        internal void SetVoiceMonitoring()
        {
            LoadSyllabus();
            _setVoiceMonitoring.Recognize();
        }

        internal void StopRecognize()
        {
            _setVoiceMonitoring.StopRecognize();
        }

        internal void RestartConversation()
        {
            _turingConverser.Restart();
        }

        internal void ShowTrackedConversation()
        {
            var trackScreen = _turingConverser.GetTrackScreen();
            trackScreen.Show();
        }

        internal void ShowContext()
        {
            var contextScreen = _turingConverser.GetContextScreen();
            contextScreen.Show();
        }
    }
}