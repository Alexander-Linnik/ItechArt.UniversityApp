using System;
using System.Collections.Generic;
using System.Text;

namespace ITechArt.UniversityApp.Core.Entities
{
    public class Course: Entity
    {
        public string Name { get; set; }
        public Department Department { get; set; }
        public Lecturer Lecturer { get; set; } 
        public List<Student> Students { get; set; }
        public List<Grade> Grades { get; set; }
    }
}
