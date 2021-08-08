using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApplication {
	public class ProjectInfo {

		public string Name { get; private set; }
		public string Description { get; private set; }
		public string[] SearchTags { get; private set; }
		public Teacher[] Teachers { get; private set; }
		public Student[] Students { get; private set; }
		public Subject[] Subjects { get; private set; }
		public DateTime CreationDate { get; private set; }
		public DateTime DueDate { get; private set; }

		public ProjectInfo(string name, string description, string[] searchTags, Teacher[] teachers, Student[] students, Subject[] subjects, DateTime creationDate, DateTime dueDate) {
			Name = name;
			Description = description;
			SearchTags = searchTags;
			Teachers = teachers;
			Students = students;
			Subjects = subjects;
			CreationDate = creationDate;
			DueDate = dueDate;
		}

		public void CreateProjectInfoFile(string projectPath) {
			string filePath = Path.Combine(projectPath, "ProjectInfo.txt");

			using (StreamWriter sw = File.CreateText(filePath)) {
				sw.WriteLine("::::: Projekt Information :::::");
				sw.WriteLine("Projekt navn: " + Name);
				sw.WriteLine("Beskrivelse: " + Description);
				string searchTags = "";
				foreach (string tag in SearchTags) {
					searchTags += tag + ", ";
				}
				sw.WriteLine("Søgeord: " + searchTags);
				string teacherString = "";
				for (int i = 0; i < Teachers.Length; i++) {
					if (i == 0)
						teacherString += Teachers[i].Name + " (" + Teachers[i].Initials + ")";
					else if (i == Teachers.Length - 1)
						teacherString += " og " + Teachers[i].Name + " (" + Teachers[i].Initials + ")";
					else
						teacherString += ", " + Teachers[i].Name + " (" + Teachers[i].Initials + ")";
				}
				sw.WriteLine("Lægerer: " + teacherString);
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
				sw.WriteLine("Fag: " + subjectString);
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
