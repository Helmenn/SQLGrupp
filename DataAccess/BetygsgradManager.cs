using System;
using System.Collections.Generic;
using System.Text;
using DataInterface;
using SQL;

namespace DataAccess
{
    public class BetygsgradManager : IBetygsgradManager
    {
        public void AddBetygsgrad(Courses course, int poäng, string betyg)
        {
            using (var schoolContext = new SchoolContext())
            {
                var betygsgrad = new Betygssgrad();
                betygsgrad.Courses = course;
                betygsgrad.Poäng = poäng;
                betygsgrad.Betyg = betyg;
                schoolContext.Betygssgrad.Add(betygsgrad);
            }
        }
    }
}
