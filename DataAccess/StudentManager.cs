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
                Student.StudentName = Name;
                Student.StudentAge = StudentAge;
                schoolContext.Students.Add(Student);
            }
        }
    }

}
