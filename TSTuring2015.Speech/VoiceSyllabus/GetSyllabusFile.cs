//-----------------------------------------------------------------------
// <copyright file="GetSyllabusFiles.cs" company="Thinking Solutions Pty Ltd">
//     Copyright (c) Thinking Solutions 2015. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace TSTuring2015.Speech.VoiceSyllabus
{
    using Forms;
    using Properties;
    using System.Collections.Generic;
    using System.IO;
    using System.Windows.Forms;

    public class GetSyllabusFile
    {
        internal static BaseSyllabus OpenFile()
        {
            var syllabusReturn = new BaseSyllabus();

            // set the initial directory
            var docs = SettingsForm.GetMyDocumentsDir();
            var dir = (string)Settings.Default["LocalFile"];
            var initialDirectory = System.IO.Path.Combine(docs, dir);

            // Create an instance of the open file dialog box.
            var openFileDialog = new OpenFileDialog
            {
                Filter = "Text Files (.txt)|*.txt|All Files (*.*)|*.*",
                FilterIndex = 1,
                InitialDirectory = initialDirectory,
                Multiselect = true
            };

            // Set filter options and filter index.

            // Call the ShowDialog method to show the dialog box.
            var userClickedOk = openFileDialog.ShowDialog();

            // Process input if the user clicked OK.
            if (userClickedOk == DialogResult.OK)
            {
                var lines = File.ReadLines(openFileDialog.FileName);

                syllabusReturn.Name = openFileDialog.SafeFileName;
                syllabusReturn.Commands = new List<string>();
                foreach (var line in lines)
                {
                    syllabusReturn.Commands.Add(line);
                }
            }

            return syllabusReturn;
        }
    }
}
