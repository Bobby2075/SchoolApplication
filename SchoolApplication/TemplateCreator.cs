using Newtonsoft.Json;
using System;
using System.IO;

namespace SchoolApplication {
	public class TemplateCreator {

		public static string ProgramFolderName = "SchoolTemplates";
		public static string TemplateFolderName = "Templates";
		public static string TestFile = "Matematik Projektopgave.json";
		public static string AppDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		public static string DesktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
		public static string ProgramFolderPath = Path.Combine(AppDataPath, ProgramFolderName);
		public static string TemplateFolderPath = Path.Combine(ProgramFolderPath, TemplateFolderName);
		public static DirectoryInfo AppDataDirectory = new DirectoryInfo(AppDataPath);
		public static DirectoryInfo DesktopDirectory = new DirectoryInfo(DesktopPath);

		public static void Setup() {
			/*CheckAppDataDirectory();

			ProjectInfo projectInfo = new ProjectInfo("Matematik Projekt Test", "", new string[] { "word" }, new Teacher[] { new Teacher("Per", "PER") }, 
				new Student[] { new Student("Karsten. F. Pedersen", "3.Z"), new Student("Tobias AMOGUS", "3.Z") }, new Subject[] { new Subject("Matematik", "A") }, DateTime.Now, DateTime.Now);
			CreateProjectFromTemplate(Path.Combine(ProgramFolderPath, TemplateFolderName + "\\" + TestFile), projectInfo);*/
		}

		public static void CheckAppDataDirectory() {
			CreateDirectory(ProgramFolderPath);
		}

		public static string CreateProjectFromTemplate(string path, ProjectInfo projectInfo) {
			try {
				string json;
				using (StreamReader reader = new StreamReader(path)) {
					json = reader.ReadToEnd();
				}
				
				TemplateFile template = JsonConvert.DeserializeObject<TemplateFile>(json);
				string projectPath = Path.Combine(DesktopPath, template.Name);

				CreateTemplateFileContent(template, projectPath);
				projectInfo.CreateProjectInfoFile(projectPath);

				return projectPath;
			} catch (Exception e) {
				Console.WriteLine(e.Message);
			}

			return "";
		}

		private static void CreateTemplateFileContent(TemplateFile file, string filePath) {
			CreateDirectory(filePath);

			for (int i = 0; i < file.Content.Length; i++) {
				TemplateFile newFile = file.Content[i];
				string newFilePath = Path.Combine(filePath, newFile.Name);

				if (newFile.Template != "") {
					File.Copy(Path.Combine(newFile.Template, newFile.Name), newFilePath);
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
