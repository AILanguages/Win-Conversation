//-----------------------------------------------------------------------
// <copyright file="TuringConverse.cs" company="Thinking Solutions Pty Ltd">
//     Copyright (c) Thinking Solutions 2015. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using PatTuring2016.Common.ScreenModels;
using PatTuring2016.Common.ScreenModels.Conversation;
using PatTuring2016.Speech.Forms;
using PatTuring2016.Speech.Properties;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace PatTuring2016.Speech
{
    public class TuringConverse
    {
        private readonly MatchSettings _matchSettings;
        private readonly string _url;
        private string _userKey;

        public TuringConverse(MatchSettings matchSettings)
        {
            _matchSettings = matchSettings;
            _url = (string)Settings.Default["DataServer"]; // the validated address of the service
            _userKey = string.Empty;
        }

        internal async Task<string> Converse(string sourcetext)
        {
            var match = new ConverseMatch { DataToMatch = sourcetext, UserKey = _userKey, MatchSettings = _matchSettings };

            using (var client = new HttpClient())
            {
                SetupClient(client);

                // HTTP POST
                HttpResponseMessage response = await client.PostAsJsonAsync("api/v1/converse", match);
                if (response.IsSuccessStatusCode)
                {
                    var matchupdate = await response.Content.ReadAsAsync<ConverseMatch>();
                    _userKey = matchupdate.UserKey;
                    return matchupdate.ConverseResponse.CurrentResponse != null ? matchupdate.ConverseResponse.CurrentResponse.WhatSaid : string.Empty;
                }
            }

            return string.Empty;
        }

        public async Task Restart()
        {
            var match = new ConverseMatch { UserKey = _userKey, MatchSettings = _matchSettings };

            using (var client = new HttpClient())
            {
                SetupClient(client);

                // HTTP POST
                HttpResponseMessage response = await client.PostAsJsonAsync("api/v1/restart", match);
                if (response.IsSuccessStatusCode)
                {
                    //var matchupdate = await response.Content.ReadAsAsync<ConversationData>();
                }
            }
        }

        private void SetupClient(HttpClient client)
        {
            client.BaseAddress = new Uri("http://" + _url + "/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        internal async void GetContextScreen()
        {
            var contextScreen = new ContextScreen();
            var track = await Tracker();
            
            contextScreen.LoadData(track);
            contextScreen.Show();
        }

        internal async void GetTrackScreen()
        {
            var trackscreen = new TrackScreen();
            var track = await Tracker();

            trackscreen.LoadData(track);
            trackscreen.Show();
        }

        private async Task<ConversationData> Tracker()
        {
            var match = new ConverseMatch { DataToMatch = "Context", UserKey = _userKey, MatchSettings = _matchSettings };

            using (var client = new HttpClient())
            {
                SetupClient(client);

                // HTTP POST
                HttpResponseMessage response = await client.PostAsJsonAsync("api/v1/converse", match);
                if (response.IsSuccessStatusCode)
                {
                    var matchupdate = await response.Content.ReadAsAsync<ConverseMatch>();
                    _userKey = matchupdate.UserKey;
                    return matchupdate.ConverseResponse;
                }
            }

            return null;
        }
    }
}