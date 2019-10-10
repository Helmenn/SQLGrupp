using DataInterface;
using SQL;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess
{
    public class CourseManager : ICourseManager
    {
        public void AddCourse(string name, int roomId, string teacherName)
        {
            // Kolla om det redan finns en lärare som heter teacherName

            var teacherManager = new TeacherManager();
            var newTeacher = teacherManager.GetTeacherByName(teacherName);

            if (newTeacher is null)
            {
                // Skapa läraren om den inte finns
                teacherManager.AddTeacher(teacherName);
                // Hämta nytt lärarobjekt
                newTeacher = teacherManager.GetTeacherByName(teacherName);
            }
            using (var schoolContext = new SchoolContext())
            {
                // Lägg till kurs och lärare
                var course = new Courses();
                course.CourseName = name;
                course.CourseRoom = roomId;
                course.TeacherID = newTeacher.TeacherID;
                schoolContext.Courses.Add(course);
                schoolContext.SaveChanges();
            }
        }
        public Courses GetCourseByName(string name)
        {   // Denna metod letar reda på en kurs som heter "name"
            // Finns den, så får vi tillbaka objektet.
            // Finns den inte, så får vi tillbaka null.
            // SELECT * FROM Courses WHERE Courses.CourseName = name;
            using (var schoolContext = new SchoolContext())
            {
                // Variabelnamnet _course är en konvention som är föreslagen av Microsoft.
                // _ betyder en lokal variabel inom metoden.
                var course = from _course in schoolContext.Courses
                              where string.Compare(_course.CourseName , name, 
                              StringComparison.InvariantCulture) == 0
                              select _course;
                // string.Compare är överkurs och har att göra med att om programmet hanterar data
                // i en viss teckentabell, som Latin1 eller ASCII och databasen har en annan teckentabell,
                // så kan du inte jämföra strängarna direkt med varandra, som 
                // _course.CourseName == name.
                // Om databasen och programmet "pratar" olika teckentabeller, så kommer
                // jämförelsen ovan inte fungera, utan vi behöver använda en mer generell metod.
                // Metoden returnerar 0 om båda är samma, -1 eller +1 beroende på på något som jag inte minns.
                // Vi kollar om två stängar är lika och är det de, så returnerar string.Compare(...) noll.
                // Alltså har vi hittat en kurs i databasen som heter samma sak som strängen "name".

                // Vi returnerar ett objekt till anropande program.
                return course.First();
            }
        }
        public void AddStudentToCourse(string studentName, string courseName)
        {
            new StudentManager().AddStudentToCourse(studentName,courseName);
        }
    }
}
