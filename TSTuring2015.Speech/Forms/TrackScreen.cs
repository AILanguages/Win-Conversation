using System;
using System.Windows.Forms;
using TSTuring2015.ScreenModels;

namespace TSTuring2015.Speech.Forms
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


        internal void LoadData(ConverseViewModel tracker)
        {
            foreach (var spoken in tracker.Conversation.TrackingData.SpokenList)
            {
                dataGridView1.Rows.Add(spoken.Speaker, spoken.WhatSaid, spoken.WhenSaid);
            }
        }
    }
}
