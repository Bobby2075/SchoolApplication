using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApplication {
	interface ITemplateItem {

		ProjectTemplate Template { get; }

		void SetTemplate(ProjectTemplate template);

	}
}
