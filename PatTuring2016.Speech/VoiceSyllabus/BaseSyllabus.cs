//-----------------------------------------------------------------------
// <copyright file="BaseSyllabus.cs" company="Thinking Solutions Pty Ltd">
//     Copyright (c) Thinking Solutions 2015. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System.Collections.Generic;

namespace PatTuring2016.Speech.VoiceSyllabus
{
    public class BaseSyllabus
    {
        public BaseSyllabus()
        {
            Commands = new List<string>();
        }

        public string Name { get; set; }

        internal List<string> Commands { set; get; }
    }
}