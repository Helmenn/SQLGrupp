using SQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataInterface
{
   public interface IStudentManager
    {
        public void AddStudent(string StudentName, int StudentAge);

        public Student GetStudentByID(int studentID);
        public void AddStudentToCourse(string studentName, string courseName);
        public Courses[] GetCourses(string studentName);

        public Student GetStudentByName(string name);
    }
}
