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
        public void AddProv(int Andel, string CourseName)
        {
            using (var schoolContext = new SchoolContext())
            {
                ICourseManager courseManager = new CourseManager();
                var course = courseManager.GetCourseByName(CourseName);

                if (course != null)
                {
                    var Prov = new Prov();
                    Prov.Andel = Andel;
                    Prov.Courses = course;
                    Prov.CourseId = course.CourseID;
                    schoolContext.Prov.Add(Prov);
                    schoolContext.SaveChanges();
                }
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
