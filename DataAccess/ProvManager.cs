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
        public void AddProv(int Andel, int CourseID)
        {
            using (var schoolContext = new SchoolContext())
            {
                var Prov = new Prov();
                Prov.Andel = Andel;
                Prov.CourseId = CourseID;
                schoolContext.Prov.Add(Prov);
            }
        }

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

        public void RättaProv(Prov prov, Student student)
        {
            using (var schoolContext = new SchoolContext())
            {
                var allaFrågorFörProv = from frågor in schoolContext.Fråga
                                        where frågor.Prov == prov
                                        select frågor;
                foreach(var fråga in allaFrågorFörProv)
                {
                    Console.WriteLine(fråga.FrågText);
                }


                var provSvar = from _provSvar in schoolContext.Provsvar
                               where _provSvar.ProvID == prov.ProvID && _provSvar.studentID == student.StudentID
                               select _provSvar;

                var allaSvarFrånStudent = from svar in schoolContext.Svar
                                          where svar.Provsvar == provSvar.First()
                                          select svar;
            }
        }



    }
}
