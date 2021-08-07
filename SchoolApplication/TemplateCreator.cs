using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using Newtonsoft.Json;

namespace SchoolApplication {
	class TemplateCreator {

		public static string ProgramFolderName = "SchoolTemplates";
		public static string TemplateFolderName = "Templates";
		public static string TestFile = "MatematikProjektopgaveTemplate.json";
		public static string AppDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		public static string DesktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
		public static string ProgramFolderPath = Path.Combine(AppDataPath, ProgramFolderName);
		public static DirectoryInfo AppDataDirectory = new DirectoryInfo(AppDataPath);
		public static DirectoryInfo DesktopDirectory = new DirectoryInfo(DesktopPath);

		public static void Setup() {
			CheckAppDataDirectory();
			CreateProjectFromTemplate(Path.Combine(ProgramFolderPath, TemplateFolderName + "\\" + TestFile));
		}

		public static void CheckAppDataDirectory() {
			CreateDirectory(ProgramFolderPath);
		}

		public static void CreateProjectFromTemplate(string path) {
			try {
				string json;
				using (StreamReader reader = new StreamReader(path)) {
					json = reader.ReadToEnd();
				}

				TemplateFile template = JsonConvert.DeserializeObject<TemplateFile>(json);
				string projectPath = Path.Combine(DesktopPath, template.Name);

				CreateTemplateFileContent(template, projectPath);
			} catch (Exception e) {
				Console.WriteLine(e.Message);
			}
		}

		private static void CreateTemplateFileContent(TemplateFile file, string filePath) {
			CreateDirectory(filePath);

			for (int i = 0; i < file.Content.Length; i++) {
				TemplateFile newFile = file.Content[i];
				string newFilePath = Path.Combine(filePath, newFile.Name);

				Console.WriteLine("1: " + newFile.ToString());
				Console.WriteLine("2: " + newFilePath);

				if (newFile.Template != "") {
					// COPY TEMPLATE FILE
				} else if (newFile.Type == "folder") {
					CreateTemplateFileContent(newFile, newFilePath);
					Console.WriteLine("3: Created folder : " + newFile.Name + " in " + file.Name);
				} else if (newFile.Type == "file") {
					File.Create(newFilePath);
					Console.WriteLine("3: Created file : " + newFile.Name + " in " + file.Name);
				}
			}
		}

		public static bool CreateDirectory(string path) {
			if (!Directory.Exists(path)) {
				Directory.CreateDirectory(path);
				return true;
			}
			
			return false;
		}

	}

}
