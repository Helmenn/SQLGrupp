using DataInterface;
using SQL;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class ProvManager : IProvManager

    {
        public void AddProv(int Andel, int CourseID, int ProvresultatID, int ProvsvarID, int RättatSvarID, int SvarID, int SvarAltID, int FrågaID)
        {
            using (var schoolContext = new SchoolContext())
            {
                
            }
        }
    }
}
