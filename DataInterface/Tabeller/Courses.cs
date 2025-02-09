﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SQL
{
    public class Courses
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CourseID { get; set; }
        public string CourseName { get; set; }
        public int CourseRoom { get; set; }
        public int TeacherID { get; set; }
        public Teacher Teacher { get; set; }
        public ICollection<StudentCourse> StudentCourses { get; set; } 
    }
}
