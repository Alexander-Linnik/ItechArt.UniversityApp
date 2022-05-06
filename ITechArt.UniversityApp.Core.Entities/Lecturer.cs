using ITechArt.UniversityApp.Core.Entities.Abstracts;
using System.Collections.Generic;

namespace ITechArt.UniversityApp.Core.Entities
{
	public class Lecturer : StudyMember
    {
		public ICollection<Course> Courses { get; set; }
	}
}
