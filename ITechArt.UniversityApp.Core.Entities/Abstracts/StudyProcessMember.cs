using System;
using System.Collections.Generic;
using System.Text;

namespace ITechArt.UniversityApp.Core.Entities.Abstracts
{
	public abstract class StudyProcessMember
	{
		long DepartmentId { get; set; }
		public ICollection<Grade> Grades { get; set; }
	}
}
