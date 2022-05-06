using ITechArt.UniversityApp.Core.Entities.Abstracts;
using System;

namespace ITechArt.UniversityApp.Core.Entities
{
	public abstract class AbstractEntity
		: IUpdatable
	{
		public long Id { get; set; }
		public DateTime CreatedAt { get; set; }
		public DateTime UpdatedAt { get; set; }
	}
}
