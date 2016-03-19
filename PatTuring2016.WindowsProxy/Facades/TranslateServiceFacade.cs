//-----------------------------------------------------------------------
// <copyright file="TranslateServiceFacade.cs" company="AI Languages Inc.">
//     Copyright (c) AI Languages 2016. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using PatTuring2016.Common.Contracts;
using PatTuring2016.Common.DataContracts;
using PatTuring2016.Common.ScreenModels;

namespace PatTuring2016.WindowsProxy.Facades
{
    public class TranslateServiceFacade
    {
        private readonly ITranslateService _translateClientProxy;

        public TranslateServiceFacade(ITranslateService translateService) 
        { 
            _translateClientProxy = translateService;
        }
        
        public MatchPatternPresentation GetMatchFor(Match match)
        {
            var request = new NewMatchRequest { DataToMatch = match, UserKey = WindowsContext.UserKey };
            return GetAMatchFor(match, _translateClientProxy.GetData(request));
        }
        
        public ScreenPresentation GetCurrentScreen()
        {
            var screenReturned = new ScreenPresentation();

            var request = new GetScreenRequest { UserKey = WindowsContext.UserKey };

            var response = _translateClientProxy.GetCurrentScreenModel(request);

            if (response.Success)
            {
                screenReturned.ScreenFound = true;
                screenReturned.ScreenModel = response.ScreenModel;
                screenReturned.ScreenName = response.ScreenName;
            }
            else
            {
                screenReturned.ScreenFound = false;
                screenReturned.ScreenModel = null;
            }

            return screenReturned;
        }

        private MatchPatternPresentation GetAMatchFor(Match match, NewMatchResponse response)
        {
            var matchPattern = new MatchPatternPresentation();

            if (response.Success)
            {
                matchPattern.MatchesSuccessfullyFound = true;
                matchPattern.MatchId = response.UserKey;
                matchPattern.ExpiryDate = response.ExpirationDate;
                matchPattern.MenuType = response.MenuType;
            }
            else
            {
                matchPattern.MatchesSuccessfullyFound = false;
                matchPattern.Message = response.Message;
                matchPattern.Edit = match;
            }

            return matchPattern;
        }
    }
}