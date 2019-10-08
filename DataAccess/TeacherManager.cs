using DataInterface;
using Microsoft.EntityFrameworkCore;
using SQL;
using System;

namespace DataAccess
{
    public class TeacherManager : ITeacherManager
    {
        public void AddTeacher(string teacherName)
        {
            using (var schoolContext = new SchoolContext())
            {
                var teacher = new Teacher();
                teacher.TeacherName = "Sten";
                schoolContext.Teachers.Add(teacher);

                teacher = new Teacher();
                teacher.TeacherName = "Anna";
                schoolContext.Teachers.Add(teacher);

                teacher = new Teacher();
                teacher.TeacherName = "siv";
                schoolContext.Teachers.Add(teacher);
            }
        }
    }
}
