using SQL;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataInterface
{
    public interface IProvManager
    {
        public void AddProv(int Andel, int CourseID);
        public void RättaProv(int provid, int studentid);
        public Prov GetProv(int id);
    }
}
