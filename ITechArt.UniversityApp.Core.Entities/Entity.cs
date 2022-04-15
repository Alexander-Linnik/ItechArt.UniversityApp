using System;
using System.Collections.Generic;
using System.Text;

namespace ITechArt.UniversityApp.Core.Entities
{
	public abstract class Entity
	{
		public long Id { get; set; }
		public DateTime CreationTime { get; set; }
	}
}
