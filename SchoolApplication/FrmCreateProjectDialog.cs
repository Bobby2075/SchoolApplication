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
	public partial class FrmCreateProjectDialog : Form {

		private ProjectTemplate _projectTemplate;

		public FrmCreateProjectDialog() {
			InitializeComponent();
		}

		public void SetTemplate(ProjectTemplate projectTemplate) {
			_projectTemplate = projectTemplate;

			lblTitle.Text = _projectTemplate.Name;
			lblPath.Text = _projectTemplate.TemplatePath;
		}

		private void btnCancel_Click(object sender, EventArgs e) {
			this.Close();
		}

		private void btnCreate_Click(object sender, EventArgs e) {
			ProjectInfo projectInfo = new ProjectInfo(tbName.Text, new string[] { }, new string[] { }, new string[] { }, dtpDueDate.Value);
			TemplateCreator.CreateProject(_projectTemplate.TemplatePath, projectInfo);
			this.Close();
		}

	}
}
