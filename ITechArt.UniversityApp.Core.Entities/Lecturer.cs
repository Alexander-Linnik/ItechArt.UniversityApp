using ITechArt.UniversityApp.Core.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITechArt.UniversityApp.Core.Entities
{
    public class Lecturer: StudyProcessMember, IPerson, IEntity
    {
        public string Name { get; set; }
        public DateTime BirthDay { get; set; }
        public string Email { get; set; }

        public DateTime CreatedAt { get; set; }
        public long Id { get; set; }
        public DateTime UpdatedAt { get; set; }
	}
}
