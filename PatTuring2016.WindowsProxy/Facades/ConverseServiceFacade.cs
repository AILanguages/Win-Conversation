//-----------------------------------------------------------------------
// <copyright file="ConverseServiceFacade.cs" company="AI Languages Inc.">
//     Copyright (c) AI Languages 2016. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using PatTuring2016.Common.Contracts;
using PatTuring2016.Common.DataContracts;
using PatTuring2016.Common.ScreenModels;
using PatTuring2016.Common.ScreenModels.Conversation;

namespace PatTuring2016.WindowsProxy.Facades
{
    public class ConverseServiceFacade
    {
        private readonly IConverseService _converseService;

        public ConverseServiceFacade(IConverseService converseService)
        { 
            _converseService = converseService;
        }
        
        public ConversationData UpdateConversation(Match match)
        {
            var request = new NewMatchRequest { UserKey = WindowsContext.UserKey, DataToMatch = match };

            var response = _converseService.GetConversationData(request);

            return response.Conversation;
        }

        public ConversationData GetContext(Match match)
        {
            var request = new NewMatchRequest { UserKey = WindowsContext.UserKey, DataToMatch = match };

            var response = _converseService.GetContext(request);

            return response.Conversation;
        }

        public void RestartConversation(Match match)
        {
            var request = new NewMatchRequest { UserKey = WindowsContext.UserKey, DataToMatch = match };

            _converseService.RestartConversation(request);
        }
    }
}