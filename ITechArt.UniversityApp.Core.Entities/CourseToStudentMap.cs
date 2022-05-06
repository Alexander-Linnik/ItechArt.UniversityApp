using ITechArt.UniversityApp.Core.Entities.Abstracts;

namespace ITechArt.UniversityApp.Core.Entities
{
	public class CourseToStudentMap : IEntityMarker
	{
		public long CourseId { get; set; }
		public Course Course { get; set; }

		public long StudentId { get; set; }
		public Student Student { get; set; }
	}
}
