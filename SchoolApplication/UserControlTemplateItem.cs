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

		public new string Name;
		public string Path;

		public UserControlTemplateItem() {
			InitializeComponent();
		}

		public void SetTemplate(string name, string path) {
			Name = name;
			Path = path;
		}

		private void SelectTemplateClick(object sender, EventArgs e) {
			Console.WriteLine("Amongus");
		}

	}
}
