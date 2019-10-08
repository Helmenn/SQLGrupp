using DataInterface;
using SQL;
using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;


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
    
        public Student GetStudentByID(int studentID)
        {
            using (var schoolContext = new SchoolContext())
            {
                var student = from _student in schoolContext.Students
                              where _student.StudentID == studentID
                              select _student;
                return student.First();
            }
        }
        
    }

}
