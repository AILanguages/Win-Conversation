using System.Web.UI.WebControls;
using Antlr.Runtime.Tree;

namespace PatTuring2016.Speech.Forms
{
    partial class Converser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Converser));
            this.tbxEntry = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbxGeneration = new System.Windows.Forms.TextBox();
            this.tbxOutput = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnTextIn = new TransparentControl();
            this.btnQuiet = new TransparentControl();
            this.btnRestart = new TransparentControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxEntry
            // 
            this.tbxEntry.Font = new System.Drawing.Font("Arial", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxEntry.Location = new System.Drawing.Point(652, 1200);
            this.tbxEntry.Margin = new System.Windows.Forms.Padding(0);
            this.tbxEntry.Multiline = true;
            this.tbxEntry.Name = "tbxEntry";
            this.tbxEntry.Size = new System.Drawing.Size(1534, 75);
            this.tbxEntry.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(2976, 1345);
            this.pictureBox1.TabIndex = 64;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tbxGeneration
            // 
            this.tbxGeneration.BackColor = System.Drawing.Color.White;
            this.tbxGeneration.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxGeneration.Font = new System.Drawing.Font("Arial", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxGeneration.ForeColor = System.Drawing.Color.Black;
            this.tbxGeneration.Location = new System.Drawing.Point(739, 771);
            this.tbxGeneration.Margin = new System.Windows.Forms.Padding(4);
            this.tbxGeneration.Multiline = true;
            this.tbxGeneration.Name = "tbxGeneration";
            this.tbxGeneration.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxGeneration.Size = new System.Drawing.Size(1911, 310);
            this.tbxGeneration.TabIndex = 10;
            this.tbxGeneration.TabStop = false;
            this.tbxGeneration.WordWrap = false;
            // 
            // tbxOutput
            // 
            this.tbxOutput.BackColor = System.Drawing.Color.White;
            this.tbxOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxOutput.Font = new System.Drawing.Font("Arial", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxOutput.ForeColor = System.Drawing.Color.Black;
            this.tbxOutput.Location = new System.Drawing.Point(687, 332);
            this.tbxOutput.Margin = new System.Windows.Forms.Padding(4);
            this.tbxOutput.Multiline = true;
            this.tbxOutput.Name = "tbxOutput";
            this.tbxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxOutput.Size = new System.Drawing.Size(1963, 295);
            this.tbxOutput.TabIndex = 9;
            this.tbxOutput.TabStop = false;
            this.tbxOutput.Text = "\"";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 12);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(22, 21);
            this.checkBox1.TabIndex = 66;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnTextIn
            // 
            this.btnTextIn.BackColor = System.Drawing.Color.Transparent;
            this.btnTextIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTextIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTextIn.ForeColor = System.Drawing.Color.Transparent;
            this.btnTextIn.Location = new System.Drawing.Point(2382, 1164);
            this.btnTextIn.Margin = new System.Windows.Forms.Padding(0);
            this.btnTextIn.Name = "btnTextIn";
            this.btnTextIn.Size = new System.Drawing.Size(293, 123);
            this.btnTextIn.TabIndex = 1;
            this.btnTextIn.TabStop = false;
            this.btnTextIn.Click += new System.EventHandler(this.btnTextIn_Click);
            // 
            // btnQuiet
            // 
            this.btnQuiet.BackColor = System.Drawing.Color.Transparent;
            this.btnQuiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.btnQuiet.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnQuiet.Location = new System.Drawing.Point(947, 28);
            this.btnQuiet.Margin = new System.Windows.Forms.Padding(0);
            this.btnQuiet.Name = "btnQuiet";
            this.btnQuiet.Size = new System.Drawing.Size(289, 75);
            this.btnQuiet.TabIndex = 2;
            this.btnQuiet.TabStop = false;
            this.btnQuiet.Click += new System.EventHandler(this.btnQuiet_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.Transparent;
            this.btnRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.ForeColor = System.Drawing.Color.Transparent;
            this.btnRestart.Location = new System.Drawing.Point(2042, 30);
            this.btnRestart.Margin = new System.Windows.Forms.Padding(0);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(270, 73);
            this.btnRestart.TabIndex = 3;
            this.btnRestart.TabStop = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // Converser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(2976, 1345);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.tbxGeneration);
            this.Controls.Add(this.btnTextIn);
            this.Controls.Add(this.tbxEntry);
            this.Controls.Add(this.btnQuiet);
            this.Controls.Add(this.tbxOutput);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Converser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pat Inc. Conversation Using Speech";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TransparentControl btnRestart;
        internal System.Windows.Forms.TextBox tbxOutput;
        internal System.Windows.Forms.TextBox tbxGeneration;
        private TransparentControl btnTextIn;
        private System.Windows.Forms.TextBox tbxEntry;
        private TransparentControl btnQuiet;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

