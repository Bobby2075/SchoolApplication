
namespace SchoolApplication {
	partial class FrmCreateProject {
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblPath = new System.Windows.Forms.Label();
			this.lblTitle = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.tbName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tvTemplate = new System.Windows.Forms.TreeView();
			this.clbStudents = new System.Windows.Forms.CheckedListBox();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnCreate = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
			this.panel5 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.clbTeachers = new System.Windows.Forms.CheckedListBox();
			this.clbSubjects = new System.Windows.Forms.CheckedListBox();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel5.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(548, 395);
			this.panel1.TabIndex = 5;
			// 
			// lblPath
			// 
			this.lblPath.AutoSize = true;
			this.lblPath.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPath.Location = new System.Drawing.Point(12, 28);
			this.lblPath.Name = "lblPath";
			this.lblPath.Size = new System.Drawing.Size(50, 13);
			this.lblPath.TabIndex = 3;
			this.lblPath.Text = "File path";
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle.Location = new System.Drawing.Point(12, 9);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(196, 19);
			this.lblTitle.TabIndex = 6;
			this.lblTitle.Text = "Matematik Projektopgave";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
			this.panel2.Controls.Add(this.lblTitle);
			this.panel2.Controls.Add(this.lblPath);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(548, 56);
			this.panel2.TabIndex = 17;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.clbSubjects);
			this.panel3.Controls.Add(this.clbTeachers);
			this.panel3.Controls.Add(this.label7);
			this.panel3.Controls.Add(this.label6);
			this.panel3.Controls.Add(this.label1);
			this.panel3.Controls.Add(this.panel5);
			this.panel3.Controls.Add(this.tbName);
			this.panel3.Controls.Add(this.label3);
			this.panel3.Controls.Add(this.clbStudents);
			this.panel3.Controls.Add(this.label2);
			this.panel3.Controls.Add(this.dtpDueDate);
			this.panel3.Controls.Add(this.panel4);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.Location = new System.Drawing.Point(0, 56);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(548, 339);
			this.panel3.TabIndex = 18;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.tvTemplate);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel4.Location = new System.Drawing.Point(387, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(161, 339);
			this.panel4.TabIndex = 0;
			// 
			// tbName
			// 
			this.tbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbName.Location = new System.Drawing.Point(172, 18);
			this.tbName.Name = "tbName";
			this.tbName.Size = new System.Drawing.Size(195, 20);
			this.tbName.TabIndex = 32;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(13, 44);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(60, 15);
			this.label3.TabIndex = 31;
			this.label3.Text = "Due Date";
			// 
			// tvTemplate
			// 
			this.tvTemplate.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tvTemplate.Location = new System.Drawing.Point(0, 0);
			this.tvTemplate.Name = "tvTemplate";
			this.tvTemplate.Size = new System.Drawing.Size(161, 339);
			this.tvTemplate.TabIndex = 28;
			// 
			// clbStudents
			// 
			this.clbStudents.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.clbStudents.FormattingEnabled = true;
			this.clbStudents.Items.AddRange(new object[] {
            "Alex",
            "Alexander",
            "Anders",
            "Andy",
            "Cecilie",
            "David",
            "Diana",
            "Karsten F. Pedersen",
            "Lucas",
            "Magnus",
            "Marcus",
            "Nike",
            "Rasmus",
            "Ricky",
            "Steven",
            "Tobias",
            "Victor",
            "William"});
			this.clbStudents.Location = new System.Drawing.Point(16, 100);
			this.clbStudents.Name = "clbStudents";
			this.clbStudents.Size = new System.Drawing.Size(116, 169);
			this.clbStudents.Sorted = true;
			this.clbStudents.TabIndex = 25;
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.Location = new System.Drawing.Point(16, 12);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(150, 40);
			this.btnCancel.TabIndex = 24;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnCreate
			// 
			this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCreate.Location = new System.Drawing.Point(217, 12);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(150, 40);
			this.btnCreate.TabIndex = 23;
			this.btnCreate.Text = "Create";
			this.btnCreate.UseVisualStyleBackColor = true;
			this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(13, 18);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(82, 15);
			this.label2.TabIndex = 21;
			this.label2.Text = "Project name";
			// 
			// dtpDueDate
			// 
			this.dtpDueDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dtpDueDate.Location = new System.Drawing.Point(172, 44);
			this.dtpDueDate.Name = "dtpDueDate";
			this.dtpDueDate.Size = new System.Drawing.Size(195, 20);
			this.dtpDueDate.TabIndex = 19;
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.SystemColors.ControlDark;
			this.panel5.Controls.Add(this.btnCreate);
			this.panel5.Controls.Add(this.btnCancel);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel5.Location = new System.Drawing.Point(0, 280);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(387, 59);
			this.panel5.TabIndex = 34;
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(258, 80);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(57, 15);
			this.label1.TabIndex = 35;
			this.label1.Text = "Subjects";
			// 
			// label6
			// 
			this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(13, 80);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(58, 15);
			this.label6.TabIndex = 37;
			this.label6.Text = "Students";
			// 
			// label7
			// 
			this.label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(135, 80);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(60, 15);
			this.label7.TabIndex = 38;
			this.label7.Text = "Teachers";
			// 
			// clbTeachers
			// 
			this.clbTeachers.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.clbTeachers.FormattingEnabled = true;
			this.clbTeachers.Items.AddRange(new object[] {
            "Anne Buch",
            "Jakob Dippel Rasmussen",
            "Per Rubæk Hansen",
            "Poul Henrik Jessen",
            "Thomas Lynggaard Prætorius"});
			this.clbTeachers.Location = new System.Drawing.Point(138, 100);
			this.clbTeachers.Name = "clbTeachers";
			this.clbTeachers.Size = new System.Drawing.Size(117, 169);
			this.clbTeachers.Sorted = true;
			this.clbTeachers.TabIndex = 39;
			// 
			// clbSubjects
			// 
			this.clbSubjects.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.clbSubjects.FormattingEnabled = true;
			this.clbSubjects.Items.AddRange(new object[] {
            "Dansk A",
            "Idéhistorie B",
            "Informatik B",
            "Matematik A",
            "Teknikfag (DDU) A",
            "Teknologi A"});
			this.clbSubjects.Location = new System.Drawing.Point(261, 100);
			this.clbSubjects.Name = "clbSubjects";
			this.clbSubjects.Size = new System.Drawing.Size(106, 169);
			this.clbSubjects.Sorted = true;
			this.clbSubjects.TabIndex = 40;
			// 
			// FrmCreateProject
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(548, 395);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "FrmCreateProject";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Project Information";
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Label lblPath;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.TextBox tbName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.CheckedListBox clbStudents;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnCreate;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DateTimePicker dtpDueDate;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.TreeView tvTemplate;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckedListBox clbSubjects;
		private System.Windows.Forms.CheckedListBox clbTeachers;
	}
}