using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolApplication {
	public partial class FrmTemplates : Form {

		public ProjectTemplate[] Templates;

		public FrmTemplates() {
			InitializeComponent();
			LoadTemplates();
		}

		private void LoadTemplates() {
			pnlTemplates.Controls.Clear();
			string[] filePaths = Directory.GetFiles(TemplateCreator.TemplateFolderPath, "*.json");
			foreach (string filePath in filePaths) {
				UserControlTemplateItem templateItem = new UserControlTemplateItem { Dock = DockStyle.Fill };

				string[] splitPath = filePath.Split('\\');
				string fileName = splitPath[splitPath.Length - 1];
				fileName = fileName.Split('.')[0];

				templateItem.SetTemplate(new ProjectTemplate(fileName, filePath));

				Panel panel = new Panel() {
					Dock = DockStyle.Top,
					Height = templateItem.Height,
					Padding = new Padding(10, 10, 10, 0)
				};

				panel.Controls.Add(templateItem);
				pnlTemplates.Controls.Add(panel);
			}
		}

	}
}
