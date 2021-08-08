
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
			this.panel = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnAddTemplate = new System.Windows.Forms.Button();
			this.btnDeleteTemplate = new System.Windows.Forms.Button();
			this.pnlTemplates = new System.Windows.Forms.Panel();
			this.panel.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel
			// 
			this.panel.AutoScroll = true;
			this.panel.Controls.Add(this.pnlTemplates);
			this.panel.Controls.Add(this.panel1);
			this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel.Location = new System.Drawing.Point(0, 0);
			this.panel.Name = "panel";
			this.panel.Size = new System.Drawing.Size(532, 374);
			this.panel.TabIndex = 2;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
			this.panel1.Controls.Add(this.btnAddTemplate);
			this.panel1.Controls.Add(this.btnDeleteTemplate);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 323);
			this.panel1.Name = "panel1";
			this.panel1.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
			this.panel1.Size = new System.Drawing.Size(532, 51);
			this.panel1.TabIndex = 0;
			// 
			// btnAddTemplate
			// 
			this.btnAddTemplate.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnAddTemplate.Location = new System.Drawing.Point(312, 10);
			this.btnAddTemplate.Name = "btnAddTemplate";
			this.btnAddTemplate.Size = new System.Drawing.Size(100, 31);
			this.btnAddTemplate.TabIndex = 1;
			this.btnAddTemplate.Text = "Add Template";
			this.btnAddTemplate.UseVisualStyleBackColor = true;
			this.btnAddTemplate.Click += new System.EventHandler(this.btnAddTemplate_Click);
			// 
			// btnDeleteTemplate
			// 
			this.btnDeleteTemplate.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnDeleteTemplate.Location = new System.Drawing.Point(412, 10);
			this.btnDeleteTemplate.Name = "btnDeleteTemplate";
			this.btnDeleteTemplate.Size = new System.Drawing.Size(100, 31);
			this.btnDeleteTemplate.TabIndex = 0;
			this.btnDeleteTemplate.Text = "Delete Template";
			this.btnDeleteTemplate.UseVisualStyleBackColor = true;
			this.btnDeleteTemplate.Click += new System.EventHandler(this.btnDeleteTemplate_Click);
			// 
			// pnlTemplates
			// 
			this.pnlTemplates.AutoScroll = true;
			this.pnlTemplates.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlTemplates.Location = new System.Drawing.Point(0, 0);
			this.pnlTemplates.Name = "pnlTemplates";
			this.pnlTemplates.Size = new System.Drawing.Size(532, 323);
			this.pnlTemplates.TabIndex = 1;
			// 
			// FrmTemplates
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(532, 374);
			this.Controls.Add(this.panel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "FrmTemplates";
			this.Text = "FrmTemplates";
			this.panel.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnAddTemplate;
		private System.Windows.Forms.Button btnDeleteTemplate;
		private System.Windows.Forms.Panel pnlTemplates;
	}
}