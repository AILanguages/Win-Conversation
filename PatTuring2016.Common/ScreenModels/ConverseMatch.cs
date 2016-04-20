//-----------------------------------------------------------------------
// <copyright file="ConverseMatch.cs" company="Pat Inc.">
//     Copyright (c) Pat Inc. 2016. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System.ComponentModel.DataAnnotations;
using PatTuring2016.Common.ScreenModels.Conversation;

namespace PatTuring2016.Common.ScreenModels
{
    public class ConverseMatch : IMatch
    {
        [Required(ErrorMessage = "A sentence is required")]
        [Display(Name = "Text to match")]
        public string DataToMatch { get; set; }

        public string UserKey { get; set; }

        public MatchSettings MatchSettings { get; set; }

        public ConversationData ConverseResponse { get; set; }
    }
}