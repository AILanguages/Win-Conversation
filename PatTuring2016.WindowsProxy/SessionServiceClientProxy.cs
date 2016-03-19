//-----------------------------------------------------------------------
// <copyright file="SessionServiceClientProxy.cs" company="AI Languages Inc.">
//     Copyright (c) AI Languages 2016. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using PatTuring2016.Common.Contracts;
using PatTuring2016.Common.DataContracts;
using PatTuring2016.CommonProxy;

namespace PatTuring2016.WindowsProxy
{
    public class SessionServiceClientProxy : AbstractServiceClientFactory<ISessionService>, ISessionService
    {
        public GetIDResponse GetID(GetIDRequest usePatternRequest)
        {
            return Channel.GetID(usePatternRequest);
        }
    }
}