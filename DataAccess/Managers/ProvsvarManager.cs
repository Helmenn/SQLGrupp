using System;
using SQL;
using DataInterface;
using System.Linq;

namespace DataAccess
{
    public class ProvsvarManager : IProvsvarManager
    {
        public Provsvar AddSkrivetProv(Prov prov, Student student)
        {
            using (var schoolContext = new SchoolContext())
            {
                var provSvar = new Provsvar();
                provSvar.Prov = prov;
                provSvar.Student = student;
                schoolContext.Provsvar.Add(provSvar);
                schoolContext.SaveChanges();
                return provSvar;
            }
        }
        public void AddSvar(Provsvar provsvar, Fråga fråga, Svaralt svaralt)
        {
            using (var SchoolContext = new SchoolContext())
            {
                var svar = new Svar();
                svar.ProvsvarID = provsvar.ProvsvarID;
                svar.FrågaID = fråga.FrågaID;
                svar.SvaraltID = svaralt.SvaraltID;
                SchoolContext.Svar.Add(svar);
                SchoolContext.SaveChanges();
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