﻿//-----------------------------------------------------------------------
// <copyright file="ConversingController.cs" company="Thinking Solutions Pty Ltd">
//     Copyright (c) Thinking Solutions 2015. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System.Threading.Tasks;
using PatTuring2016.Common;
using PatTuring2016.Speech.Forms;
using PatTuring2016.Speech.SpeechRec;
using PatTuring2016.Speech.VoiceSyllabus;

namespace PatTuring2016.Speech
{
    public class ConversingController
    {
        private readonly TuringConverse _turingConverser;
        private readonly SyllabusForm _syllabusForm;
        private readonly SetVoiceMonitoring _setVoiceMonitoring;
        private readonly SyllabusTracker _syllabusTracker;
        readonly SpeakText _speakText;
        private Converser _converser;
       // private readonly SettingsController _settingsController;

        public ConversingController(SetVoiceMonitoring setVoiceMonitoring,
            SyllabusTracker syllabusTracker, SpeakText speakText, TuringConverse turingConverser,
            SettingsController settingsController, SyllabusForm syllabusForm)
        {
            _setVoiceMonitoring = setVoiceMonitoring;
            _syllabusTracker = syllabusTracker;
            _speakText = speakText;
            _turingConverser = turingConverser;
            _syllabusForm = syllabusForm;
            //  _settingsController = settingsController;
        }

        internal void Setup(Converser converser)
        {
            _converser = converser;
            _converser.tbxOutput.Text = string.Empty;
            _converser.tbxGeneration.Text = string.Empty;

            _syllabusForm.Setup(this, _syllabusTracker);
            //_settingsController.Setup(converser, this, _syllabusTracker);

            //var contextForm = _settingsController.GetContextForm();
           // _speakText.LoadContextForm(contextForm);
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
            _setVoiceMonitoring.CreateEngine(this, "USEnglish"); //" _converser.cbxSource.Text); // setup current langauge recognition
            _setVoiceMonitoring.LoadCurrentSyllabus(_syllabusTracker, _speakText.GetLanguage()); // load full syllabus/commands
        }

        internal async Task HandleSpeech(string textIn)
        {
            if (_speakText.SpeechIsCommand(textIn, _converser, this))
            {
                _speakText.UpdateLanguage(textIn);
                return;
            }

            _speakText.LogTextReceived(textIn, _converser);

            var converseResponse = await _turingConverser.Converse(textIn);

            //var text = converseResponse;
            //   _converser.cbxAccentOnly.Checked ?
            //   textIn : converseResponse; //, _converser.GetSingleLanguage(), "Polite");

            _speakText.SpeakTextReceived(converseResponse, _converser);
        }

        internal void ChangeTargetTo(AllLanguageList newTarget)
        {
//            _converser.SetSingleLanguage(newTarget.ToString());
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

        private async void SpeakSyllabus(BaseSyllabus syllabus)
        {
            if (syllabus == null) return;

            foreach (var phrase in syllabus.Commands)
            {
                await HandleSpeech(phrase);
            }
        }

        public void SpeakEnglish()
        {
            _speakText.SetDefaultLanguage();
        }
        public void SpeakMandarin()
        {
            _speakText.SetMandarinLanguage();
        }

        internal void MoreContext()
        {
       //     _syllabusTracker.ShowForm();
//            _settingsController.MoreContext();
        }

        //internal void CloseWindows()
        //{
        //    _settingsController.CloseWindows();
        //}

        internal void SetQuiet()
        {
            _speakText.ShutUp();
        }

        internal void SetVoiceMonitoring()
        {
           // LoadSyllabus();
           // _setVoiceMonitoring.Recognize();
        }

        internal void StopRecognize()
        {
            _setVoiceMonitoring.StopRecognize();
        }

        internal async void RestartConversation()
        {
            await _turingConverser.Restart();
        }

        internal void ShowTrackedConversation()
        {
            _turingConverser.GetTrackScreen();
        }

        internal void ShowContext()
        {
            _turingConverser.GetContextScreen();
        }

        public void ShowSyllabus()
        {
            _syllabusForm.Show();
        }
    }
}