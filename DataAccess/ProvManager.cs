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
        public void AddProv(int Andel, int CourseID, int ProvresultatID, int ProvsvarID, int RättatSvarID, int SvarID, int SvarAltID, int FrågaID)
        {
            using (var schoolContext = new SchoolContext())
            {
                
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
                var allaFrågorFörProv = from frågor in schoolContext.Frågor
                                        where frågor.Prov == prov
                                        select frågor;
                foreach(var fråga in allaFrågorFörProv)
                {
                    Console.WriteLine(fråga.FrågText);
                }
            }
        }



    }
}
