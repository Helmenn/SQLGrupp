using SQL;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataInterface
{
    public interface IProvManager
    {
        public Prov AddProv(int Andel, string CourseName);
        public Prov GetProv(int id);
    }
}
