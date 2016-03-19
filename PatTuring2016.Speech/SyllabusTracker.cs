//-----------------------------------------------------------------------
// <copyright file="SyllabusTracker.cs" company="Thinking Solutions Pty Ltd">
//     Copyright (c) Thinking Solutions 2015. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using PatTuring2016.Speech.VoiceSyllabus;
using System.Collections.Generic;

namespace PatTuring2016.Speech
{
    public class SyllabusTracker
    {
        public BaseSyllabus CurrentSyllabus { get; set; }
        public HashSet<BaseSyllabus> Syllabi { get; set; }

        public SyllabusTracker()
        {
            ResetSyllabi();
        }

        public void ResetSyllabi()
        {
            Syllabi = new HashSet<BaseSyllabus>();
            CurrentSyllabus = null;
        }

        public void AddSyllabus(BaseSyllabus baseSyllabus)
        {
            Syllabi.Add(baseSyllabus);
            CurrentSyllabus = baseSyllabus;
        }
    }
}