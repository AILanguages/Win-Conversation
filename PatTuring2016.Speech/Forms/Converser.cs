//-----------------------------------------------------------------------
// <copyright file="Converser.cs" company="Thinking Solutions Pty Ltd">
//     Copyright (c) Thinking Solutions 2015. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using PatTuring2016.Common;
using StructureMap;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PatTuring2016.Speech.Forms
{
    public partial class Converser : Form
    {
        private ConversingController _conversingController;
        private bool _defaultLangauge = true;

        public Converser()
        {
            InitializeComponent();

            Setup();
        }

        private void Setup()
        {
            var languages = AllLanguages.LanguageObjectList();
            //  ckLstTargets.Items.AddRange(languages);

            //SetSingleLanguage(AllLanguageList.USEnglish.ToString());

            //  cbxSource.Items.AddRange(languages);
            //  cbxSource.Text = AllLanguageList.OzEnglish.ToString(); // default source speaker

            // get screen postion and size
            //Location = new Point(0, 0);
            //Size = Screen.PrimaryScreen.WorkingArea.Size;
            //Width = 1500;
            //Height = 1800;

          //  tbxGeneration.Parent = pictureBox1;
            tbxEntry.Parent = pictureBox1;
           // tbxOutput.Parent = pictureBox1;
            btnRestart.Parent = pictureBox1;

            tbxEntry.Multiline = true;
            tbxEntry.BorderStyle = BorderStyle.None;

            GetConversingController().SetVoiceMonitoring();
        }

        //private void btnStart_Click(object sender, EventArgs e)
        //{
        //  //  btnStart.Enabled = false;
        //  //  btnStop.Enabled = true;
        //    GetConversingController().SetVoiceMonitoring();
        //}

        //private void btnStop_Click(object sender, EventArgs e)
        //{
        //    btnStart.Enabled = true;
        // //   btnStop.Enabled = false;
        //    GetConversingController().StopRecognize();

        //    lblError.Text = string.Empty;
        //    lblErrorSound.Text = string.Empty;
        //    lblPercent.Text = string.Empty;
        //}

        private void Form1_Load(object sender, EventArgs e)
        {
            var splash = new SettingsForm();
            splash.ShowDialog();

            if (splash.Error)
            {
                Close();
            }
        }

        //internal void SetSingleLanguage(string single)
        //{
        //    for (var i = 0; i < ckLstTargets.Items.Count; i++)
        //    {
        //        ckLstTargets.SetItemChecked(i, ckLstTargets.Items[i].ToString() == single);
        //    }
        //}

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbxOutput.Text = string.Empty;
            tbxGeneration.Text = string.Empty;
        }

        private void btnQuiet_Click(object sender, EventArgs e)
        {
            GetConversingController().ShowSyllabus();
        }

        private void btnTracker_Click(object sender, EventArgs e)
        {
            GetConversingController().ShowTrackedConversation();
        }

        private void btnContext_Click(object sender, EventArgs e)
        {
            GetConversingController().ShowContext();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            GetConversingController().RestartConversation();
            this.tbxEntry.Text = string.Empty;
            btnClear_Click(sender, e);
        }

        private ConversingController GetConversingController()
        {
            if (_conversingController == null)
            {
                var container = new Container();
                _conversingController = container.GetInstance<ConversingController>();
                _conversingController.Setup(this);
            }

            return _conversingController;
        }

        //internal string GetSingleLanguage()
        //{
        //    //foreach (var language in ckLstTargets.CheckedItems)
        //    //{
        //    //    return language.ToString();
        //    //}

        //    return string.Empty;
        //}

        private async void btnTextIn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxEntry.Text)) return;

            SetLanguage();

            await GetConversingController().HandleSpeech(tbxEntry.Text);
        }

        private void SetLanguage()
        {
            if (!checkBox1.Checked)
            {
                GetConversingController().SpeakEnglish();
            }
            else
            {
                GetConversingController().SpeakMandarin();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        //private void btnMore_Click(object sender, EventArgs e)
        //{
        //    GetConversingController().MoreContext();
        //}

        ////private void btnGoOnline_Click(object sender, EventArgs e)
        ////{
        ////    var converserController = GetConversingController();
        ////    converserController.CloseWindows();
        ////    _conversingController = null;
        ////    Form1_Load(this, new EventArgs());
        ////    GetConversingController(); // reset speech controller and links 
        ////}
    }
}