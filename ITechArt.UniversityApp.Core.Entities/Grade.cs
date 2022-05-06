namespace ITechArt.UniversityApp.Core.Entities
{
	public class Grade : AbstractEntity
	{
		public string Value { get; set; }

		public long LecturerId { get; set; }
		public Lecturer Lecturer { get; set; }		

		public long StudentId { get; set; }
		public Student Student { get; set; }

		public long CourseId { get; set; }
		public Course Course { get; set; }
	}
}
