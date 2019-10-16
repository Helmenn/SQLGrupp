using System;
using System.Collections.Generic;
using System.Text;
using SQL;
using DataInterface;

namespace DataAccess
{
    public class ProvsvarManager : IProvsvarManager
    {
        public Provsvar AddSkrivetProv(Prov prov, Student student)
        {
            throw new NotImplementedException();
        }
        public Svar AddSvar(Provsvar provsvar, Fråga fråga, Svaralt svaralt)
        {
            throw new NotImplementedException();
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