﻿namespace ets2mplauncher
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.Directories_container = new System.Windows.Forms.GroupBox();
            this.ets2mp_brw_btn = new System.Windows.Forms.Button();
            this.ets2mp_dir_txt = new System.Windows.Forms.TextBox();
            this.ets2mp_dir_label = new System.Windows.Forms.Label();
            this.Launcher_container = new System.Windows.Forms.GroupBox();
            this.LauncherClose_chkbox = new System.Windows.Forms.CheckBox();
            this.UpdateCheck_btn = new System.Windows.Forms.Button();
            this.Done_btn = new System.Windows.Forms.Button();
            this.Browse_Dialog = new System.Windows.Forms.FolderBrowserDialog();
            this.Settings_tabControl = new System.Windows.Forms.TabControl();
            this.Launcher_tab = new System.Windows.Forms.TabPage();
            this.ets2mp_tab = new System.Windows.Forms.TabPage();
            this.NotImplemented_label = new System.Windows.Forms.Label();
            this.ets2_tab = new System.Windows.Forms.TabPage();
            this.ets2sin_chkbox = new System.Windows.Forms.CheckBox();
            this.AutoUpdate_chkbox = new System.Windows.Forms.CheckBox();
            this.Directories_container.SuspendLayout();
            this.Launcher_container.SuspendLayout();
            this.Settings_tabControl.SuspendLayout();
            this.Launcher_tab.SuspendLayout();
            this.ets2mp_tab.SuspendLayout();
            this.ets2_tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // Directories_container
            // 
            this.Directories_container.Controls.Add(this.ets2mp_brw_btn);
            this.Directories_container.Controls.Add(this.ets2mp_dir_txt);
            this.Directories_container.Controls.Add(this.ets2mp_dir_label);
            this.Directories_container.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Directories_container.Location = new System.Drawing.Point(6, 6);
            this.Directories_container.Name = "Directories_container";
            this.Directories_container.Size = new System.Drawing.Size(526, 57);
            this.Directories_container.TabIndex = 0;
            this.Directories_container.TabStop = false;
            this.Directories_container.Text = "Directory";
            // 
            // ets2mp_brw_btn
            // 
            this.ets2mp_brw_btn.Location = new System.Drawing.Point(445, 20);
            this.ets2mp_brw_btn.Name = "ets2mp_brw_btn";
            this.ets2mp_brw_btn.Size = new System.Drawing.Size(75, 27);
            this.ets2mp_brw_btn.TabIndex = 4;
            this.ets2mp_brw_btn.Text = "Browse";
            this.ets2mp_brw_btn.UseVisualStyleBackColor = true;
            this.ets2mp_brw_btn.Click += new System.EventHandler(this.ets2mp_brw_btn_Click);
            // 
            // ets2mp_dir_txt
            // 
            this.ets2mp_dir_txt.Location = new System.Drawing.Point(77, 20);
            this.ets2mp_dir_txt.Name = "ets2mp_dir_txt";
            this.ets2mp_dir_txt.Size = new System.Drawing.Size(362, 27);
            this.ets2mp_dir_txt.TabIndex = 2;
            // 
            // ets2mp_dir_label
            // 
            this.ets2mp_dir_label.AutoSize = true;
            this.ets2mp_dir_label.Location = new System.Drawing.Point(6, 23);
            this.ets2mp_dir_label.Name = "ets2mp_dir_label";
            this.ets2mp_dir_label.Size = new System.Drawing.Size(65, 19);
            this.ets2mp_dir_label.TabIndex = 0;
            this.ets2mp_dir_label.Text = "ETS2MP:";
            // 
            // Launcher_container
            // 
            this.Launcher_container.Controls.Add(this.AutoUpdate_chkbox);
            this.Launcher_container.Controls.Add(this.LauncherClose_chkbox);
            this.Launcher_container.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Launcher_container.Location = new System.Drawing.Point(6, 69);
            this.Launcher_container.Name = "Launcher_container";
            this.Launcher_container.Size = new System.Drawing.Size(526, 81);
            this.Launcher_container.TabIndex = 2;
            this.Launcher_container.TabStop = false;
            this.Launcher_container.Text = "Launcher";
            // 
            // LauncherClose_chkbox
            // 
            this.LauncherClose_chkbox.AutoSize = true;
            this.LauncherClose_chkbox.Location = new System.Drawing.Point(7, 21);
            this.LauncherClose_chkbox.Name = "LauncherClose_chkbox";
            this.LauncherClose_chkbox.Size = new System.Drawing.Size(227, 23);
            this.LauncherClose_chkbox.TabIndex = 0;
            this.LauncherClose_chkbox.Text = "Don\'t close after game launch.";
            this.LauncherClose_chkbox.UseVisualStyleBackColor = true;
            // 
            // UpdateCheck_btn
            // 
            this.UpdateCheck_btn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateCheck_btn.Location = new System.Drawing.Point(4, 194);
            this.UpdateCheck_btn.Name = "UpdateCheck_btn";
            this.UpdateCheck_btn.Size = new System.Drawing.Size(140, 27);
            this.UpdateCheck_btn.TabIndex = 1;
            this.UpdateCheck_btn.Text = "Check for updates";
            this.UpdateCheck_btn.UseVisualStyleBackColor = true;
            this.UpdateCheck_btn.Click += new System.EventHandler(this.UpdateCheck_btn_Click);
            // 
            // Done_btn
            // 
            this.Done_btn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Done_btn.Location = new System.Drawing.Point(471, 194);
            this.Done_btn.Name = "Done_btn";
            this.Done_btn.Size = new System.Drawing.Size(75, 27);
            this.Done_btn.TabIndex = 3;
            this.Done_btn.Text = "Done";
            this.Done_btn.UseVisualStyleBackColor = true;
            this.Done_btn.Click += new System.EventHandler(this.Done_btn_Click);
            // 
            // Settings_tabControl
            // 
            this.Settings_tabControl.Controls.Add(this.Launcher_tab);
            this.Settings_tabControl.Controls.Add(this.ets2mp_tab);
            this.Settings_tabControl.Controls.Add(this.ets2_tab);
            this.Settings_tabControl.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Settings_tabControl.Location = new System.Drawing.Point(0, 0);
            this.Settings_tabControl.Name = "Settings_tabControl";
            this.Settings_tabControl.SelectedIndex = 0;
            this.Settings_tabControl.Size = new System.Drawing.Size(550, 188);
            this.Settings_tabControl.TabIndex = 4;
            // 
            // Launcher_tab
            // 
            this.Launcher_tab.Controls.Add(this.Directories_container);
            this.Launcher_tab.Controls.Add(this.Launcher_container);
            this.Launcher_tab.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Launcher_tab.Location = new System.Drawing.Point(4, 28);
            this.Launcher_tab.Name = "Launcher_tab";
            this.Launcher_tab.Padding = new System.Windows.Forms.Padding(3);
            this.Launcher_tab.Size = new System.Drawing.Size(542, 156);
            this.Launcher_tab.TabIndex = 0;
            this.Launcher_tab.Text = "Launcher";
            this.Launcher_tab.UseVisualStyleBackColor = true;
            // 
            // ets2mp_tab
            // 
            this.ets2mp_tab.Controls.Add(this.NotImplemented_label);
            this.ets2mp_tab.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ets2mp_tab.Location = new System.Drawing.Point(4, 28);
            this.ets2mp_tab.Name = "ets2mp_tab";
            this.ets2mp_tab.Padding = new System.Windows.Forms.Padding(3);
            this.ets2mp_tab.Size = new System.Drawing.Size(542, 156);
            this.ets2mp_tab.TabIndex = 1;
            this.ets2mp_tab.Text = "ETS2MP";
            this.ets2mp_tab.UseVisualStyleBackColor = true;
            // 
            // NotImplemented_label
            // 
            this.NotImplemented_label.AutoSize = true;
            this.NotImplemented_label.Location = new System.Drawing.Point(125, 67);
            this.NotImplemented_label.Name = "NotImplemented_label";
            this.NotImplemented_label.Size = new System.Drawing.Size(293, 19);
            this.NotImplemented_label.TabIndex = 0;
            this.NotImplemented_label.Text = "This feature has not been implemented yet!";
            // 
            // ets2_tab
            // 
            this.ets2_tab.Controls.Add(this.ets2sin_chkbox);
            this.ets2_tab.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ets2_tab.Location = new System.Drawing.Point(4, 28);
            this.ets2_tab.Name = "ets2_tab";
            this.ets2_tab.Size = new System.Drawing.Size(542, 156);
            this.ets2_tab.TabIndex = 2;
            this.ets2_tab.Text = "ETS2";
            this.ets2_tab.UseVisualStyleBackColor = true;
            // 
            // ets2sin_chkbox
            // 
            this.ets2sin_chkbox.AutoSize = true;
            this.ets2sin_chkbox.Location = new System.Drawing.Point(8, 3);
            this.ets2sin_chkbox.Name = "ets2sin_chkbox";
            this.ets2sin_chkbox.Size = new System.Drawing.Size(88, 23);
            this.ets2sin_chkbox.TabIndex = 0;
            this.ets2sin_chkbox.Text = "Skip intro";
            this.ets2sin_chkbox.UseVisualStyleBackColor = true;
            // 
            // AutoUpdate_chkbox
            // 
            this.AutoUpdate_chkbox.AutoSize = true;
            this.AutoUpdate_chkbox.Location = new System.Drawing.Point(7, 50);
            this.AutoUpdate_chkbox.Name = "AutoUpdate_chkbox";
            this.AutoUpdate_chkbox.Size = new System.Drawing.Size(285, 23);
            this.AutoUpdate_chkbox.TabIndex = 1;
            this.AutoUpdate_chkbox.Text = "Check for launcher updates automaticly";
            this.AutoUpdate_chkbox.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 233);
            this.Controls.Add(this.Done_btn);
            this.Controls.Add(this.UpdateCheck_btn);
            this.Controls.Add(this.Settings_tabControl);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ETS2MP Launcher - Settings";
            this.Directories_container.ResumeLayout(false);
            this.Directories_container.PerformLayout();
            this.Launcher_container.ResumeLayout(false);
            this.Launcher_container.PerformLayout();
            this.Settings_tabControl.ResumeLayout(false);
            this.Launcher_tab.ResumeLayout(false);
            this.ets2mp_tab.ResumeLayout(false);
            this.ets2mp_tab.PerformLayout();
            this.ets2_tab.ResumeLayout(false);
            this.ets2_tab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Directories_container;
        private System.Windows.Forms.Button ets2mp_brw_btn;
        private System.Windows.Forms.TextBox ets2mp_dir_txt;
        private System.Windows.Forms.Label ets2mp_dir_label;
        private System.Windows.Forms.GroupBox Launcher_container;
        private System.Windows.Forms.CheckBox LauncherClose_chkbox;
        private System.Windows.Forms.Button UpdateCheck_btn;
        private System.Windows.Forms.Button Done_btn;
        private System.Windows.Forms.FolderBrowserDialog Browse_Dialog;
        private System.Windows.Forms.TabControl Settings_tabControl;
        private System.Windows.Forms.TabPage Launcher_tab;
        private System.Windows.Forms.TabPage ets2mp_tab;
        private System.Windows.Forms.Label NotImplemented_label;
        private System.Windows.Forms.TabPage ets2_tab;
        private System.Windows.Forms.CheckBox ets2sin_chkbox;
        private System.Windows.Forms.CheckBox AutoUpdate_chkbox;
    }
}