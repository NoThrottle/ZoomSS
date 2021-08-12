namespace ZoomSS
{
    partial class ZoomSS
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZoomSS));
            this.SetBounds = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FilenamePrefix = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.IndexCount = new System.Windows.Forms.TextBox();
            this.TakeSS = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.exit = new System.Windows.Forms.Button();
            this.infobutton = new System.Windows.Forms.Button();
            this.Settings = new System.Windows.Forms.Button();
            this.CMStray = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitapplication = new System.Windows.Forms.ToolStripMenuItem();
            this.CMStray.SuspendLayout();
            this.SuspendLayout();
            // 
            // SetBounds
            // 
            this.SetBounds.ForeColor = System.Drawing.Color.Black;
            this.SetBounds.Location = new System.Drawing.Point(6, 53);
            this.SetBounds.Name = "SetBounds";
            this.SetBounds.Size = new System.Drawing.Size(58, 44);
            this.SetBounds.TabIndex = 0;
            this.SetBounds.Text = "Set Bounds";
            this.SetBounds.UseVisualStyleBackColor = true;
            this.SetBounds.Click += new System.EventHandler(this.SetBounds_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filename Prefix";
            // 
            // FilenamePrefix
            // 
            this.FilenamePrefix.Location = new System.Drawing.Point(70, 28);
            this.FilenamePrefix.MaxLength = 30;
            this.FilenamePrefix.Name = "FilenamePrefix";
            this.FilenamePrefix.Size = new System.Drawing.Size(125, 20);
            this.FilenamePrefix.TabIndex = 2;
            this.FilenamePrefix.TextChanged += new System.EventHandler(this.FilenamePrefix_TextChanged);
            this.FilenamePrefix.MouseHover += new System.EventHandler(this.FilenamePrefix_MouseHover);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Index";
            // 
            // IndexCount
            // 
            this.IndexCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IndexCount.Enabled = false;
            this.IndexCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IndexCount.Location = new System.Drawing.Point(70, 72);
            this.IndexCount.MaxLength = 5;
            this.IndexCount.Multiline = true;
            this.IndexCount.Name = "IndexCount";
            this.IndexCount.Size = new System.Drawing.Size(45, 20);
            this.IndexCount.TabIndex = 5;
            this.IndexCount.Text = "0";
            this.IndexCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.IndexCount.TextChanged += new System.EventHandler(this.IndexCount_TextChanged);
            // 
            // TakeSS
            // 
            this.TakeSS.ForeColor = System.Drawing.Color.Black;
            this.TakeSS.Location = new System.Drawing.Point(6, 9);
            this.TakeSS.Name = "TakeSS";
            this.TakeSS.Size = new System.Drawing.Size(58, 40);
            this.TakeSS.TabIndex = 7;
            this.TakeSS.Text = "Take SS";
            this.TakeSS.UseVisualStyleBackColor = true;
            this.TakeSS.Click += new System.EventHandler(this.TakeSS_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipTitle = "ZoomSS";
            this.notifyIcon.ContextMenuStrip = this.CMStray;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "ZoomSS";
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // exit
            // 
            this.exit.BackgroundImage = global::ZoomSS.Properties.Resources.exit_idle;
            this.exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Location = new System.Drawing.Point(121, 63);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(24, 24);
            this.exit.TabIndex = 9;
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // infobutton
            // 
            this.infobutton.BackgroundImage = global::ZoomSS.Properties.Resources.info_idle;
            this.infobutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.infobutton.FlatAppearance.BorderSize = 0;
            this.infobutton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.infobutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.infobutton.ForeColor = System.Drawing.Color.Black;
            this.infobutton.Location = new System.Drawing.Point(171, 63);
            this.infobutton.Name = "infobutton";
            this.infobutton.Size = new System.Drawing.Size(24, 24);
            this.infobutton.TabIndex = 8;
            this.infobutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.infobutton.UseVisualStyleBackColor = true;
            this.infobutton.Click += new System.EventHandler(this.infobutton_Click);
            // 
            // Settings
            // 
            this.Settings.BackColor = System.Drawing.Color.Transparent;
            this.Settings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Settings.BackgroundImage")));
            this.Settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Settings.FlatAppearance.BorderSize = 0;
            this.Settings.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Settings.ForeColor = System.Drawing.Color.Transparent;
            this.Settings.Location = new System.Drawing.Point(146, 63);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(24, 24);
            this.Settings.TabIndex = 6;
            this.Settings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Settings.UseVisualStyleBackColor = false;
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // CMStray
            // 
            this.CMStray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitapplication});
            this.CMStray.Name = "CMStray";
            this.CMStray.Size = new System.Drawing.Size(94, 26);
            this.CMStray.Opening += new System.ComponentModel.CancelEventHandler(this.CMStray_Opening);
            // 
            // exitapplication
            // 
            this.exitapplication.Name = "exitapplication";
            this.exitapplication.Size = new System.Drawing.Size(180, 22);
            this.exitapplication.Text = "Exit";
            this.exitapplication.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.exitapplication.Click += new System.EventHandler(this.exitapplication_Click);
            // 
            // ZoomSS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(203, 104);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.infobutton);
            this.Controls.Add(this.TakeSS);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.IndexCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FilenamePrefix);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SetBounds);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ZoomSS";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ZoomSS";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.CMStray.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SetBounds;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FilenamePrefix;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Settings;
        private System.Windows.Forms.Button TakeSS;
        private System.Windows.Forms.Button infobutton;
        private System.Windows.Forms.TextBox IndexCount;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.ContextMenuStrip CMStray;
        private System.Windows.Forms.ToolStripMenuItem exitapplication;
    }
}

