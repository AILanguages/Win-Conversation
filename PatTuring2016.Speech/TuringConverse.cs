//-----------------------------------------------------------------------
// <copyright file="TuringConverse.cs" company="Thinking Solutions Pty Ltd">
//     Copyright (c) Thinking Solutions 2015. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using PatTuring2016.Common.ScreenModels;
using PatTuring2016.Speech.Forms;
using PatTuring2016.Speech.Properties;
using PatTuring2016.WindowsProxy;
using PatTuring2016.WindowsProxy.Facades;

namespace PatTuring2016.Speech
{
    public class TuringConverse
    {
        private readonly TranslateSettings _translateSettings;
        private readonly SettingsServiceFacade _settingsServiceFacade;
        private readonly ConverseServiceFacade _converseServiceFacade;

        public TuringConverse(TranslateSettings translateSettings)
        {
            _translateSettings = translateSettings;
            var service = (string)Settings.Default["DataServer"]; // the validated address of the service
            var facades = new GetFacades(service);
            
            _converseServiceFacade = facades.GetConverseSericeFacade();
            _settingsServiceFacade = facades.GetSettingsServiceFacade();
        }

        internal void Setup(ContextForm contextForm)
        {
            _translateSettings.Setup(contextForm);
        }

        public string Update(string sourcetext, string target, string formality)
        {
            var match = new Match();

            if (!string.IsNullOrWhiteSpace(sourcetext))
            {
                match.TextIn = sourcetext;
            }

            var cvm = new ConverseViewModel
            {
                Conversation = _converseServiceFacade.UpdateConversation(match),
                Match = new Match()
            };

            return cvm.Conversation.CurrentResponse != null ? cvm.Conversation.CurrentResponse.WhatSaid : string.Empty;
        }

        public void Restart()
        {
            var match = new Match();

            _converseServiceFacade.RestartConversation(match);
        }

        internal ContextScreen GetContextScreen()
        {
            var contextScreen = new ContextScreen();
            contextScreen.LoadData(Context());
            return contextScreen;
        }

        internal TrackScreen GetTrackScreen()
        {
            var trackscreen = new TrackScreen();
            trackscreen.LoadData(Tracker());
            return trackscreen;
        }

        private ConverseViewModel Context()
        {
            var match = new Match { TextIn = "Context" };

            return new ConverseViewModel { Conversation = _converseServiceFacade.GetContext(match), Match = new Match() };
        }

        private ConverseViewModel Tracker()
        {
            var match = new Match { TextIn = "Context" };

            return new ConverseViewModel { Conversation = _converseServiceFacade.GetContext(match), Match = new Match() };
        }
    }
}