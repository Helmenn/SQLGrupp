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
            IFrågaManager frågaManager = new FrågaManager();
            ISvarAltManger svarAltManger = new SvarAltManager();
            var prov1 = provManager.AddProv(50, "Matte");
            var fråga1 = frågaManager.AddFråga("Fråga A", prov1.ProvID);
            svarAltManger.AddSvarAlt("Svar 1", false, fråga1.FrågaID);
            svarAltManger.AddSvarAlt("Svar 2", false, fråga1.FrågaID);
            svarAltManger.AddSvarAlt("Svar 3", true, fråga1.FrågaID);

            var fråga2 = frågaManager.AddFråga("Fråga B", prov1.ProvID);
            svarAltManger.AddSvarAlt("Svar 1", false, fråga2.FrågaID);
            svarAltManger.AddSvarAlt("Svar 2", false, fråga2.FrågaID);
            svarAltManger.AddSvarAlt("Svar 3", true, fråga2.FrågaID);
            
            var fråga3 = frågaManager.AddFråga("Fråga C", prov1.ProvID);
            svarAltManger.AddSvarAlt("Svar 1", true, fråga3.FrågaID);
            svarAltManger.AddSvarAlt("Svar 2", false, fråga3.FrågaID);
            svarAltManger.AddSvarAlt("Svar 3", false, fråga3.FrågaID);
            

            var prov2 = provManager.AddProv(60, "Fysik");
            fråga1 = frågaManager.AddFråga("Fråga A", prov2.ProvID);
            svarAltManger.AddSvarAlt("Svar 1", false, fråga1.FrågaID);
            svarAltManger.AddSvarAlt("Svar 2", false, fråga1.FrågaID);
            svarAltManger.AddSvarAlt("Svar 3", true, fråga1.FrågaID);


            fråga2 = frågaManager.AddFråga("Fråga B", prov2.ProvID);
            svarAltManger.AddSvarAlt("Svar 1", false, fråga2.FrågaID);
            svarAltManger.AddSvarAlt("Svar 2", false, fråga2.FrågaID);
            svarAltManger.AddSvarAlt("Svar 3", true, fråga2.FrågaID);

            fråga3 = frågaManager.AddFråga("Fråga C", prov2.ProvID);
            svarAltManger.AddSvarAlt("Svar 1", true, fråga3.FrågaID);
            svarAltManger.AddSvarAlt("Svar 2", false, fråga3.FrågaID);
            svarAltManger.AddSvarAlt("Svar 3", false, fråga3.FrågaID);

            var prov3 = provManager.AddProv(40, "Svenska");
            fråga1 = frågaManager.AddFråga("Fråga A", prov3.ProvID);
            svarAltManger.AddSvarAlt("Svar 1", false, fråga1.FrågaID);
            svarAltManger.AddSvarAlt("Svar 2", false, fråga1.FrågaID);
            svarAltManger.AddSvarAlt("Svar 3", true, fråga1.FrågaID);


            fråga2 = frågaManager.AddFråga("Fråga B", prov3.ProvID);
            svarAltManger.AddSvarAlt("Svar 1", false, fråga2.FrågaID);
            svarAltManger.AddSvarAlt("Svar 2", false, fråga2.FrågaID);
            svarAltManger.AddSvarAlt("Svar 3", true, fråga2.FrågaID);

            fråga3 = frågaManager.AddFråga("Fråga C", prov3.ProvID);
            svarAltManger.AddSvarAlt("Svar 1", true, fråga3.FrågaID);
            svarAltManger.AddSvarAlt("Svar 2", false, fråga3.FrågaID);
            svarAltManger.AddSvarAlt("Svar 3", false, fråga3.FrågaID);

            var prov4 = provManager.AddProv(70, "Engelska");
            fråga1 = frågaManager.AddFråga("Fråga A", prov4.ProvID);
            svarAltManger.AddSvarAlt("Svar 1", false, fråga1.FrågaID);
            svarAltManger.AddSvarAlt("Svar 2", false, fråga1.FrågaID);
            svarAltManger.AddSvarAlt("Svar 3", true, fråga1.FrågaID);


            fråga2 = frågaManager.AddFråga("Fråga B", prov4.ProvID);
            svarAltManger.AddSvarAlt("Svar 1", false, fråga2.FrågaID);
            svarAltManger.AddSvarAlt("Svar 2", false, fråga2.FrågaID);
            svarAltManger.AddSvarAlt("Svar 3", true, fråga2.FrågaID);

            fråga3 = frågaManager.AddFråga("Fråga C", prov4.ProvID);
            svarAltManger.AddSvarAlt("Svar 1", true, fråga3.FrågaID);
            svarAltManger.AddSvarAlt("Svar 2", false, fråga3.FrågaID);
            svarAltManger.AddSvarAlt("Svar 3", false, fråga3.FrågaID);

            var prov5 = provManager.AddProv(60, "Historia");
            fråga1 = frågaManager.AddFråga("Fråga A", prov5.ProvID);
            svarAltManger.AddSvarAlt("Svar 1", false, fråga1.FrågaID);
            svarAltManger.AddSvarAlt("Svar 2", false, fråga1.FrågaID);
            svarAltManger.AddSvarAlt("Svar 3", true, fråga1.FrågaID);


            fråga2 = frågaManager.AddFråga("Fråga B", prov5.ProvID);
            svarAltManger.AddSvarAlt("Svar 1", false, fråga2.FrågaID);
            svarAltManger.AddSvarAlt("Svar 2", false, fråga2.FrågaID);
            svarAltManger.AddSvarAlt("Svar 3", true, fråga2.FrågaID);

            fråga3 = frågaManager.AddFråga("Fråga C", prov5.ProvID);
            svarAltManger.AddSvarAlt("Svar 1", true, fråga3.FrågaID);
            svarAltManger.AddSvarAlt("Svar 2", false, fråga3.FrågaID);
            svarAltManger.AddSvarAlt("Svar 3", false, fråga3.FrågaID);

            var prov6 = provManager.AddProv(50, "Spanska");
            fråga1 = frågaManager.AddFråga("Fråga A", prov6.ProvID);
            svarAltManger.AddSvarAlt("Svar 1", false, fråga1.FrågaID);
            svarAltManger.AddSvarAlt("Svar 2", false, fråga1.FrågaID);
            svarAltManger.AddSvarAlt("Svar 3", true, fråga1.FrågaID);


            fråga2 = frågaManager.AddFråga("Fråga B", prov6.ProvID);
            svarAltManger.AddSvarAlt("Svar 1", false, fråga2.FrågaID);
            svarAltManger.AddSvarAlt("Svar 2", false, fråga2.FrågaID);
            svarAltManger.AddSvarAlt("Svar 3", true, fråga2.FrågaID);

            fråga3 = frågaManager.AddFråga("Fråga C", prov6.ProvID);
            svarAltManger.AddSvarAlt("Svar 1", true, fråga3.FrågaID);
            svarAltManger.AddSvarAlt("Svar 2", false, fråga3.FrågaID);
            svarAltManger.AddSvarAlt("Svar 3", false, fråga3.FrågaID);



            


            
        }
        static void Main(string[] args)
        {
      
        }
    }
}
