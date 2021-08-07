﻿
namespace SchoolApplication {
	partial class FrmMain {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.panelSidepanel = new System.Windows.Forms.Panel();
			this.pnlMenuButtonSelection = new System.Windows.Forms.Panel();
			this.btnShortcuts = new System.Windows.Forms.Button();
			this.btnTemplates = new System.Windows.Forms.Button();
			this.btnSettings = new System.Windows.Forms.Button();
			this.btnDashboard = new System.Windows.Forms.Button();
			this.panelUser = new System.Windows.Forms.Panel();
			this.panelHeader = new System.Windows.Forms.Panel();
			this.lblPageTitle = new System.Windows.Forms.Label();
			this.pnlPage = new System.Windows.Forms.Panel();
			this.panelSidepanel.SuspendLayout();
			this.panelHeader.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelSidepanel
			// 
			this.panelSidepanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.panelSidepanel.Controls.Add(this.pnlMenuButtonSelection);
			this.panelSidepanel.Controls.Add(this.btnShortcuts);
			this.panelSidepanel.Controls.Add(this.btnTemplates);
			this.panelSidepanel.Controls.Add(this.btnSettings);
			this.panelSidepanel.Controls.Add(this.btnDashboard);
			this.panelSidepanel.Controls.Add(this.panelUser);
			this.panelSidepanel.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelSidepanel.Location = new System.Drawing.Point(0, 0);
			this.panelSidepanel.MaximumSize = new System.Drawing.Size(250, 1080);
			this.panelSidepanel.MinimumSize = new System.Drawing.Size(250, 540);
			this.panelSidepanel.Name = "panelSidepanel";
			this.panelSidepanel.Size = new System.Drawing.Size(250, 540);
			this.panelSidepanel.TabIndex = 0;
			// 
			// pnlMenuButtonSelection
			// 
			this.pnlMenuButtonSelection.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.pnlMenuButtonSelection.Location = new System.Drawing.Point(0, 204);
			this.pnlMenuButtonSelection.Name = "pnlMenuButtonSelection";
			this.pnlMenuButtonSelection.Size = new System.Drawing.Size(6, 60);
			this.pnlMenuButtonSelection.TabIndex = 8;
			// 
			// btnShortcuts
			// 
			this.btnShortcuts.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnShortcuts.FlatAppearance.BorderSize = 0;
			this.btnShortcuts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnShortcuts.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnShortcuts.Image = global::SchoolApplication.Properties.Resources.outline_language_black_24dp;
			this.btnShortcuts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnShortcuts.Location = new System.Drawing.Point(0, 270);
			this.btnShortcuts.Name = "btnShortcuts";
			this.btnShortcuts.Padding = new System.Windows.Forms.Padding(30, 0, 30, 0);
			this.btnShortcuts.Size = new System.Drawing.Size(250, 60);
			this.btnShortcuts.TabIndex = 7;
			this.btnShortcuts.Text = "Shortcuts";
			this.btnShortcuts.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnShortcuts.UseVisualStyleBackColor = true;
			this.btnShortcuts.Click += new System.EventHandler(this.PageButtonClick);
			// 
			// btnTemplates
			// 
			this.btnTemplates.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnTemplates.FlatAppearance.BorderSize = 0;
			this.btnTemplates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnTemplates.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTemplates.Image = global::SchoolApplication.Properties.Resources.outline_source_black_24dp;
			this.btnTemplates.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnTemplates.Location = new System.Drawing.Point(0, 210);
			this.btnTemplates.Name = "btnTemplates";
			this.btnTemplates.Padding = new System.Windows.Forms.Padding(30, 0, 30, 0);
			this.btnTemplates.Size = new System.Drawing.Size(250, 60);
			this.btnTemplates.TabIndex = 6;
			this.btnTemplates.Text = "Templates";
			this.btnTemplates.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnTemplates.UseVisualStyleBackColor = true;
			this.btnTemplates.Click += new System.EventHandler(this.PageButtonClick);
			// 
			// btnSettings
			// 
			this.btnSettings.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.btnSettings.FlatAppearance.BorderSize = 0;
			this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSettings.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSettings.Image = global::SchoolApplication.Properties.Resources.outline_settings_black_24dp;
			this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSettings.Location = new System.Drawing.Point(0, 480);
			this.btnSettings.Name = "btnSettings";
			this.btnSettings.Padding = new System.Windows.Forms.Padding(30, 0, 30, 0);
			this.btnSettings.Size = new System.Drawing.Size(250, 60);
			this.btnSettings.TabIndex = 5;
			this.btnSettings.Text = "Settings";
			this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSettings.UseVisualStyleBackColor = true;
			this.btnSettings.Click += new System.EventHandler(this.PageButtonClick);
			// 
			// btnDashboard
			// 
			this.btnDashboard.AccessibleName = "";
			this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnDashboard.FlatAppearance.BorderSize = 0;
			this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDashboard.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDashboard.Image = global::SchoolApplication.Properties.Resources.outline_grid_view_black_24dp;
			this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDashboard.Location = new System.Drawing.Point(0, 150);
			this.btnDashboard.Name = "btnDashboard";
			this.btnDashboard.Padding = new System.Windows.Forms.Padding(30, 0, 30, 0);
			this.btnDashboard.Size = new System.Drawing.Size(250, 60);
			this.btnDashboard.TabIndex = 1;
			this.btnDashboard.Text = "Dashboard";
			this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnDashboard.UseVisualStyleBackColor = true;
			this.btnDashboard.Click += new System.EventHandler(this.PageButtonClick);
			// 
			// panelUser
			// 
			this.panelUser.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelUser.Location = new System.Drawing.Point(0, 0);
			this.panelUser.Name = "panelUser";
			this.panelUser.Size = new System.Drawing.Size(250, 150);
			this.panelUser.TabIndex = 0;
			// 
			// panelHeader
			// 
			this.panelHeader.BackColor = System.Drawing.SystemColors.ControlDark;
			this.panelHeader.Controls.Add(this.lblPageTitle);
			this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelHeader.Location = new System.Drawing.Point(250, 0);
			this.panelHeader.Name = "panelHeader";
			this.panelHeader.Padding = new System.Windows.Forms.Padding(30, 25, 30, 35);
			this.panelHeader.Size = new System.Drawing.Size(710, 80);
			this.panelHeader.TabIndex = 1;
			// 
			// lblPageTitle
			// 
			this.lblPageTitle.AutoSize = true;
			this.lblPageTitle.Font = new System.Drawing.Font("Roboto", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPageTitle.Location = new System.Drawing.Point(33, 25);
			this.lblPageTitle.Name = "lblPageTitle";
			this.lblPageTitle.Size = new System.Drawing.Size(151, 34);
			this.lblPageTitle.TabIndex = 0;
			this.lblPageTitle.Text = "Dashboard";
			// 
			// pnlPage
			// 
			this.pnlPage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlPage.Location = new System.Drawing.Point(250, 80);
			this.pnlPage.Name = "pnlPage";
			this.pnlPage.Size = new System.Drawing.Size(710, 460);
			this.pnlPage.TabIndex = 2;
			// 
			// FrmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(960, 540);
			this.Controls.Add(this.pnlPage);
			this.Controls.Add(this.panelHeader);
			this.Controls.Add(this.panelSidepanel);
			this.MinimumSize = new System.Drawing.Size(960, 540);
			this.Name = "FrmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "School Application";
			this.panelSidepanel.ResumeLayout(false);
			this.panelHeader.ResumeLayout(false);
			this.panelHeader.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelSidepanel;
		private System.Windows.Forms.Button btnShortcuts;
		private System.Windows.Forms.Button btnTemplates;
		private System.Windows.Forms.Button btnSettings;
		private System.Windows.Forms.Button btnDashboard;
		private System.Windows.Forms.Panel panelUser;
		private System.Windows.Forms.Panel panelHeader;
		private System.Windows.Forms.Label lblPageTitle;
		private System.Windows.Forms.Panel pnlMenuButtonSelection;
		private System.Windows.Forms.Panel pnlPage;
	}
}

