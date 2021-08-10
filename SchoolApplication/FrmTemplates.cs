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

			foreach (string filePath in TemplateCreator.FilePaths) {
				
				string[] splitPath = filePath.Split('\\');
				string fileName = splitPath[splitPath.Length - 1];
				fileName = fileName.Split('.')[0];

				TemplateListItem templateItem = new TemplateListItem { Dock = DockStyle.Fill };
				templateItem.SetTemplate(new ProjectTemplate(fileName, filePath));

				Panel panel = new Panel() {
					Dock = DockStyle.Top,
					Height = templateItem.Height,
					Padding = new Padding(16, 10, 16, 0)
				};

				panel.Controls.Add(templateItem);
				pnlTemplates.Controls.Add(panel);
			}
		}

		private void btnAddTemplate_Click(object sender, EventArgs e) {
			using (OpenFileDialog fileDialog = new OpenFileDialog()) {
				if (fileDialog.ShowDialog() == DialogResult.OK) {
					string[] splitPath = fileDialog.FileName.Split('\\');
					File.Copy(fileDialog.FileName, Path.Combine(TemplateCreator.TemplateFolderPath, splitPath[splitPath.Length - 1]));

					// DO SO NEW TEMPLATE IS ADDED TO PATH ARRAY
					LoadTemplates();
				}
			}
		}

		private void btnDeleteTemplate_Click(object sender, EventArgs e) {

		}
	}
}
