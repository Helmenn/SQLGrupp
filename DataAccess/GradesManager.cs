using SQL;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class GradesManager
    {
        public void AddGrade(string gradeName, Courses course, Student student)
        {
            using (var schoolContext = new SchoolContext())
            {
                var grade = new Grades();
                grade.GradesName = gradeName;
                grade.CourseID = course.CourseID;
                grade.StudentID = student.StudentID;
                schoolContext.Grades.Add(grade);
            }
        }
    }
}
