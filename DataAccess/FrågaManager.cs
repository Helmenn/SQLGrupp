using SQL;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class FrågaManager
    {
        public void AddFråga(string text, int provID)
        {
            using (var schoolContext = new SchoolContext())
            {
                var fråga = new Fråga();
                fråga.FrågText = text;
                fråga.ProvID = provID;
                schoolContext.Fråga.Add(fråga);
            }
        }
    }
}
