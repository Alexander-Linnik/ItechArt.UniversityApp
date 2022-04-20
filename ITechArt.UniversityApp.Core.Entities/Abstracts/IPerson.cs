﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ITechArt.UniversityApp.Core.Entities.Abstracts
{
	public interface IPerson
	{
		public string Name { get; set; }	
		public DateTime BirthDay { get; set; }
		public string Email { get; set; }
	}
}
