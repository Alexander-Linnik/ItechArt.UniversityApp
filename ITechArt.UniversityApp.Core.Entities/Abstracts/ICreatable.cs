using System;

namespace ITechArt.UniversityApp.Core.Entities.Abstracts
{
	public interface ICreatable: IIdentifiable
	{
		DateTime CreatedAt { get; set; }
	}
}
