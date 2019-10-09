using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;
using DataInterface;
using DataAccess;

namespace SQL
{
    class Program
    {
        static void Inmatning()
        {
            var studentManager = new StudentManager();
            studentManager.AddStudent("Tobias", 50);

            using (var schoolContext = new SchoolContext())
            {

                #region Studentnamn
                var student = new Student();
                student.StudentName = "Leif";
                student.StudentAge = 19;
                schoolContext.Students.Add(student);

                student = new Student();
                student.StudentName = "Christer";
                student.StudentAge = 22;
                schoolContext.Students.Add(student);

                student = new Student();
                student.StudentName = "Hasse";
                student.StudentAge = 20;
                schoolContext.Students.Add(student);

                student = new Student();
                student.StudentName = "Johan";
                student.StudentAge = 28;
                schoolContext.Students.Add(student);

                student = new Student();
                student.StudentName = "Janne";
                student.StudentAge = 20;
                schoolContext.Students.Add(student);

                student = new Student();
                student.StudentName = "Håkan";
                student.StudentAge = 19;
                schoolContext.Students.Add(student);

                student = new Student();
                student.StudentName = "Johnny";
                student.StudentAge = 20;
                schoolContext.Students.Add(student);

                student = new Student();
                student.StudentName = "Olof";
                student.StudentAge = 28;
                schoolContext.Students.Add(student);

                student = new Student();
                student.StudentName = "Anna";
                student.StudentAge = 31;
                schoolContext.Students.Add(student);

                student = new Student();
                student.StudentName = "Gunnar";
                student.StudentAge = 40;
                schoolContext.Students.Add(student);

                student = new Student();
                student.StudentName = "Eva";
                student.StudentAge = 24;
                schoolContext.Students.Add(student);

                student = new Student();
                student.StudentName = "Anders";
                student.StudentAge = 19;
                schoolContext.Students.Add(student);

                #endregion

            }

            ITeacherManager teacherManager = new TeacherManager();
            teacherManager.AddTeacher("Sten");
            teacherManager.AddTeacher("Anna");
            teacherManager.AddTeacher("Siv");
            teacherManager.AddTeacher("Albert");


            IStudentManager StudentManger = new StudentManager();
            StudentManger.AddStudent("Adam", 19);
            StudentManger.AddStudent("Amanda", 23);
            StudentManger.AddStudent("Andreas", 37);
            StudentManger.AddStudent("Anna", 27);
            StudentManger.AddStudent("Alan", 30);
            StudentManger.AddStudent("Anika", 23);
            StudentManger.AddStudent("Håkan", 19);
            StudentManger.AddStudent("Simon", 23);
            StudentManger.AddStudent("Samuel", 32);
            StudentManger.AddStudent("Sten", 20);
            StudentManger.AddStudent("Rasmus", 21);

            ICourseManager courseManager = new CourseManager();
            courseManager.AddCourse("Matte", 102, 1);
            courseManager.AddCourse("Fysik", 102, 1);
            courseManager.AddCourse("Svenska", 103, 2);
            courseManager.AddCourse("Engelska", 103, 2);
            courseManager.AddCourse("Historia", 104, 3);
            courseManager.AddCourse("Spanska", 105, 4);

            IFrågaManager frågaManager = new FrågaManager();
            frågaManager.AddFråga("Fråga A", 1);
            frågaManager.AddFråga("Fråga B", 1);
            frågaManager.AddFråga("Fråga C", 1);
            frågaManager.AddFråga("Fråga A", 2);
            frågaManager.AddFråga("Fråga B", 2);
            frågaManager.AddFråga("Fråga C", 2);
            frågaManager.AddFråga("Fråga A", 3);
            frågaManager.AddFråga("Fråga B", 3);
            frågaManager.AddFråga("Fråga C", 3);
            frågaManager.AddFråga("Fråga A", 4);
            frågaManager.AddFråga("Fråga B", 4);
            frågaManager.AddFråga("Fråga C", 4);
            frågaManager.AddFråga("Fråga A", 5);
            frågaManager.AddFråga("Fråga B", 5);
            frågaManager.AddFråga("Fråga C", 5);
            frågaManager.AddFråga("Fråga A", 6);
            frågaManager.AddFråga("Fråga B", 6);
            frågaManager.AddFråga("Fråga C", 6);

            ISvarAltManger svarAltManger = new SvarAltManager();
            svarAltManger.AddSvarAlt("Svar 1", false, 1);
            svarAltManger.AddSvarAlt("Svar 2", false, 1);
            svarAltManger.AddSvarAlt("Svar 3", true, 1);
            svarAltManger.AddSvarAlt("Svar 1", false, 2);
            svarAltManger.AddSvarAlt("Svar 2", false, 2);
            svarAltManger.AddSvarAlt("Svar 3", true, 2);
            svarAltManger.AddSvarAlt("Svar 1", true, 3);
            svarAltManger.AddSvarAlt("Svar 2", false, 3);
            svarAltManger.AddSvarAlt("Svar 3", false, 3);
            svarAltManger.AddSvarAlt("Svar 1", false, 4);
            svarAltManger.AddSvarAlt("Svar 2", true, 4);
            svarAltManger.AddSvarAlt("Svar 3", false, 4);
            svarAltManger.AddSvarAlt("Svar 1", false, 5);
            svarAltManger.AddSvarAlt("Svar 2", true, 5);
            svarAltManger.AddSvarAlt("Svar 3", false, 5);
            svarAltManger.AddSvarAlt("Svar 1", false, 6);
            svarAltManger.AddSvarAlt("Svar 2", false, 6);
            svarAltManger.AddSvarAlt("Svar 3", true, 6);

        }
        static void Main(string[] args)
        {
      
        }
    }
}
