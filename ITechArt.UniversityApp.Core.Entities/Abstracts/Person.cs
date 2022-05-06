using System;

namespace ITechArt.UniversityApp.Core.Entities.Abstracts
{
	public abstract class Person : AbstractEntity
	{
		public string Name { get; set; }
		public DateTime BirthDay { get; set; }
		public string Email { get; set; }
	}
}
