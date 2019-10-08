using DataInterface;
using SQL;
using System;
using System.Collections.Generic;
using System.Text;


namespace DataAccess
{
    public class StudentManager : IStudentManager
    {
        public void AddStudent(string Name,int StudentAge)
        {
            using (var schoolContext = new SchoolContext())
            {
                var Student = new Student();
                Student.StudentName = "Mark";
                Student.StudentAge = 19;
                schoolContext.Students.Add(Student);

                Student = new Student();
                Student.StudentName = "Anna";
                Student.StudentAge = 20;
                schoolContext.Students.Add(Student);

                Student = new Student();
                Student.StudentName = "Hanna";
                Student.StudentAge = 27;
                schoolContext.Students.Add(Student);

                Student = new Student();
                Student.StudentName = "Manne";
                Student.StudentAge = 23;
                schoolContext.Students.Add(Student);

                Student = new Student();
                Student.StudentName = "Sara";
                Student.StudentAge = 20;
                schoolContext.Students.Add(Student);
            }
        }
    }

}
