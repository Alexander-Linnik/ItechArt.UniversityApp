using System;
using System.Collections.Generic;
using System.Text;

namespace ITechArt.UniversityApp.Core.Entities.Abstracts
{
	interface IUpdatable
	{
		DateTime UpdatedAt { get; set; }
	}
}
