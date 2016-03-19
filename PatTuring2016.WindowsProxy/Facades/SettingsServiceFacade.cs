//-----------------------------------------------------------------------
// <copyright file="SettingsServiceFacade.cs" company="AI Languages Inc.">
//     Copyright (c) AI Languages 2016. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using PatTuring2016.Common;
using PatTuring2016.Common.Contracts;
using PatTuring2016.Common.DataContracts;
using PatTuring2016.Common.ScreenModels;
using PatTuring2016.CommonProxy;

namespace PatTuring2016.WindowsProxy.Facades
{
    public class SettingsServiceFacade : BaseSettingsServiceFacade
    {
        private readonly ISettingsService _settingsClientProxy;

        public SettingsServiceFacade(ISettingsService settingsService)
        {
            _settingsClientProxy = settingsService;
        }

        public override MatchSettings GetSettings()
        {
            var request = new GetSettingsRequest
            {
                UserKey = WindowsContext.UserKey
            };
            var response = _settingsClientProxy.GetSettings(request);
            return response.Settings;
        }

        public override SampleSettings GetSampleSettings()
        {
            var request = new GetSampleSettingsRequest
            {
                UserKey = WindowsContext.UserKey
            };
            var response = _settingsClientProxy.GetSampleSettings(request);
            return response.Settings;
        }

        protected override void SetSampleFile(SampleFiles sampleFiles)
        {
            var settingsReturned = new SampleSettingsPresentation();

            var samples = new SampleSettings { SampleFiles = sampleFiles };
            var request = new ChangeSampleSettingsRequest { UserKey = WindowsContext.UserKey, Settings = samples };
            var response = _settingsClientProxy.SetSampleSettings(request);
            settingsReturned.Settings = response.Settings;
            settingsReturned.SettingsChanged = response.Success;
        }

        protected override void SetSettings(MatchSettings settings)
        {
            var settingsReturned = new SettingsPresentation();

            var request = new ChangeSettingsRequest { UserKey = WindowsContext.UserKey, Settings = settings };
            var response = _settingsClientProxy.SetSettings(request);
            settingsReturned.Settings = response.Settings;
            settingsReturned.SettingsChanged = response.Success;
        }
    }
}