namespace PatTuring2016.Speech.Forms
{
    partial class SyllabusForm
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
            this.btnReset = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.tbxSyllabus = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnSyllabus = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnHide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Crimson;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnReset.Location = new System.Drawing.Point(502, 216);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(263, 83);
            this.btnReset.TabIndex = 40;
            this.btnReset.Text = "reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnLast
            // 
            this.btnLast.BackColor = System.Drawing.Color.Azure;
            this.btnLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnLast.Location = new System.Drawing.Point(21, 216);
            this.btnLast.Margin = new System.Windows.Forms.Padding(2);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(263, 83);
            this.btnLast.TabIndex = 39;
            this.btnLast.Text = "say last";
            this.btnLast.UseVisualStyleBackColor = false;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // tbxSyllabus
            // 
            this.tbxSyllabus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSyllabus.Location = new System.Drawing.Point(20, 56);
            this.tbxSyllabus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxSyllabus.Name = "tbxSyllabus";
            this.tbxSyllabus.Size = new System.Drawing.Size(745, 44);
            this.tbxSyllabus.TabIndex = 38;
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLoad.Location = new System.Drawing.Point(20, 118);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(263, 83);
            this.btnLoad.TabIndex = 37;
            this.btnLoad.Text = "load";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.BackColor = System.Drawing.Color.Navy;
            this.btnDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplay.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDisplay.Location = new System.Drawing.Point(21, 314);
            this.btnDisplay.Margin = new System.Windows.Forms.Padding(2);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(263, 83);
            this.btnDisplay.TabIndex = 36;
            this.btnDisplay.Text = "see last";
            this.btnDisplay.UseVisualStyleBackColor = false;
            // 
            // btnSyllabus
            // 
            this.btnSyllabus.BackColor = System.Drawing.Color.PowderBlue;
            this.btnSyllabus.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSyllabus.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSyllabus.Location = new System.Drawing.Point(502, 118);
            this.btnSyllabus.Margin = new System.Windows.Forms.Padding(2);
            this.btnSyllabus.Name = "btnSyllabus";
            this.btnSyllabus.Size = new System.Drawing.Size(263, 83);
            this.btnSyllabus.TabIndex = 35;
            this.btnSyllabus.Text = "say all";
            this.btnSyllabus.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 11);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(230, 38);
            this.label6.TabIndex = 34;
            this.label6.Text = "Loaded Syllabi";
            // 
            // btnHide
            // 
            this.btnHide.BackColor = System.Drawing.Color.Thistle;
            this.btnHide.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHide.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnHide.Location = new System.Drawing.Point(502, 358);
            this.btnHide.Margin = new System.Windows.Forms.Padding(2);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(263, 83);
            this.btnHide.TabIndex = 50;
            this.btnHide.Text = "hide";
            this.btnHide.UseVisualStyleBackColor = false;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // SyllabusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(780, 454);
            this.Controls.Add(this.btnHide);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.tbxSyllabus);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.btnSyllabus);
            this.Controls.Add(this.label6);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SyllabusForm";
            this.Text = "Syllabus Selection Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnLast;
        internal System.Windows.Forms.TextBox tbxSyllabus;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnSyllabus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnHide;
    }
}