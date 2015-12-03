//-----------------------------------------------------------------------
// <copyright file="ContextForm.cs" company="Thinking Solutions Pty Ltd">
//     Copyright (c) Thinking Solutions 2015. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace TSTuring2015.Speech.Forms
{
    using Common;
    using System;
    using System.Windows.Forms;
    using ScreenModels;

    public partial class ContextForm : Form
    {
        public ContextForm()
        {
            InitializeComponent();
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            Visible = false;
        }

        internal void Setup()
        {
            cbxDisplay.Text = Display.Letters.ToString();
            cbxIForce.Text = IllocutionaryForce.Source.ToString();
            cbxRelations.Visible = true;
            cbxRelations.Text = "EqualStatus";

            lblSpkRelations.Visible = true;

            cbxSourceGender.Items.AddRange(AllGenders.GenderObjectList());
            cbxSourceGender.Text = AllGendersList.Male.ToString(); // default male speaker

            cbxTargetGender.Items.AddRange(AllGenders.GenderObjectList());
            cbxTargetGender.Text = AllGendersList.Female.ToString(); // default female target listener

            cbxPersonChange.Items.AddRange(AllPersonChangeList.PersonChangeObjectList());
            cbxPersonChange.Text = PersonChange.Source.ToString();

            cbxFormality.Items.AddRange(AllFormalList.FormalObjectList());
            cbxFormality.Text = Formalities.Neutral.ToString();

            cbxPolite.Items.AddRange(AllPoliteList.FormalObjectList());
            cbxPolite.Text = Politeness.Neutral.ToString();
        }

        internal void CheckDisplay(MatchSettings settings)
        {
            switch (cbxDisplay.Text)
            {
                case "Letters":
                    settings.Characters = Display.Letters;
                    break;
                case "Phonetics":
                    settings.Characters = Display.Phonetics;
                    break;
                default:
                    settings.Characters = Display.Characters;
                    break;
            }
        }

        internal void SetDefaults()
        {
            cbxRelations.Items.Clear();
            cbxRelations.Text = "Ignore";
            cbxRelations.Visible = false;
            lblSpkRelations.Visible = false;
        }

        internal void SetRelations(object[] relations)
        {
            cbxRelations.Items.Clear();
            cbxRelations.Items.AddRange(relations);
            cbxRelations.Text = "High";
            cbxRelations.Visible = true;
            lblSpkRelations.Visible = true;
        }

        internal void CheckFormality(MatchSettings settings, string target)
        {
            var formality = cbxFormality.Text;
            var polite = cbxPolite.Text;

            if (target == "Korean")
            {
                if (formality == "High") // formal
                {
                    settings.Formal = Formalities.High;
                    settings.Polite = Politeness.Neutral;
                    return;
                }
                if (polite == "Low") // intimate
                {
                    settings.Polite = Politeness.Low;
                    settings.Formal = Formalities.Neutral;
                    return;
                }

                // defaults
                settings.Polite = Politeness.Neutral;
                settings.Formal = Formalities.Neutral;
                return;
            }

            if (target == "Japanese")
            {
                if (polite == "Low") // intimate
                {
                    settings.Polite = Politeness.Low;
                    settings.Formal = Formalities.Neutral;
                    return;
                }
                if (formality == "Neutral")
                {
                    settings.Polite = Politeness.Neutral;
                    settings.Formal = Formalities.Neutral;
                    return;
                }
            }

            // defaults = polite
            settings.Polite = Politeness.Neutral;
            if (formality == "High")
            {
                settings.Formal = Formalities.High;
            }
            else
            {
                settings.Formal = Formalities.Neutral;
            }
        }

        internal void CheckChangePerson(MatchSettings settings)
        {
            if (cbxPersonChange.Text == "Source")
            {
                settings.PersonChange = PersonChange.Source;
                return;
            }

            if (cbxPersonChange.Text == "OneToOne1PSg")
            {
                settings.PersonChange = PersonChange.OneToOne1PSg;
                return;
            }

            if (cbxPersonChange.Text == "OneToMany2PPl")
            {
                settings.PersonChange = PersonChange.OneToMany2PPl;
                return;
            }

            if (cbxPersonChange.Text == "WithMe1PPl")
            {
                settings.PersonChange = PersonChange.WithMe1PPl;
            }
        }

        internal void CheckChangeIForce(MatchSettings settings)
        {
            switch (cbxIForce.Text)
            {
                case "Imperative":
                    settings.IllocutionaryForce = IllocutionaryForce.Imperative;
                    break;

                case "Question":
                    settings.IllocutionaryForce = IllocutionaryForce.Question;
                    break;

                case "Statement":
                    settings.IllocutionaryForce = IllocutionaryForce.Statement;
                    break;

                default:
                    settings.IllocutionaryForce = IllocutionaryForce.Source;
                    break;
            }
        }
    }
}
