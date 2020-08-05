using System.ComponentModel;
using System.Windows.Forms;

namespace IdleMaster
{
    partial class frmChangelog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangelog));
            this.rtbChangelog = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbChangelog
            // 
            this.rtbChangelog.BackColor = System.Drawing.Color.White;
            this.rtbChangelog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbChangelog.Location = new System.Drawing.Point(0, 0);
            this.rtbChangelog.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtbChangelog.Name = "rtbChangelog";
            this.rtbChangelog.ReadOnly = true;
            this.rtbChangelog.Size = new System.Drawing.Size(752, 711);
            this.rtbChangelog.TabIndex = 0;
            this.rtbChangelog.Text = "";
            this.rtbChangelog.TextChanged += new System.EventHandler(this.rtbChangelog_TextChanged);
            // 
            // frmChangelog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 711);
            this.Controls.Add(this.rtbChangelog);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmChangelog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Steam Idle - Changelog";
            this.Load += new System.EventHandler(this.frmChangelog_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox rtbChangelog;
    }
}