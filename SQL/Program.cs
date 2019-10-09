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
        
            // Sedan blir det meckigt att få till kopplingen mellan student och kurs, tycker vi.
            // Vi saknar den direkta kopplingen till student och kurs, så att vi enkelt kan lägga
            // En elev på en kurs, tycker vi.
            // Vi kan ju skapa en metod som hämtar studentID och kursID med hjälp av namnen på kurs
            // respektive student, men det känns ju inte helt "rätt" väg att gå.
        }
        static void Main(string[] args)
        {
      
        }
    }
}
