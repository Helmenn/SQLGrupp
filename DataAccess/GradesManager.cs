using SQL;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class GradesManager
    {
        public void AddGrade(string gradeName, int courseID, int studentID)
        {
            using (var schoolContext = new SchoolContext())
            {
                var grade = new Grades();
                grade.GradesName = gradeName;
                grade.CourseID = courseID;
                grade.StudentID = studentID;
                schoolContext.Grades.Add(grade);
            }
        }
    }
}
