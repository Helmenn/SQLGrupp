using DataInterface;
using SQL;
using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;

namespace DataAccess
{
    public class SvarAltManager : ISvarAltManger
    {
        public void AddSvarAlt(string SvarAltText, bool Rätt,int FrågaID)
        {
            using (var schoolContext = new SchoolContext())
            {
                var SvarAlt = new Svaralt();
                SvarAlt.SvaraltText = SvarAltText;
                SvarAlt.Rätt = Rätt;
                SvarAlt.FrågaID = FrågaID;
                schoolContext.Svaralt.Add(SvarAlt);
            }
        }

    }
}
