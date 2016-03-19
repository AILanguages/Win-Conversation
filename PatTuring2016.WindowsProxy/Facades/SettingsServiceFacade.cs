//-----------------------------------------------------------------------
// <copyright file="SettingsServiceFacade.cs" company="AI Languages Inc.">
//     Copyright (c) AI Languages 2016. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using PatTuring2016.Common.Contracts;
using PatTuring2016.Common.DataContracts;
using PatTuring2016.Common.ScreenModels;

namespace PatTuring2016.WindowsProxy.Facades
{
    public class SettingsServiceFacade
    {
        private readonly ISettingsService _settingsClientProxy;

        public SettingsServiceFacade(ISettingsService settingsService)
        {
            _settingsClientProxy = settingsService;
        }
        
        public MatchSettings GetSettings()
        {
            var request = new GetSettingsRequest
            {
                UserKey = WindowsContext.UserKey
            };
            var response = _settingsClientProxy.GetSettings(request);
            return response.Settings;
        }
        
        public void UpdateSettings(MatchSettings matchSettings, SampleSettings sampleSettings)
        {
            // get settings from server to compare with new ones - avoid loss
            var oldsettings = GetSettings();
            
            var request = new GetSampleSettingsRequest
            {
                UserKey = WindowsContext.UserKey
            };
            var response = _settingsClientProxy.GetSampleSettings(request);

            var oldSamples = response.Settings;
            
            if (matchSettings != null)
            {
                oldsettings.TargetLanguage = matchSettings.TargetLanguage;

                oldsettings.Speaker = matchSettings.Speaker;
                oldsettings.Characters = matchSettings.Characters;
                oldsettings.Formal = matchSettings.Formal;
                oldsettings.Polite = matchSettings.Polite;
                oldsettings.IllocutionaryForce = matchSettings.IllocutionaryForce;
                oldsettings.PersonChange = matchSettings.PersonChange;

                oldsettings.ShowSentences = matchSettings.ShowSentences;
                oldsettings.SimpleView = matchSettings.SimpleView;
            }

            if (sampleSettings != null)
            {
                oldSamples.SampleFiles = sampleSettings.SampleFiles;
            }
            
            var settingsReturned2 = new SettingsPresentation();

            var request2 = new ChangeSettingsRequest { UserKey = WindowsContext.UserKey, Settings = oldsettings };
            var response2 = _settingsClientProxy.SetSettings(request2);
            settingsReturned2.Settings = response2.Settings;
            settingsReturned2.SettingsChanged = response2.Success;



            var settingsReturned = new SampleSettingsPresentation();

            var samples = new SampleSettings { SampleFiles = oldSamples.SampleFiles };
            var request1 = new ChangeSampleSettingsRequest { UserKey = WindowsContext.UserKey, Settings = samples };
            var response1 = _settingsClientProxy.SetSampleSettings(request1);
            settingsReturned.Settings = response1.Settings;
            settingsReturned.SettingsChanged = response1.Success;
        }
    }
}