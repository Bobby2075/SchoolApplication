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
		}

		private void LoadTemplates() {
			//DirectoryInfo directory = Directory.;
			string[] templateFileNames = Directory.GetFiles(TemplateCreator.TemplateFolderPath, "*.json");
			foreach (string fileName in templateFileNames) {
				
			}
		}

	}
}
