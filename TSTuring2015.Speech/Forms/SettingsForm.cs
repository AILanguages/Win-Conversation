//-----------------------------------------------------------------------
// <copyright file="SettingsForm.cs" company="Thinking Solutions Pty Ltd">
//     Copyright (c) Thinking Solutions 2015. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace TSTuring2015.Speech.Forms
{
    using Properties;
    using System;
    using System.Configuration;
    using System.Net;
    using System.Windows.Forms;
    using System.Xml;

    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();

            lblError.Text = string.Empty;
            lblError.Visible = false;
            Error = true;

            cbxLocation.Text = (string)Settings.Default["DataServer"];
            tbxSyllabus.Text = (string)Settings.Default["LocalFile"];
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            CheckAndUpdateServerLocation();

            if (!MoreUri(GetServiceLocation(cbxLocation.Text)))
            {
                lblError.Text = "No response from server: " + cbxLocation.Text;
                lblError.Visible = true;
                Error = true;
                return;
            }

            lblError.Visible = false;
            Error = false;
            CheckAndUpdateSyllabusLocation();
            Properties.Settings.Default.Save(); // save any changes to user settings

            UpdateAppConfig(cbxLocation.Text);
            ActivateAppConfig();

            CreateSyllabusDirectory();

            Close();
        }


        private void ActivateAppConfig()
        {
            ConfigurationManager.RefreshSection("system.serviceModel/client");
        }

        private string GetServiceLocation(string text)
        {
            return $"http://{text}";
        }

        private void CreateSyllabusDirectory()
        {
            var docs = GetMyDocumentsDir();
            var pathString = System.IO.Path.Combine(docs, tbxSyllabus.Text);

            if (!System.IO.Directory.Exists(pathString))
            {
                System.IO.Directory.CreateDirectory(pathString); //create it
            }
        }

        private void CheckAndUpdateServerLocation()
        {
            var setting = (string)Settings.Default["DataServer"];
            if (setting != cbxLocation.Text)
            {
                Settings.Default["DataServer"] = cbxLocation.Text;
            }
        }

        private void CheckAndUpdateSyllabusLocation()
        {
            var syllabus = (string)Settings.Default["LocalFile"];
            if (syllabus != tbxSyllabus.Text)
            {
                Settings.Default["LocalFile"] = tbxSyllabus.Text;
            }
        }

        public static string GetMyDocumentsDir()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.Personal);
        }

        void UpdateAppConfig(string param)
        {
            var doc = new XmlDocument();
            doc.Load("TSTuring2015.Speech.exe.config");
            XmlNodeList endpoints = doc.GetElementsByTagName("endpoint");
            var i = 0;
            foreach (XmlNode item in endpoints)
            {
                i++; // there are 6 services at present
                var adressAttribute = item.Attributes["address"];
                if (!ReferenceEquals(null, adressAttribute))
                {
                    adressAttribute.Value = ChangeAddress(param, i);
                }
            }
            doc.Save("TSTuring2015.Speech.exe.config");
        }

        private bool MoreUri(string url)
        {
            try
            {
                var request = WebRequest.Create(url);
                var response = (HttpWebResponse)request.GetResponse();
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    return true;
                }
            }
            catch (WebException exc)
            {
                if ((exc.Response is HttpWebResponse) &&
                    (exc.Response as HttpWebResponse).StatusCode == HttpStatusCode.Forbidden)
                    return true;
            }

            return false;
        }

        private static string ChangeAddress(string param, int i)
        {
            switch (i)
            {
                case 0:
                    return $"http://{param}";
                case 1:
                    return $"http://{param}/MatchService.svc";
                case 2:
                    return $"http://{param}/SessionService.svc";
                case 3:
                    return $"http://{param}/SamplesService.svc";
                case 4:
                    return $"http://{param}/SettingsService.svc";
                case 5:
                    return $"http://{param}/TranslateService.svc";
                case 6:
                    return $"http://{param}/ConverseService.svc";
            }

            return string.Empty;
        }
    }
}