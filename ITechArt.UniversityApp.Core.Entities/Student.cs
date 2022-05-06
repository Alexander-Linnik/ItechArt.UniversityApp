using ITechArt.UniversityApp.Core.Entities.Abstracts;
using System.Collections.Generic;

namespace ITechArt.UniversityApp.Core.Entities
{
	public class Student : StudyMember
    {
        public ICollection<CourseToStudentMap> Courses { get; set; }
    }
}
