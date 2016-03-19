//-----------------------------------------------------------------------
// <copyright file="SyllabusForm.cs" company="Thinking Solutions Pty Ltd">
//     Copyright (c) Thinking Solutions 2015. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Windows.Forms;
using PatTuring2016.Speech.VoiceSyllabus;

namespace PatTuring2016.Speech.Forms
{
    public partial class SyllabusForm : Form
    {
        private ConversingController _conversingController;
        private SyllabusTracker _syllabusTracker;

        public SyllabusForm()
        {
            InitializeComponent();
        }

        public void Setup(ConversingController conversingController, SyllabusTracker syllabusTracker)
        {
            _conversingController = conversingController;
            _syllabusTracker = syllabusTracker;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            var currentSyllabus = GetSyllabusFile.OpenFile();

            if (string.IsNullOrWhiteSpace(currentSyllabus.Name)) return;

            _conversingController.AddSyllabus(currentSyllabus);

            if (string.IsNullOrWhiteSpace(tbxSyllabus.Text))
            {
                tbxSyllabus.Text = GetFileNameOnly(currentSyllabus.Name);
            }
            else
            {
                tbxSyllabus.Text = GetFileNameOnly(currentSyllabus.Name) + ", " + tbxSyllabus.Text;
            }

            _conversingController.LoadSyllabus();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            _conversingController.ClearTextBoxes();
            _conversingController.SayLast();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            _conversingController.ClearTextBoxes();
            _conversingController.OnDisplayRequested();
        }

        private void btnSyllabus_Click(object sender, EventArgs e)
        {
            _conversingController.ClearTextBoxes();
            _conversingController.OnSyllabusSelected();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            _syllabusTracker.ResetSyllabi();
            tbxSyllabus.Text = string.Empty;
        }

        private string GetFileNameOnly(string name)
        {
            return name.EndsWith(".txt") ? name.Substring(0, name.Length - 4) : name;
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            Visible = false;
        }
    }
}
