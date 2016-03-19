//-----------------------------------------------------------------------
// <copyright file="TranslateServiceFacade.cs" company="AI Languages Inc.">
//     Copyright (c) AI Languages 2016. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using PatTuring2016.Common.Contracts;
using PatTuring2016.Common.DataContracts;
using PatTuring2016.Common.ScreenModels;
using PatTuring2016.CommonProxy;

namespace PatTuring2016.WindowsProxy.Facades
{
    public class TranslateServiceFacade : BaseTranslateServiceFacade
    {
        public TranslateServiceFacade(ITranslateService translateService) : base(translateService)
        { }

        protected override GetScreenRequest GetScreenRequest()
        {
            return new GetScreenRequest { UserKey = WindowsContext.UserKey };
        }

        protected override NewMatchRequest GetNewMatchRequest(Match match)
        {
            return new NewMatchRequest { DataToMatch = match, UserKey = WindowsContext.UserKey };
        }
    }
}