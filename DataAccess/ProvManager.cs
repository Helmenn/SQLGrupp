using DataInterface;
using SQL;
using System;
using System.Collections.Generic;
using System.Text;

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
    }
}
