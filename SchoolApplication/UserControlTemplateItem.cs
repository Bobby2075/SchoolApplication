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
	public partial class UserControlTemplateItem : UserControl {

		public ProjectTemplate ProjectTemplate;

		public UserControlTemplateItem() {
			InitializeComponent();
		}

		public void SetTemplate(ProjectTemplate projectTemplate) {
			ProjectTemplate = projectTemplate;
			lblTitle.Text = ProjectTemplate.Name;
		}

		private void CreateTemplateClick(object sender, EventArgs e) {
			CreateTemplate();
		}

		private void CreateTemplate() {
			FrmCreateProject projectDialog = new FrmCreateProject();
			projectDialog.SetTemplate(ProjectTemplate);
			projectDialog.Show();
		}

	}
}
