using Newtonsoft.Json;
using System;
using System.IO;

namespace SchoolApplication {
	public class TemplateCreator {

		public static readonly string ProgramFolderName = "SchoolTemplates";
		public static readonly string TemplateFolderName = "Templates";
		public static readonly string TestFile = "Matematik Projektopgave.json";
		public static readonly string AppDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		public static readonly string DesktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
		public static readonly string ProgramFolderPath = Path.Combine(AppDataPath, ProgramFolderName);
		public static readonly string TemplateFolderPath = Path.Combine(ProgramFolderPath, TemplateFolderName);
		public static readonly DirectoryInfo AppDataDirectory = new DirectoryInfo(AppDataPath);
		public static readonly DirectoryInfo DesktopDirectory = new DirectoryInfo(DesktopPath);
		public static readonly string[] FilePaths = Directory.GetFiles(TemplateFolderPath, "*.json");

		public static void CreateProject(string destPath, ProjectInfo projectInfo) {
			try {
				string json;
				using (StreamReader reader = new StreamReader(destPath)) {
					json = reader.ReadToEnd();
				}
				
				TemplateFile template = JsonConvert.DeserializeObject<TemplateFile>(json);
				string projectPath = Path.Combine(DesktopPath, template.Name);

				CreateTemplateContent(template, projectPath);
				projectInfo.CreateProjectInfoFile(projectPath);
			} catch (Exception e) {
				Console.WriteLine(e.Message);
			}
		}

		private static void CreateTemplateContent(TemplateFile file, string filePath) {
			CreateDirectory(filePath);

			foreach (TemplateFile newFile in file.Content) {
				string newFilePath = Path.Combine(filePath, newFile.Name);

				if (newFile.Template != "") {
					File.Copy(Path.Combine(newFile.Template, newFile.Name), newFilePath);
				} else if (newFile.Type == "folder") {
					CreateTemplateContent(newFile, newFilePath);
				} else if (newFile.Type == "file") {
					File.Create(newFilePath);
				}
			}
		}

		public static void CheckAppDataDirectory() {
			CreateDirectory(ProgramFolderPath);
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
