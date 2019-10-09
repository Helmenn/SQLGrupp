using System;
using System.Collections.Generic;
using System.Text;
using DataInterface;
using SQL;

namespace DataAccess
{
    public class BetygsgradManager : IBetygsgradManager
    {
        public void AddBetygsgrad(int courseid, int poäng, string betyg)
        {
            using (var schoolContext = new SchoolContext())
            {
                var betygsgrad = new Betygssgrad();
                betygsgrad.CourseID = courseid;
                betygsgrad.Poäng = poäng;
                betygsgrad.Betyg = betyg;
                schoolContext.Betygssgrad.Add(betygsgrad);
                schoolContext.SaveChanges();
            }
        }
    }
}
