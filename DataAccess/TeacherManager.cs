using DataInterface;
using SQL;
using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;

namespace DataAccess
{
    public class TeacherManager : ITeacherManager
    {
        public void AddTeacher(string teacherName)
        {
            using (var schoolContext = new SchoolContext())
            {
                var teacher = new Teacher();
                teacher.TeacherName = teacherName;
                schoolContext.Teachers.Add(teacher);
                schoolContext.SaveChanges();
            }

        }
        public Teacher GetTeacherByID(int TeacherID)
        {
            using (var schoolContext = new SchoolContext())
            {
                var Teacher = from _Teacher in schoolContext.Teachers
                              where _Teacher.TeacherID == TeacherID
                              select _Teacher;
                return Teacher.First();
            }
        }

        public Teacher GetTeacherByName(string name)
        {
            using (var schoolContext = new SchoolContext())
            {
                var Teacher = from _Teacher in schoolContext.Teachers
                              where _Teacher.TeacherName == name
                              select _Teacher;
                return Teacher.First();
            }

        }
    }

}
