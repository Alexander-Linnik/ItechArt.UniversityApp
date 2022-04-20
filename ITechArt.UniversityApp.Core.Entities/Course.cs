using System;
using System.Collections.Generic;
using System.Text;

namespace ITechArt.UniversityApp.Core.Entities
{
    public class Course: IEntity
    {
        public string Name { get; set; }
        public long DepartmentId { get; set; }
        public ICollection<Lecturer> Lecturers { get; set; } 
        public ICollection<Student> Students { get; set; }
        public ICollection<Grade> Grades { get; set; }
		public DateTime CreatedAt { get; set; }
		public long Id { get; set; }
		public DateTime UpdatedAt { get; set; }
	}
}
