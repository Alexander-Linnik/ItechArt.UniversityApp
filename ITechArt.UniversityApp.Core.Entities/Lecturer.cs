using System;
using System.Collections.Generic;
using System.Text;

namespace ITechArt.UniversityApp.Core.Entities
{
    public class Lecturer: Entity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime Birthdate { get; set; }
        public Department Department { get; set; }
        public List<Grade> Grades { get; set; }
    }
}
