//-----------------------------------------------------------------------
// <copyright file="ConverseServiceFacade.cs" company="AI Languages Inc.">
//     Copyright (c) AI Languages 2016. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using PatTuring2016.Common.Contracts;
using PatTuring2016.Common.DataContracts;
using PatTuring2016.Common.ScreenModels;
using PatTuring2016.Common.ScreenModels.Conversation;
using PatTuring2016.CommonProxy;

namespace PatTuring2016.WindowsProxy.Facades
{
    public class ConverseServiceFacade : BaseConverseServiceFacade
    {
        public ConverseServiceFacade(IConverseService converseService) : base(converseService)
        { }

        public ConversationData UpdateConversation(Match match)
        {
            var request = new NewMatchRequest { UserKey = WindowsContext.UserKey, DataToMatch = match };

            var response = ConverseService.GetConversationData(request);

            return response.Conversation;
        }

        public ConversationData GetContext(Match match)
        {
            var request = new NewMatchRequest { UserKey = WindowsContext.UserKey, DataToMatch = match };

            var response = ConverseService.GetContext(request);

            return response.Conversation;
        }

        public void RestartConversation(Match match)
        {
            var request = new NewMatchRequest { UserKey = WindowsContext.UserKey, DataToMatch = match };

            ConverseService.RestartConversation(request);
        }
    }
}