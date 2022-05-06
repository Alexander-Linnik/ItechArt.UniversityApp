using System;

namespace ITechArt.UniversityApp.Core.Entities.Abstracts
{
	public interface IUpdatable : ICreatable
	{
		DateTime UpdatedAt { get; set; }
	}
}
