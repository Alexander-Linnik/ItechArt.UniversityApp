using System;
using System.Collections.Generic;
using System.Text;

namespace ITechArt.UniversityApp.Core.Entities
{
	public class Grade: IEntity
	{
		public int Value { get; set; }
		public DateTime GradingDate { get; set; }

		public Lecturer Lecturer { get; set; }
		public long LecturerId { get; set; }

		public long StudentId { get; set; }
		public Student Student { get; set; }

		public Course Course { get; set; }

		public DateTime CreatedAt { get; set; }
		public long Id { get; set; }
		public DateTime UpdatedAt { get; set; }

	}
}
