//-----------------------------------------------------------------------
// <copyright file="BaseServiceFacade.cs" company="AI Languages Inc.">
//     Copyright (c) AI Languages 2016. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using PatTuring2016.Common.Contracts;
using PatTuring2016.Common.DataContracts;

namespace PatTuring2016.WindowsProxy.Facades
{
    public class BaseServiceFacade
    {
        public static void SetUpFacade(ISessionService sessionService)
        {
            // ensure valid link to server in place - create a new user key!
            var request = new GetIDRequest { UserKey = WindowsContext.UserKey };
            var response = sessionService.GetID(request);

            if (!response.Success) return;

            WindowsContext.UserKey = response.UserKey;
        }
    }
}