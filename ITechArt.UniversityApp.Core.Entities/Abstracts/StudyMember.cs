using System.Collections.Generic;

namespace ITechArt.UniversityApp.Core.Entities.Abstracts
{
	public abstract class StudyMember : Person
	{
		public long DepartmentId { get; set; }
		public Department Department { get; set; }

		public ICollection<Grade> Grades { get; set; }		
	}
}
