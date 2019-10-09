using SQL;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class GradesManager
    {
        public void AddGrade(string gradeName, int courseid, int studentid)
        {
            using (var schoolContext = new SchoolContext())
            {
                var grade = new Grades();
                grade.GradesName = gradeName;
                grade.CourseID = courseid;
                grade.StudentID = studentid;
                schoolContext.Grades.Add(grade);
            }
        }
    }
}
