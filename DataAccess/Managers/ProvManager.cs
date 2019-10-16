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
        public Svaralt AddSvarAlt(string SvarAltText, bool Rätt, int FrågaID)
        {
            using (var schoolContext = new SchoolContext())
            {
                var svarAlt = new Svaralt();
                svarAlt.SvaraltText = SvarAltText;
                svarAlt.Rätt = Rätt;
                svarAlt.FrågaID = FrågaID;
                schoolContext.Svaralt.Add(svarAlt);
                schoolContext.SaveChanges();
                return svarAlt;
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
    }
}
