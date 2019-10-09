using DataInterface;
using SQL;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess
{
    public class CourseManager : ICourseManager
    {
        public void AddCourse(string name, int roomId, string teacherName)
        {
            // Kolla om det redan finns en lärare som heter teacherName

            var teacherManager = new TeacherManager();
            var newTeacher = teacherManager.GetTeacherByName(teacherName);

            if (newTeacher is null)
            {
                // Skapa läraren om den inte finns
                teacherManager.AddTeacher(teacherName);
                // Hämta nytt lärarobjekt
                newTeacher = teacherManager.GetTeacherByName(teacherName);
            }
            using (var schoolContext = new SchoolContext())
            {
                // Lägg till kurs och lärare
                var course = new Courses();
                course.CourseName = name;
                course.CourseRoom = roomId;
                course.TeacherID = newTeacher.TeacherID;
                schoolContext.Courses.Add(course);
                schoolContext.SaveChanges();
            }
        }
        public Courses GetCourseByName(string name)
        {
            using (var schoolContext = new SchoolContext())
            {
                var course = from _course in schoolContext.Courses
                              where string.Compare(_course.CourseName , name, StringComparison.InvariantCulture) ==0
                              select _course;
                return course.First();
            }
        }
        public void AddStudentToCourse(string studentName, string courseName)
        {
            new StudentManager().AddStudentToCourse(studentName,courseName);
        }
    }
}
