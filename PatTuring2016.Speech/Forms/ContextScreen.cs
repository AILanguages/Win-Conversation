//-----------------------------------------------------------------------
// <copyright file="ContextScreen.cs" company="Thinking Solutions Pty Ltd">
//     Copyright (c) Thinking Solutions 2015. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Web;
using System.Windows.Forms;
using PatTuring2016.Common.ScreenModels;
using PatTuring2016.Common.ScreenModels.Conversation;

namespace PatTuring2016.Speech.Forms
{
    public partial class ContextScreen : Form
    {
        public ContextScreen()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        internal void LoadData(ConversationData context)
        {
            foreach (var highContext in context.HighTrackingData.HighContextList)
            {
                dataGridView1.Rows.Add(highContext.Element, highContext.Value);
            }

            foreach (var pronounContext in context.PronounTrackingData.PronounList)
            {
                dataGridView2.Rows.Add(GetList(pronounContext.ClausePart),
                    GetList(pronounContext.ClauseElements),
                    StripHTML(pronounContext.LS),
                    pronounContext.Clause);
            }
        }

        private static string StripHTML(string HTMLText, bool decode = true)
        {
            var reg = new Regex("<[^>]+>", RegexOptions.IgnoreCase);
            if (HTMLText == null) return string.Empty;

            var stripped = reg.Replace(HTMLText, "");
            return decode ? HttpUtility.HtmlDecode(stripped) : stripped;
        }

        private string GetList(List<string> list)
        {
            var strReturn = string.Empty;

            foreach (var item in list)
            {
                strReturn += "o " + item + Environment.NewLine;
            }

            return strReturn;
        }
    }
}
