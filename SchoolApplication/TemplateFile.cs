using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApplication {
	class TemplateFile {

		public string Name;
		public string Type;
		public TemplateFile[] Content;
		public string Template;

		public TemplateFile(string name, string type, TemplateFile[] content, string template) {
			Name = name;
			Type = type;
			Content = content;
			Template = template;
		}

		public override string ToString() {
			return "Name: " + Name + " Type: " + Type + " Content: " + Content + " Template: " + Template;
		}

	}

}
