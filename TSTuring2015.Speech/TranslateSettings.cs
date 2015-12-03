//-----------------------------------------------------------------------
// <copyright file="TranslateSettings.cs" company="Thinking Solutions Pty Ltd">
//     Copyright (c) Thinking Solutions 2015. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace TSTuring2015.Speech
{
    using Common;
    using Forms;
    using Properties;
    using ScreenModels;
    using System;
    using WindowsProxy;
    using WindowsProxy.Facades;

    public class TranslateSettings
    {
        private readonly SettingsServiceFacade _settingsServiceFacade;
        private ContextForm _contextForm;

        public TranslateSettings()
        {
            var service = (string)Settings.Default["DataServer"]; // the validated address of the service
            var facades = new GetFacades(service);

            _settingsServiceFacade = facades.GetSettingsServiceFacade();
        }

        internal void Setup(ContextForm contextForm)
        {
            _contextForm = contextForm;
        }
        
        internal MatchSettings UpdateTranslateSettings(string target)
        {
            var settings = _settingsServiceFacade.GetSettings();
            settings.ShowSentences = false;

            SetFormality(settings, target); // update settings as needed

            try
            {
                var targetValue = (TargetLanguages)Enum.Parse(typeof(TargetLanguages), target);
                if (Enum.IsDefined(typeof(TargetLanguages), targetValue))
                {
                    settings.TargetLanguage = targetValue == TargetLanguages.Cantonese ? TargetLanguages.Mandarin : targetValue;
                }
            }
            catch (Exception)
            {
                settings.TargetLanguage = TargetLanguages.German; // major error                 
            }

            return settings;
        }

        private void SetFormality(MatchSettings settings, string target)
        {
            settings.IllocutionaryForce = IllocutionaryForce.Source;

            CheckDisplay(settings);
            CheckFormality(settings, target);
            CheckChangePerson(settings);
            CheckChangeIForce(settings);
        }

        private void CheckChangeIForce(MatchSettings settings)
        {
            _contextForm?.CheckChangeIForce(settings);
        }

        private void CheckChangePerson(MatchSettings settings)
        {
            _contextForm?.CheckChangePerson(settings);
        }

        private void CheckFormality(MatchSettings settings, string target)
        {
            _contextForm?.CheckFormality(settings, target);
        }

        private void CheckDisplay(MatchSettings settings)
        {
            _contextForm?.CheckDisplay(settings);
        }
    }
}
