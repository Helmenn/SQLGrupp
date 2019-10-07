using SQL;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class CourseManager
    {
        public void AddCourse(string name, int roomid, int teacherid)
        {
            using (var schoolContext = new SchoolContext())
            {
                var courses = new Courses();
                courses.CourseName = name;
                courses.CourseRoom = roomid;
                courses.TeacherID = teacherid;
                schoolContext.Courses.Add(courses);
            }
        }
    }
}
