using System.ComponentModel;
using System.Windows.Forms;

namespace IdleMaster
{
    partial class frmWhitelist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWhitelist));
            this.lstWhitelist = new System.Windows.Forms.ListBox();
            this.grpAdd = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtAppid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.grpAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstWhitelist
            // 
            this.lstWhitelist.FormattingEnabled = true;
            this.lstWhitelist.ItemHeight = 16;
            this.lstWhitelist.Location = new System.Drawing.Point(17, 16);
            this.lstWhitelist.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstWhitelist.Name = "lstWhitelist";
            this.lstWhitelist.Size = new System.Drawing.Size(359, 388);
            this.lstWhitelist.Sorted = true;
            this.lstWhitelist.TabIndex = 0;
            // 
            // grpAdd
            // 
            this.grpAdd.Controls.Add(this.btnAdd);
            this.grpAdd.Controls.Add(this.txtAppid);
            this.grpAdd.Controls.Add(this.label1);
            this.grpAdd.Location = new System.Drawing.Point(17, 414);
            this.grpAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpAdd.Name = "grpAdd";
            this.grpAdd.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpAdd.Size = new System.Drawing.Size(241, 94);
            this.grpAdd.TabIndex = 1;
            this.grpAdd.TabStop = false;
            this.grpAdd.Text = "Add Game to Whitelist";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(133, 53);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 28);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtAppid
            // 
            this.txtAppid.Location = new System.Drawing.Point(75, 21);
            this.txtAppid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAppid.Name = "txtAppid";
            this.txtAppid.Size = new System.Drawing.Size(157, 22);
            this.txtAppid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "App ID:";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(316, 471);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 28);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Image = global::IdleMaster.Properties.Resources.imgTrash;
            this.btnRemove.Location = new System.Drawing.Point(385, 16);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(37, 34);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // frmWhitelist
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 514);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.grpAdd);
            this.Controls.Add(this.lstWhitelist);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmWhitelist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Steam Idle - Whitelist";
            this.Load += new System.EventHandler(this.frmWhitelist_Load);
            this.grpAdd.ResumeLayout(false);
            this.grpAdd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox lstWhitelist;
        private GroupBox grpAdd;
        private Button btnRemove;
        private Button btnSave;
        private Button btnAdd;
        private TextBox txtAppid;
        private Label label1;
    }
}