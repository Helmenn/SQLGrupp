using DataInterface;
using SQL;
using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;

namespace DataAccess
{
    public class ProvManager : IProvManager

    {
        public Prov AddProv(int Andel, string CourseName)
        { // Vi får in en andel i procent. Detta bestämmer hur viktigt provet är.
            // Sedan blir det ett kursnamn
            // Provet har inget eget namn,
            // Vi skapar provet och returnerar sedan en länk itll provet, så att vi kan
            // skapa frågor till rätt prov.
            using (var schoolContext = new SchoolContext())
            {
                ICourseManager courseManager = new CourseManager();
                // Vi tar reda på om det finns en kurs som heter det vi vill lägga ett prov på.
                var course = courseManager.GetCourseByName(CourseName);
                // Finns kursen, så kan vi skapa provet och returnera provobjektet
                // till anropande program, så att vi sedan kan lägga till frågor på
                // rätt prov.
                if (course != null)
                {
                    var prov = new Prov();
                    prov.Andel = Andel;
                    prov.Courses = course;
                    prov.CourseId = course.CourseID;
                    schoolContext.Prov.Add(prov);
                    schoolContext.SaveChanges();
                    return prov;
                }
                // Vi returnerar null om vi inte kunde skapa ett prov.
                // Detta ska vi ta hand om i koden i vårt anropande program, så att användaren
                // får reda på att det inte fanns en kurs som heter det användaren trodde.
                return null;
            }
        }

        public Fråga AddFråga(string text, int provID)
        {
            using (var schoolContext = new SchoolContext())
            {
                var fråga = new Fråga();
                fråga.FrågText = text;
                fråga.ProvID = provID;
                schoolContext.Fråga.Add(fråga);
                schoolContext.SaveChanges();
                return fråga;
            }
        }
        public IQueryable<Fråga> GetFrågorByProvID(int provid)
        {
            using (var schoolContext = new SchoolContext())
            {
                var allaFrågorFörProv = from frågor in schoolContext.Fråga
                                        where frågor.ProvID == provid
                                        select frågor;
                return allaFrågorFörProv;
            }
        }

        public void AddSvarAlt(string SvarAltText, bool Rätt, int FrågaID)
        {
            using (var schoolContext = new SchoolContext())
            {
                var SvarAlt = new Svaralt();
                SvarAlt.SvaraltText = SvarAltText;
                SvarAlt.Rätt = Rätt;
                SvarAlt.FrågaID = FrågaID;
                schoolContext.Svaralt.Add(SvarAlt);
                schoolContext.SaveChanges();
            }
        }
        /// <summary>
        /// Hämtar ett provobjekt baserat på dess ID.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>
        /// Returnerar ett provebjekt.
        /// </returns>
        public Prov GetProv(int id)
        {
            using (var schoolContext = new SchoolContext())
            {
                var prov = from _prov in schoolContext.Prov
                           where _prov.ProvID == id
                           select _prov;
                return prov.First();
            }
        }
        public void AddRättatSvar(int SvarID, int SvarAltID, bool Rätt)
        {
            using (var schoolContext = new SchoolContext())
            {
                var rättatSvar = new RättatSvar();
                rättatSvar.SvaraltID = SvarAltID;
                rättatSvar.SvarID = SvarID;
                rättatSvar.Rätt = Rätt;
                schoolContext.RättatSvar.Add(rättatSvar);
                schoolContext.SaveChanges();
            }
        }

        public void RättaProv(int provid, string studentName)
        {
            using (var schoolContext = new SchoolContext())
            {
                // Hämta Prov med frågor, svar, svarslternativ,
                // och elevens svar.
                var studentManager = new StudentManager();
                var student = studentManager.GetStudentByName(studentName);

                Provsvar provatträtta = (from _provsvar in schoolContext.Provsvar
                                    where _provsvar.ProvID == provid &&
                                    _provsvar.studentID == student.StudentID
                                    select _provsvar).First();
                var antalRätt = 0;
                var totaltAntalFrågor = 0;
                foreach (var provfråga in provatträtta.Svar)
                {
                    AddRättatSvar(provfråga.SvarID, provfråga.SvaraltID, provfråga.Svaralt.Rätt);
                    totaltAntalFrågor++;
                    // Kolla om elevens svar är rätt jämfört med provets svarsalternativ.
                    if (provfråga.Svaralt.Rätt)
                    {
                        antalRätt++;
                    }
                }
            }
        }
    }
}
