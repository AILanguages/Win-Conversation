using PatTuring2016.Common.ScreenModels.Conversation;
using System;
using System.Windows.Forms;

namespace PatTuring2016.Speech.Forms
{
    public partial class TrackScreen : Form
    {
        public TrackScreen()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        internal void LoadData(ConversationData data)
        {
            if (data == null) return;

            foreach (var spoken in data.TrackingData.SpokenList)
            {
                dataGridView1.Rows.Add(spoken.Speaker, spoken.WhatSaid, spoken.WhenSaid);
            }
        }
    }
}
