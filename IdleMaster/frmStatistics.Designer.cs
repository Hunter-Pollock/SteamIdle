﻿namespace IdleMaster
{
    partial class frmStatistics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStatistics));
            this.btnOK = new System.Windows.Forms.Button();
            this.lblSessionTime = new System.Windows.Forms.Label();
            this.lblSessionCards = new System.Windows.Forms.Label();
            this.lblTotalCards = new System.Windows.Forms.Label();
            this.lblTotalTime = new System.Windows.Forms.Label();
            this.lblSessionHeader = new System.Windows.Forms.Label();
            this.lblTotalHeader = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(233, 159);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 28);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblSessionTime
            // 
            this.lblSessionTime.AutoSize = true;
            this.lblSessionTime.Location = new System.Drawing.Point(16, 36);
            this.lblSessionTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSessionTime.Name = "lblSessionTime";
            this.lblSessionTime.Size = new System.Drawing.Size(87, 17);
            this.lblSessionTime.TabIndex = 1;
            this.lblSessionTime.Text = "sessionTime";
            // 
            // lblSessionCards
            // 
            this.lblSessionCards.AutoSize = true;
            this.lblSessionCards.Location = new System.Drawing.Point(16, 54);
            this.lblSessionCards.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSessionCards.Name = "lblSessionCards";
            this.lblSessionCards.Size = new System.Drawing.Size(93, 17);
            this.lblSessionCards.TabIndex = 2;
            this.lblSessionCards.Text = "sessionCards";
            // 
            // lblTotalCards
            // 
            this.lblTotalCards.AutoSize = true;
            this.lblTotalCards.Location = new System.Drawing.Point(16, 128);
            this.lblTotalCards.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalCards.Name = "lblTotalCards";
            this.lblTotalCards.Size = new System.Drawing.Size(72, 17);
            this.lblTotalCards.TabIndex = 3;
            this.lblTotalCards.Text = "totalCards";
            // 
            // lblTotalTime
            // 
            this.lblTotalTime.AutoSize = true;
            this.lblTotalTime.Location = new System.Drawing.Point(16, 110);
            this.lblTotalTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalTime.Name = "lblTotalTime";
            this.lblTotalTime.Size = new System.Drawing.Size(66, 17);
            this.lblTotalTime.TabIndex = 4;
            this.lblTotalTime.Text = "totalTime";
            // 
            // lblSessionHeader
            // 
            this.lblSessionHeader.AutoSize = true;
            this.lblSessionHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSessionHeader.Location = new System.Drawing.Point(13, 11);
            this.lblSessionHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSessionHeader.Name = "lblSessionHeader";
            this.lblSessionHeader.Size = new System.Drawing.Size(104, 17);
            this.lblSessionHeader.TabIndex = 5;
            this.lblSessionHeader.Text = "This session:";
            // 
            // lblTotalHeader
            // 
            this.lblTotalHeader.AutoSize = true;
            this.lblTotalHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalHeader.Location = new System.Drawing.Point(13, 85);
            this.lblTotalHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalHeader.Name = "lblTotalHeader";
            this.lblTotalHeader.Size = new System.Drawing.Size(50, 17);
            this.lblTotalHeader.TabIndex = 6;
            this.lblTotalHeader.Text = "Total:";
            // 
            // frmStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 193);
            this.Controls.Add(this.lblTotalHeader);
            this.Controls.Add(this.lblSessionHeader);
            this.Controls.Add(this.lblTotalTime);
            this.Controls.Add(this.lblTotalCards);
            this.Controls.Add(this.lblSessionCards);
            this.Controls.Add(this.lblSessionTime);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmStatistics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Steam Idle - Statistics";
            this.Load += new System.EventHandler(this.frmStatistics_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblSessionTime;
        private System.Windows.Forms.Label lblSessionCards;
        private System.Windows.Forms.Label lblTotalCards;
        private System.Windows.Forms.Label lblTotalTime;
        private System.Windows.Forms.Label lblSessionHeader;
        private System.Windows.Forms.Label lblTotalHeader;
    }
}