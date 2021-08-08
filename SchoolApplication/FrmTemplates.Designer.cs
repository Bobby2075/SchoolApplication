
namespace SchoolApplication {
	partial class FrmTemplates {
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
			this.button1 = new System.Windows.Forms.Button();
			this.userControlTemplateItem1 = new SchoolApplication.UserControlTemplateItem();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(110, 361);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(510, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// userControlTemplateItem1
			// 
			this.userControlTemplateItem1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.userControlTemplateItem1.BackColor = System.Drawing.SystemColors.ControlDark;
			this.userControlTemplateItem1.Location = new System.Drawing.Point(34, 122);
			this.userControlTemplateItem1.Name = "userControlTemplateItem1";
			this.userControlTemplateItem1.Padding = new System.Windows.Forms.Padding(30, 20, 30, 20);
			this.userControlTemplateItem1.Size = new System.Drawing.Size(650, 75);
			this.userControlTemplateItem1.TabIndex = 1;
			// 
			// FrmTemplates
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(710, 460);
			this.Controls.Add(this.userControlTemplateItem1);
			this.Controls.Add(this.button1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmTemplates";
			this.Text = "FrmTemplates";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private UserControlTemplateItem userControlTemplateItem1;
	}
}