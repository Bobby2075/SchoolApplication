
namespace SchoolApplication {
	partial class FrmSettings {
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
			this.label2 = new System.Windows.Forms.Label();
			this.tbDefaultStudent = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tbDefaultClass = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.cbStarterPage = new System.Windows.Forms.ComboBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(22, 33);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 15);
			this.label2.TabIndex = 22;
			this.label2.Text = "Name";
			// 
			// tbDefaultStudent
			// 
			this.tbDefaultStudent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbDefaultStudent.Location = new System.Drawing.Point(139, 33);
			this.tbDefaultStudent.Name = "tbDefaultStudent";
			this.tbDefaultStudent.Size = new System.Drawing.Size(339, 23);
			this.tbDefaultStudent.TabIndex = 33;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(22, 59);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(39, 15);
			this.label1.TabIndex = 34;
			this.label1.Text = "Class";
			// 
			// tbDefaultClass
			// 
			this.tbDefaultClass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbDefaultClass.Location = new System.Drawing.Point(139, 59);
			this.tbDefaultClass.Name = "tbDefaultClass";
			this.tbDefaultClass.Size = new System.Drawing.Size(339, 23);
			this.tbDefaultClass.TabIndex = 35;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
			this.panel1.Controls.Add(this.btnCancel);
			this.panel1.Controls.Add(this.btnSave);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 321);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(532, 53);
			this.panel1.TabIndex = 37;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.Control;
			this.panel2.Controls.Add(this.groupBox2);
			this.panel2.Controls.Add(this.groupBox1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(532, 321);
			this.panel2.TabIndex = 38;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.tbDefaultStudent);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.tbDefaultClass);
			this.groupBox1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold);
			this.groupBox1.Location = new System.Drawing.Point(12, 181);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(508, 103);
			this.groupBox1.TabIndex = 37;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Default Student Information";
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
			this.groupBox2.Controls.Add(this.cbStarterPage);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold);
			this.groupBox2.Location = new System.Drawing.Point(12, 61);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(508, 103);
			this.groupBox2.TabIndex = 38;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Pages";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(22, 33);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(76, 15);
			this.label4.TabIndex = 22;
			this.label4.Text = "Starter page";
			// 
			// cbStarterPage
			// 
			this.cbStarterPage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cbStarterPage.FormattingEnabled = true;
			this.cbStarterPage.Items.AddRange(new object[] {
            "Start on last page",
            "Main",
            "Templates",
            "Shortcuts",
            "Settings"});
			this.cbStarterPage.Location = new System.Drawing.Point(139, 33);
			this.cbStarterPage.Name = "cbStarterPage";
			this.cbStarterPage.Size = new System.Drawing.Size(339, 23);
			this.cbStarterPage.TabIndex = 23;
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(420, 6);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(100, 30);
			this.btnSave.TabIndex = 0;
			this.btnSave.Text = "Apply";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(314, 6);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(100, 30);
			this.btnCancel.TabIndex = 1;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// FrmSettings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(532, 374);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "FrmSettings";
			this.Text = "FrmSettings";
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbDefaultStudent;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbDefaultClass;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox cbStarterPage;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnSave;
	}
}