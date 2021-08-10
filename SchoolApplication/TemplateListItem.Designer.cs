
namespace SchoolApplication {
	partial class TemplateListItem {
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnCreate = new System.Windows.Forms.Button();
			this.lblTitle = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnCreate);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel1.Location = new System.Drawing.Point(339, 12);
			this.panel1.Margin = new System.Windows.Forms.Padding(2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(95, 37);
			this.panel1.TabIndex = 1;
			// 
			// btnCreate
			// 
			this.btnCreate.BackColor = System.Drawing.SystemColors.ControlLight;
			this.btnCreate.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnCreate.Location = new System.Drawing.Point(0, 0);
			this.btnCreate.Margin = new System.Windows.Forms.Padding(2);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(95, 37);
			this.btnCreate.TabIndex = 0;
			this.btnCreate.Text = "Create";
			this.btnCreate.UseVisualStyleBackColor = false;
			this.btnCreate.Click += new System.EventHandler(this.CreateTemplateClick);
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Roboto Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle.Location = new System.Drawing.Point(2, 7);
			this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(123, 17);
			this.lblTitle.TabIndex = 0;
			this.lblTitle.Text = "Template Name";
			this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.lblTitle);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(16, 12);
			this.panel2.Margin = new System.Windows.Forms.Padding(2);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(323, 37);
			this.panel2.TabIndex = 2;
			// 
			// TemplateListItem
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDark;
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Margin = new System.Windows.Forms.Padding(5);
			this.Name = "TemplateListItem";
			this.Padding = new System.Windows.Forms.Padding(16, 12, 16, 12);
			this.Size = new System.Drawing.Size(450, 61);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnCreate;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Panel panel2;
	}
}
