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
	public partial class FrmMain : Form {

		public PageIndex CurrentPage { get; private set; }
		private readonly Dictionary<PageIndex, PageData> _pages = new Dictionary<PageIndex, PageData>();

		/// <summary>
		/// Constructor
		/// </summary>
		public FrmMain() {
			InitializeComponent();

			_pages.Add(PageIndex.Dashboard, new PageData(PageIndex.Dashboard, "Dashboard", btnDashboard, new FrmDashboard()));
			_pages.Add(PageIndex.Templates, new PageData(PageIndex.Templates, "Templates", btnTemplates, new FrmTemplates()));
			_pages.Add(PageIndex.Shortcuts, new PageData(PageIndex.Shortcuts, "Shortcuts", btnShortcuts, new FrmShortcuts()));
			_pages.Add(PageIndex.Settings, new PageData(PageIndex.Settings, "Settings", btnSettings, new FrmSettings()));
			
			int starterPage = Properties.Settings.Default.LastPage;
			if (starterPage >= 0 && starterPage < (int)PageIndex.Height && Properties.Settings.Default.StarterPage == -1)
				CurrentPage = (PageIndex)starterPage;

			SetSelectedButton(_pages[CurrentPage].PageButton, null);
			SetPage();
		}

		/// <summary>
		/// Method used by page button to change pages.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void PageButtonClick(object sender, EventArgs e) {
			foreach (PageData pageData in _pages.Values) {
				if (pageData.PageButton == sender)
					SwitchPage(pageData.Index);
			}
		}

		/// <summary>
		/// Used to start switching a page.
		/// </summary>
		/// <param name="newPage"></param>
		public void SwitchPage(PageIndex newPage) {
			if (CurrentPage == newPage)
				return;

			SetSelectedButton(_pages[newPage].PageButton, _pages[CurrentPage].PageButton);

			CurrentPage = newPage;

			SetPage();

			Properties.Settings.Default.LastPage = (int)CurrentPage;
			Properties.Settings.Default.Save();
		}

		/// <summary>
		/// Sets the page and changes data to match the new page.
		/// </summary>
		private void SetPage() {
			PageData pageData = _pages[CurrentPage];
			lblPageTitle.Text = pageData.Title;
			pnlPage.Controls.Clear();
			pnlPage.Controls.Add(pageData.Form);
			pageData.Form.Show();
		}

		/// <summary>
		/// Sets the selected page button.
		/// </summary>
		/// <param name="newButton"></param>
		/// <param name="lastButton"></param>
		private void SetSelectedButton(Button newButton, Button lastButton) {
			pnlMenuButtonSelection.Height = newButton.Height;
			pnlMenuButtonSelection.Top = newButton.Top;
			pnlMenuButtonSelection.Left = newButton.Left;
			newButton.BackColor = SystemColors.ControlDark;

			if (lastButton != null)
				lastButton.BackColor = SystemColors.ControlDarkDark;
		}

	}

	public enum PageIndex {
		Dashboard,
		Templates,
		Shortcuts,
		Settings,
		Height,
	}

	public struct PageData {

		public PageIndex Index;
		public string Title;
		public Button PageButton;
		public Form Form;

		public PageData(PageIndex index, string title, Button pageButton, Form form) {
			Index = index;
			Title = title;
			PageButton = pageButton;
			Form = form;

			Form.Dock = DockStyle.Fill;
			Form.TopLevel = false;
			Form.TopMost = true;
			Form.FormBorderStyle = FormBorderStyle.None;
		}

	}
}
