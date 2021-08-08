using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApplication {
	public class ProjectInfo {

		public string Name { get; private set; }
		public string[] Teachers { get; private set; }
		public string[] Students { get; private set; }
		public string[] Subjects { get; private set; }
		public DateTime CreationDate { get; private set; }
		public DateTime DueDate { get; private set; }

		public ProjectInfo(string name, string[] teachers, string[] students, string[] subjects, DateTime dueDate) {
			Name = name;
			Teachers = teachers;
			Students = students;
			Subjects = subjects;
			CreationDate = DateTime.Now;
			DueDate = dueDate;
		}

		public void CreateProjectInfoFile(string projectPath) {
			string filePath = Path.Combine(projectPath, "ProjectInfo.txt");

			using (StreamWriter sw = File.CreateText(filePath)) {
				sw.WriteLine("::::: Projekt Information :::::");
				sw.WriteLine("Projekt navn: " + Name);
				/*sw.WriteLine("Vejledere: " + Teachers);
				string studentString = "";
				for (int i = 0; i < Students.Length; i++) {
					if (i == 0)
						studentString += Students[i].Name;
					else if (i == Students.Length - 1)
						studentString += " og " + Students[i].Name;
					else
						studentString += ", " + Students[i].Name;
				}
				sw.WriteLine("Elever: " + studentString);
				string subjectString = "";
				for (int i = 0; i < Subjects.Length; i++) {
					if (i == 0)
						subjectString += Subjects[i].Name;
					else if (i == Subjects.Length - 1)
						subjectString += " og " + Subjects[i].Name;
					else
						subjectString += ", " + Students[i].Name;
				}
				sw.WriteLine("Fag: " + subjectString);*/
				sw.WriteLine("Oprettelsesdato: " + CreationDate.ToString());
				sw.WriteLine("Afleveringsdato: " + DueDate.ToString());

			}
		}

	}

	public struct Teacher {
		public string Name { get; private set; }
		public string Initials { get; private set; }

		public Teacher(string name, string initials) {
			Name = name;
			Initials = initials;
		}
	}

	public struct Student {
		public string Name { get; private set; }
		public string Class { get; private set; }

		public Student(string name, string @class) {
			Name = name;
			Class = @class;
		}

	}

	public struct Subject {
		public string Name { get; private set; }
		public string Niveau { get; private set; }

		public Subject(string name, string niveau) {
			Name = name;
			Niveau = niveau;
		}

		public override string ToString() {
			return Name + " " + Niveau;
		}
	}

}
