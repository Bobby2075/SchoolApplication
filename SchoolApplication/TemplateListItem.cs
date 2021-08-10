using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SchoolApplication {
	public partial class TemplateListItem : UserControl, ITemplateItem {

		public ProjectTemplate Template { get; private set; }

		public TemplateListItem() {
			InitializeComponent();
		}

		public void SetTemplate(ProjectTemplate template) {
			Template = template;
			lblTitle.Text = Template.Name;
		}

		private void CreateTemplateClick(object sender, EventArgs e) {
			CreateTemplate();
		}

		private void CreateTemplate() {
			FrmCreateProjectDialog projectDialog = new FrmCreateProjectDialog();
			projectDialog.SetTemplate(Template);
			projectDialog.ShowDialog();
		}

	}
}
