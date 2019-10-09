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
            StudentManger.AddStudentToCourse("Adam","Matte");
            StudentManger.AddStudent("Amanda", 23);
            StudentManger.AddStudentToCourse("Amanda", "Matte");
            StudentManger.AddStudent("Andreas", 37);
            StudentManger.AddStudentToCourse("Andreas", "Matte");
            StudentManger.AddStudent("Anna", 27);
            StudentManger.AddStudentToCourse("Anna", "Fysik");
            StudentManger.AddStudent("Alan", 30);
            StudentManger.AddStudentToCourse("Alan", "Svenska");
            StudentManger.AddStudent("Anika", 23);
            StudentManger.AddStudentToCourse("Anika", "Engelska");
            StudentManger.AddStudent("Håkan", 19);
            StudentManger.AddStudentToCourse("Håkan", "Historia");
            StudentManger.AddStudent("Simon", 23);
            StudentManger.AddStudentToCourse("Simon", "Spanska");
            StudentManger.AddStudent("Samuel", 32);
            StudentManger.AddStudentToCourse("Samuel", "Spanska");
            StudentManger.AddStudent("Sten", 20);
            StudentManger.AddStudentToCourse("Sten", "Matte");
            StudentManger.AddStudent("Rasmus", 21);
            StudentManger.AddStudentToCourse("Rasmus", "Engelska");

            ICourseManager courseManager = new CourseManager();
            courseManager.AddCourse("Matte", 102, "Sten");
            courseManager.AddCourse("Fysik", 102, "Sten");
            courseManager.AddCourse("Svenska", 103, "Anna");
            courseManager.AddCourse("Engelska", 103, "Anna");
            courseManager.AddCourse("Historia", 104, "Siv");
            courseManager.AddCourse("Spanska", 105, "Albert");


            IProvManager provManager = new ProvManager();
            provManager.AddProv(50, "Matte");
            provManager.AddProv(60, "Fysik");
            provManager.AddProv(40, "Svenska");
            provManager.AddProv(70, "Engelska");
            provManager.AddProv(60, "Historia");
            provManager.AddProv(50, "Spanska");



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
