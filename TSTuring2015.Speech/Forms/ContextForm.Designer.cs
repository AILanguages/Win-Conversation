namespace TSTuring2015.Speech.Forms
{
    partial class ContextForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbxIForce = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxDisplay = new System.Windows.Forms.ComboBox();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxSourceGender = new System.Windows.Forms.ComboBox();
            this.cbxTargetGender = new System.Windows.Forms.ComboBox();
            this.btnHide = new System.Windows.Forms.Button();
            this.cbxRelations = new System.Windows.Forms.ComboBox();
            this.cbxPersonChange = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSpkRelations = new System.Windows.Forms.Label();
            this.cbxFormality = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxPolite = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbxIForce
            // 
            this.cbxIForce.FormattingEnabled = true;
            this.cbxIForce.Items.AddRange(new object[] {
            "Source",
            "Statement",
            "Question",
            "Imperative"});
            this.cbxIForce.Location = new System.Drawing.Point(17, 139);
            this.cbxIForce.Margin = new System.Windows.Forms.Padding(2);
            this.cbxIForce.Name = "cbxIForce";
            this.cbxIForce.Size = new System.Drawing.Size(242, 28);
            this.cbxIForce.TabIndex = 44;
            this.cbxIForce.Text = "Source";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 103);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(346, 32);
            this.label7.TabIndex = 43;
            this.label7.Text = "Change (I.F.) Clause Type";
            // 
            // cbxDisplay
            // 
            this.cbxDisplay.FormattingEnabled = true;
            this.cbxDisplay.Items.AddRange(new object[] {
            "Characters",
            "Letters",
            "Phonetics"});
            this.cbxDisplay.Location = new System.Drawing.Point(17, 50);
            this.cbxDisplay.Margin = new System.Windows.Forms.Padding(2);
            this.cbxDisplay.Name = "cbxDisplay";
            this.cbxDisplay.Size = new System.Drawing.Size(242, 28);
            this.cbxDisplay.TabIndex = 42;
            this.cbxDisplay.Text = "Letters";
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.Location = new System.Drawing.Point(11, 9);
            this.lblDisplay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(109, 32);
            this.lblDisplay.TabIndex = 41;
            this.lblDisplay.Text = "Display";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 269);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 32);
            this.label1.TabIndex = 45;
            this.label1.Text = "Source Speaker";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 351);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 32);
            this.label2.TabIndex = 46;
            this.label2.Text = "Target Speaker";
            // 
            // cbxSourceGender
            // 
            this.cbxSourceGender.FormattingEnabled = true;
            this.cbxSourceGender.Location = new System.Drawing.Point(17, 305);
            this.cbxSourceGender.Margin = new System.Windows.Forms.Padding(2);
            this.cbxSourceGender.Name = "cbxSourceGender";
            this.cbxSourceGender.Size = new System.Drawing.Size(242, 28);
            this.cbxSourceGender.TabIndex = 47;
            this.cbxSourceGender.Text = "Male";
            // 
            // cbxTargetGender
            // 
            this.cbxTargetGender.FormattingEnabled = true;
            this.cbxTargetGender.Location = new System.Drawing.Point(17, 388);
            this.cbxTargetGender.Margin = new System.Windows.Forms.Padding(2);
            this.cbxTargetGender.Name = "cbxTargetGender";
            this.cbxTargetGender.Size = new System.Drawing.Size(242, 28);
            this.cbxTargetGender.TabIndex = 48;
            this.cbxTargetGender.Text = "Female";
            // 
            // btnHide
            // 
            this.btnHide.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnHide.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHide.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnHide.Location = new System.Drawing.Point(473, 365);
            this.btnHide.Margin = new System.Windows.Forms.Padding(2);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(215, 69);
            this.btnHide.TabIndex = 49;
            this.btnHide.Text = "hide";
            this.btnHide.UseVisualStyleBackColor = false;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // cbxRelations
            // 
            this.cbxRelations.FormattingEnabled = true;
            this.cbxRelations.Items.AddRange(new object[] {
            "senior to junior",
            "junior to senior",
            "equal status"});
            this.cbxRelations.Location = new System.Drawing.Point(439, 305);
            this.cbxRelations.Margin = new System.Windows.Forms.Padding(2);
            this.cbxRelations.Name = "cbxRelations";
            this.cbxRelations.Size = new System.Drawing.Size(242, 28);
            this.cbxRelations.TabIndex = 50;
            this.cbxRelations.Text = "equal status";
            // 
            // cbxPersonChange
            // 
            this.cbxPersonChange.FormattingEnabled = true;
            this.cbxPersonChange.Location = new System.Drawing.Point(439, 139);
            this.cbxPersonChange.Margin = new System.Windows.Forms.Padding(2);
            this.cbxPersonChange.Name = "cbxPersonChange";
            this.cbxPersonChange.Size = new System.Drawing.Size(242, 28);
            this.cbxPersonChange.TabIndex = 51;
            this.cbxPersonChange.Text = "EqualStatus";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(433, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 32);
            this.label3.TabIndex = 52;
            this.label3.Text = "Change Person";
            // 
            // lblSpkRelations
            // 
            this.lblSpkRelations.AutoSize = true;
            this.lblSpkRelations.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpkRelations.Location = new System.Drawing.Point(433, 267);
            this.lblSpkRelations.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSpkRelations.Name = "lblSpkRelations";
            this.lblSpkRelations.Size = new System.Drawing.Size(135, 32);
            this.lblSpkRelations.TabIndex = 53;
            this.lblSpkRelations.Text = "Relations";
            this.lblSpkRelations.Visible = false;
            // 
            // cbxFormality
            // 
            this.cbxFormality.FormattingEnabled = true;
            this.cbxFormality.Location = new System.Drawing.Point(17, 222);
            this.cbxFormality.Margin = new System.Windows.Forms.Padding(2);
            this.cbxFormality.Name = "cbxFormality";
            this.cbxFormality.Size = new System.Drawing.Size(242, 28);
            this.cbxFormality.TabIndex = 55;
            this.cbxFormality.Text = "Neutral";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 186);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 32);
            this.label4.TabIndex = 54;
            this.label4.Text = "Formality";
            // 
            // cbxPolite
            // 
            this.cbxPolite.FormattingEnabled = true;
            this.cbxPolite.Location = new System.Drawing.Point(439, 222);
            this.cbxPolite.Margin = new System.Windows.Forms.Padding(2);
            this.cbxPolite.Name = "cbxPolite";
            this.cbxPolite.Size = new System.Drawing.Size(242, 28);
            this.cbxPolite.TabIndex = 57;
            this.cbxPolite.Text = "Neutral";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(433, 186);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 32);
            this.label5.TabIndex = 56;
            this.label5.Text = "Politeness";
            // 
            // ContextForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(699, 445);
            this.Controls.Add(this.cbxPolite);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxFormality);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblSpkRelations);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxPersonChange);
            this.Controls.Add(this.cbxRelations);
            this.Controls.Add(this.btnHide);
            this.Controls.Add(this.cbxTargetGender);
            this.Controls.Add(this.cbxSourceGender);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxIForce);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbxDisplay);
            this.Controls.Add(this.lblDisplay);
            this.Name = "ContextForm";
            this.Text = "Context Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ComboBox cbxIForce;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.ComboBox cbxDisplay;
        internal System.Windows.Forms.Label lblDisplay;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.ComboBox cbxSourceGender;
        internal System.Windows.Forms.ComboBox cbxTargetGender;
        private System.Windows.Forms.Button btnHide;
        internal System.Windows.Forms.ComboBox cbxRelations;
        internal System.Windows.Forms.ComboBox cbxPersonChange;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label lblSpkRelations;
        internal System.Windows.Forms.ComboBox cbxFormality;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.ComboBox cbxPolite;
        internal System.Windows.Forms.Label label5;
    }
}