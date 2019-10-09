﻿using DataInterface;
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
                Student.StudentName = Name;
                Student.StudentAge = StudentAge;
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
        public Student GetStudentByName(string name)
        {
            using (var schoolContext = new SchoolContext())
            {
                var Student = from _Student in schoolContext.Students
                              where _Student.StudentName == name
                              select _Student;
                return Student.First();
            }

        }


        public void AddCourseToStudent(string studentName, string courseName)
        {
            using (var schoolContext = new SchoolContext())
            {
                IStudentManager studentManager = new StudentManager();
                ICourseManager courseManager = new CourseManager();
                var student = studentManager.GetStudentByName(studentName);
                var course = courseManager.GetCourseByName(courseName);
                if (student != null && course != null) {
                    StudentCourse studentCourse = new StudentCourse();
                    studentCourse.StudentID = student.StudentID;
                    studentCourse.CourseID = course.CourseID;
                    schoolContext.StudentCourses.Add(studentCourse);
                    schoolContext.SaveChanges();
                }
            }
            

        }
    }
}
