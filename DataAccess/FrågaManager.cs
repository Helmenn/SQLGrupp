using SQL;
using System;
using System.Collections.Generic;
using System.Text;
using DataInterface;
using System.Linq;

namespace DataAccess
{
    public class FrågaManager : IFrågaManager
    {
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
    }
}
