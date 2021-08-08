using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolApplication {
	public partial class FrmSettings : Form {

		public FrmSettings() {
			InitializeComponent();
			SetValues();
		}

		private void SetValues() {
			// Pages
			cbStarterPage.SelectedIndex = Properties.Settings.Default.StarterPage + 1;
			// Student
			tbDefaultStudent.Text = Properties.Settings.Default.DefaultStudent;
			tbDefaultClass.Text = Properties.Settings.Default.DefaultStudentClass;
		}

		private void SaveValues() {
			// Pages
			Properties.Settings.Default.StarterPage = cbStarterPage.SelectedIndex - 1;
			// Student
			Properties.Settings.Default.DefaultStudent = tbDefaultStudent.Text;
			Properties.Settings.Default.DefaultStudentClass = tbDefaultClass.Text;

			Properties.Settings.Default.Save();
		}

		private void btnSave_Click(object sender, EventArgs e) {
			SaveValues();
		}

		private void btnCancel_Click(object sender, EventArgs e) {
			SetValues();
		}
	}
}
