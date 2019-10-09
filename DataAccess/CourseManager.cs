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
        public void AddCourse(string name, int roomid, string teacherName)
        {
            using (var schoolContext = new SchoolContext())
            {
                // Kolla om det redan finns en lärare som heter teacherName


                // Skapa läraren om den inte finns

                // Hämta nytt lärarobjekt


                // Kolla om det redan finns en kurs med namnet name

                // Skapa kursen om den inte finns

                // Hämta kursobjektet
                
                // Lägg till kurs och lärare




            }
        }

        public Courses GetCourseByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
