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

        public void RättaProv(int provid, int studentid)
        {
            
        }

        

    }
}
