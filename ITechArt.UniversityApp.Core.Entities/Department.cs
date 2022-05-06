using System.Collections.Generic;

namespace ITechArt.UniversityApp.Core.Entities
{
	public class Department : AbstractEntity
	{
		public string Name { get; set; }

		public ICollection<Student> Students { get; set; }
		public ICollection<Lecturer> Lecturers { get; set;}
		public ICollection<Course> Courses { get; set; }
	}
}
