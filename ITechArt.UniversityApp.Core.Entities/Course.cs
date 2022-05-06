using System.Collections.Generic;

namespace ITechArt.UniversityApp.Core.Entities
{
	public class Course : AbstractEntity
    {
        public string Name { get; set; }

        public long DepartmentId { get; set; }
        public Department Department { get; set; }

        public long LecturerId { get; set; }
        public Lecturer Lecturer { get; set; }

        public ICollection<CourseToStudentMap> Students { get; set; }
        public ICollection<Grade> Grades { get; set; }
	}
}
