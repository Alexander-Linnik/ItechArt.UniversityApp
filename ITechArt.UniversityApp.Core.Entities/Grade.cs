using System;
using System.Collections.Generic;
using System.Text;

namespace ITechArt.UniversityApp.Core.Entities
{
	public class Grade
	{
		public int ID { get; set; }
		public int Value { get; set; }
		public DateTime GradingDate { get; set; }
		public Lecturer Lecturer { get; set; }
		public Student Student { get; set; }
		public Course Course { get; set; }

	}
}
