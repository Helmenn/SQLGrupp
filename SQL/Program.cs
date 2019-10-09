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


            IProvManager provManager = new ProvManager();
            provManager.AddProv(50, 1);
            provManager.AddProv(60, 2);
            provManager.AddProv(40, 3);
            provManager.AddProv(70, 4);
            provManager.AddProv(60, 5);
            provManager.AddProv(50, 6);



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
            IStudentManager studentManager = new StudentManager();
            IProvManager provManager = new ProvManager();

            Prov testProv = provManager.GetProv(2);
            Student testStudent = studentManager.GetStudentByID(1);

            provManager.RättaProv(2, 1);

            /*
            using(var schoolContext = new SchoolContext())
            {

                var allaKurserFörStudent = (from Students in schoolContext.Students
                                            join StudentCourse in schoolContext.StudentCourses on Students.StudentID equals StudentCourse.StudentID
                                            join Courses in schoolContext.Courses on StudentCourse.CourseID equals Courses.CourseID
                                            where StudentCourse.StudentID == int.Parse(Console.ReadLine())
                                            select Courses);

                foreach (var kurs in allaKurserFörStudent)
                    Console.WriteLine(kurs.CourseName);
                    
            }*/
        }
    }
}
