using System;
using System.Collections.Generic;
using System.Text;

namespace ITechArt.UniversityApp.Core.Entities
{
	public class Department: IEntity
	{
		public string Name { get; set; }
		public DateTime CreatedAt { get; set; }
		public long Id { get; set; }
		public DateTime UpdatedAt { get; set; }
	}
}
