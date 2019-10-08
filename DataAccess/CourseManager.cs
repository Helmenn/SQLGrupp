using DataInterface;
using SQL;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class CourseManager : ICourseManager
    {
        public void AddCourse(string name, int roomid, Teacher teacher)
        {
            using (var schoolContext = new SchoolContext())
            {
                var courses = new Courses();
                courses.CourseName = name;
                courses.CourseRoom = roomid;
                courses.TeacherID = teacher.TeacherID;
                schoolContext.Courses.Add(courses);
            }
        }
    }
}
