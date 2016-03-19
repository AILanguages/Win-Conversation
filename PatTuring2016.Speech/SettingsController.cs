//-----------------------------------------------------------------------
// <copyright file="SettingsController.cs" company="Thinking Solutions Pty Ltd">
//     Copyright (c) Thinking Solutions 2015. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using PatTuring2016.Speech.Forms;

namespace PatTuring2016.Speech
{
    public class SettingsController
    {
        private ContextForm _contextForm;
        private SyllabusForm _syllabusForm;
        private Converser _converser;
        private ConversingController _conversingController;
        private SyllabusTracker _syllabusTracker;

        public SettingsController(ContextForm contextForm, SyllabusForm syllabusForm)
        {
            _contextForm = contextForm;
            _syllabusForm = syllabusForm;
        }

        internal void Setup(Converser converser, ConversingController conversingController,
            SyllabusTracker syllabusTracker)
        {
            _converser = converser;
            _conversingController = conversingController;
            _syllabusTracker = syllabusTracker;

            _contextForm.Visible = false;
            _contextForm.Setup();
            _contextForm.Show();

            _syllabusForm.Visible = false;
            _syllabusForm.Setup(conversingController, syllabusTracker);
            _syllabusForm.Show();
        }

        internal ContextForm GetContextForm()
        {
            return _contextForm;
        }

        internal void MoreContext()
        {
            if (!_contextForm.Visible && !_syllabusForm.Visible)
            {
                ShowContextForm();
                ShowSylabusForm();
                return;
            }

            if (_contextForm.Visible && _syllabusForm.Visible)
            {
                _syllabusForm.Visible = false;
                _contextForm.Visible = false;
                return;
            }

            if (_contextForm.IsDisposed)
            {
                _contextForm = new ContextForm();
                Setup(_converser, _conversingController, _syllabusTracker);
            }
            ShowContextForm();

            if (_syllabusForm.IsDisposed)
            {
                _syllabusForm = new SyllabusForm();
                Setup(_converser, _conversingController, _syllabusTracker);
            }
            ShowSylabusForm();
        }

        private void ShowSylabusForm()
        {
            _syllabusForm.Visible = true;
            _syllabusForm.TopMost = true;
        }

        private void ShowContextForm()
        {
            _contextForm.Visible = true;
            _contextForm.TopMost = true;
        }

        internal void CloseWindows()
        {
            _contextForm.Close();
            _syllabusForm.Close();
        }
    }
}