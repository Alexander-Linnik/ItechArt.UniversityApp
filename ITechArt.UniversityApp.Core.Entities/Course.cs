using System;
using System.Collections.Generic;
using System.Text;

namespace ITechArt.UniversityApp.Core.Entities
{
    public class Course
    {
        public string Name { get; set; }
        public string Faculty { get; set; }
        public Lecturer Lecturer { get; set; } 
        public List<Student> Students { get; set; }
        public List<Grade> Grades { get; set; }
    }
}
